using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Repositories
{
    public interface ReviewRepository
    {
        List<Review> GetReviewsByUser(int userId);
        List<Review> GetReviewsByBook(int bookId);
        Review GetReview(int id);
        void CreateReview(Review review);
        void UpdateReview(int id, Review review);
        void DeleteReview(int id);
    }
}