using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Practice2.Models;
using Practice2.Data;

using Xamarin.Forms;

namespace Practice2
{
    public partial class VehicleList : ContentPage
    {
        public VehicleList()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            vehicleList.ItemsSource = await App.Database.GetNotesAsync();
        }
        async void onAddVehicleClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VehicleEntryPage
            {
                BindingContext = new Vehicle()
            });
        }
        async void OnVehicleSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ExpensesList
                {
                    BindingContext = e.SelectedItem as Vehicle
                });
            }
            //var clickedTableRow = sender as TableRow;
            //int s = clickedTableRow.Id;

            //// s is the index of the row, so just retrieve the matching object
            //// from the data source
            //var selected = tableItems[s];
        }
    }
}
