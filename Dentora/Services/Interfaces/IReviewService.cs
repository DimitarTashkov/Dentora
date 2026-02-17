using Dentora.Models;
using System;
using System.Collections.Generic;

namespace Dentora.Services.Interfaces
{
    public interface IReviewService
    {
        void AddReview(Review review);
        List<Review> GetAllReviews();
        List<Review> GetReviewsByUser(Guid userId);
        bool HasReviewedAppointment(Guid appointmentId);
    }
}
