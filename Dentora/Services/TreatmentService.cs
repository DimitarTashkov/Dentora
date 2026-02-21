using Microsoft.EntityFrameworkCore;
using Dentora.Data;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dentora.Services
{
    public class TreatmentService : ITreatmentService
    {
        private DentoraDbContext CreateContext() => new DentoraDbContext();

        public List<Treatment> GetAllTreatments()
        {
            using var context = CreateContext();
            return context.Treatments.ToList();
        }

        public List<Treatment> GetTreatmentsByCategory(string category)
        {
            using var context = CreateContext();
            return context.Treatments
                .Where(t => t.Category == category && t.IsActive)
                .ToList();
        }

        public void AddTreatment(Treatment treatment)
        {
            using var context = CreateContext();
            if (treatment.Id == Guid.Empty)
                treatment.Id = Guid.NewGuid();

            treatment.Image ??= Array.Empty<byte>();

            context.Treatments.Add(treatment);
            context.SaveChanges();
        }

        public void UpdateTreatment(Treatment treatment)
        {
            using var context = CreateContext();
            var existing = context.Treatments.Find(treatment.Id);
            if (existing != null)
            {
                existing.Title = treatment.Title;
                existing.Category = treatment.Category;
                existing.Description = treatment.Description;
                existing.Image = treatment.Image ?? Array.Empty<byte>();
                existing.DurationMinutes = treatment.DurationMinutes;
                existing.Price = treatment.Price;
                existing.IsActive = treatment.IsActive;
                context.SaveChanges();
            }
        }

        public void DeleteTreatment(Guid id)
        {
            using var context = CreateContext();
            var treatment = context.Treatments.Find(id);
            if (treatment != null)
            {
                context.Treatments.Remove(treatment);
                context.SaveChanges();
            }
        }

        public Treatment GetTreatmentById(Guid id)
        {
            using var context = CreateContext();
            return context.Treatments.Find(id);
        }
    }
}
