using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public class FeedbckRepository : IFeedbackRepository
    {
        private readonly ClothesDbContext clothesDbContext;
        public FeedbckRepository(ClothesDbContext clothDbContext)
        {
            clothesDbContext = clothDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            clothesDbContext.Feedbacks.Add(feedback);
            clothesDbContext.SaveChanges();
        }
    }
}
