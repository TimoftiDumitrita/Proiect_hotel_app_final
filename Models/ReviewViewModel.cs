using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Proiect_hotel_app.Data;
using Proiect_hotel_app.Models;

namespace Proiect_hotel_app.ViewModels
{
    public class ReviewViewModel
    {
        public ObservableCollection<Reviews> Reviews { get; set; }

        public ReviewViewModel()
        {
            LoadReviews();
        }

        private async void LoadReviews()
        {
            var database = new ReviewDatabase("path_to_database");
            var reviews = await database.GetReviewsAsync();
            Reviews = new ObservableCollection<Reviews>(reviews);
        }

        public async Task SaveReviewAsync(Reviews review)
        {
            var database = new ReviewDatabase("path_to_database");
            await database.SaveReviewAsync(review);
            LoadReviews();
        }

        public async Task DeleteReviewAsync(Reviews review)
        {
            var database = new ReviewDatabase("path_to_database");
            await database.DeleteReviewAsync(review);
            LoadReviews();
        }
    }
}
