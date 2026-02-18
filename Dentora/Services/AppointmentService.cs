using Microsoft.EntityFrameworkCore;
using Dentora.Data;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dentora.Services
{
    public class AppointmentService : IAppointmentService
    {
        private DentoraDbContext CreateContext() => new DentoraDbContext();

        public void CreateAppointment(Guid userId, Guid treatmentId, DateTime appointmentDate)
        {
            using var context = CreateContext();
            var treatment = context.Treatments.Find(treatmentId);
            if (treatment == null)
                throw new Exception("Treatment not found.");

            if (!IsTimeSlotFree(appointmentDate, treatment.DurationMinutes))
                throw new Exception("This time slot is already booked.");

            var appointment = new Appointment
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                TreatmentId = treatmentId,
                AppointmentDate = appointmentDate,
                TotalPrice = treatment.Price,
                Status = "Pending"
            };

            context.Appointments.Add(appointment);
            context.SaveChanges();
        }

        public List<Appointment> GetAppointmentsByUser(Guid userId)
        {
            using var context = CreateContext();
            return context.Appointments
                .Include(a => a.Treatment)
                .Include(a => a.User)
                .Where(a => a.UserId == userId)
                .OrderByDescending(a => a.AppointmentDate)
                .ToList();
        }

        public List<Appointment> GetAllAppointments()
        {
            using var context = CreateContext();
            return context.Appointments
                .Include(a => a.User)
                .Include(a => a.Treatment)
                .OrderByDescending(a => a.AppointmentDate)
                .ToList();
        }

        public List<Appointment> GetCompletedAppointmentsByUser(Guid userId)
        {
            using var context = CreateContext();
            return context.Appointments
                .Include(a => a.Treatment)
                .Where(a => a.UserId == userId && a.Status == "Completed")
                .OrderByDescending(a => a.AppointmentDate)
                .ToList();
        }

        public void CancelAppointment(Guid id)
        {
            using var context = CreateContext();
            var appointment = context.Appointments.Find(id);
            if (appointment != null)
            {
                appointment.Status = "Cancelled";
                context.SaveChanges();
            }
        }

        public void CompleteAppointment(Guid id)
        {
            using var context = CreateContext();
            var appointment = context.Appointments.Find(id);
            if (appointment != null)
            {
                appointment.Status = "Completed";
                context.SaveChanges();
            }
        }

        public bool IsTimeSlotFree(DateTime dateTime, int durationMinutes)
        {
            using var context = CreateContext();
            var endTime = dateTime.AddMinutes(durationMinutes);
            return !context.Appointments
                .Include(a => a.Treatment)
                .Where(a => a.Status != "Cancelled")
                .Any(a => a.AppointmentDate < endTime &&
                          a.AppointmentDate.AddMinutes(a.Treatment.DurationMinutes) > dateTime);
        }
    }
}
