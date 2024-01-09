using Proiect_hotel_app.Models;
using Proiect_hotel_app.ViewModels;
using System;

namespace Proiect_hotel_app;

public partial class Review : ContentPage
{
    private readonly ReviewViewModel viewModel;

    public Review()
    {
        InitializeComponent();
        viewModel = new ReviewViewModel();
    }

    private async void OnSubmitReviewClicked(object sender, EventArgs e)
    {
        var newReview = new Reviews
        {
           
            Rate = (int)ratingSlider.Value,
            Message = messageEditor.Text,
           
        };

        await viewModel.SaveReviewAsync(newReview);
    }
}