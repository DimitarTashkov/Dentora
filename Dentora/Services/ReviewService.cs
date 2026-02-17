using Microsoft.EntityFrameworkCore;
using Dentora.Data;
using Dentora.Models;
using Dentora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dentora.Services
{
    public class ReviewService : IReviewService
    {
        private DentoraDbContext CreateContext() => new DentoraDbContext();

        public void AddReview(Review review)
        {
            using var context = CreateContext();
            if (review.Id == Guid.Empty) review.Id = Guid.NewGuid();
            review.CreatedAt = DateTime.Now;
            context.Reviews.Add(review);
            context.SaveChanges();
        }

        public List<Review> GetAllReviews()
        {
            using var context = CreateContext();
            return context.Reviews
                .Include(r => r.User)
                .Include(r => r.Appointment)
                    .ThenInclude(a => a.Treatment)
                .OrderByDescending(r => r.CreatedAt)
                .ToList();
        }

        public List<Review> GetReviewsByUser(Guid userId)
        {
            using var context = CreateContext();
            return context.Reviews
                .Include(r => r.Appointment)
                    .ThenInclude(a => a.Treatment)
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.CreatedAt)
                .ToList();
        }

        public bool HasReviewedAppointment(Guid appointmentId)
        {
            using var context = CreateContext();
            return context.Reviews.Any(r => r.AppointmentId == appointmentId);
        }
    }
}
