using Dentora.Models;
using System;
using System.Collections.Generic;

namespace Dentora.Services.Interfaces
{
    public interface IAppointmentService
    {
        void CreateAppointment(Guid userId, Guid treatmentId, DateTime appointmentDate);
        void CreateAppointment(Guid userId, Guid treatmentId, DateTime appointmentDate, Guid? doctorId);
        List<Appointment> GetAppointmentsByUser(Guid userId);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetCompletedAppointmentsByUser(Guid userId);
        void CancelAppointment(Guid id);
        void CompleteAppointment(Guid id);
        bool IsTimeSlotFree(DateTime dateTime, int durationMinutes);
    }
}
