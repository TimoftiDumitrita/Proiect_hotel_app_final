using Proiect_hotel_app.Models;

namespace Proiect_hotel_app;

public partial class RezervareListPage : ContentPage
{
	public RezervareListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e) { 
		var slist = (Rezervare)BindingContext; 
		slist.Date = DateTime.UtcNow;
		await App.Database.SaveShopListAsync(slist);
		await Navigation.PopAsync(); }
    async void OnDeleteButtonClicked(object sender, EventArgs e) { 
		var slist = (Rezervare)BindingContext;
		await App.Database.DeleteShopListAsync(slist); 
		await Navigation.PopAsync(); 
	}
}