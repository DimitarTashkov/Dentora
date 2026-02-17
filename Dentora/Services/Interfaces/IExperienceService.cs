using Dentora.Models;
using System;
using System.Collections.Generic;

namespace Dentora.Services.Interfaces
{
    public interface ITreatmentService
    {
        List<Treatment> GetAllTreatments();
        List<Treatment> GetTreatmentsByCategory(string category);
        void AddTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);
        void DeleteTreatment(Guid id);
        Treatment GetTreatmentById(Guid id);
    }
}
