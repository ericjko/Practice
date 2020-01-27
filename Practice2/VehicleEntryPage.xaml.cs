using System;
using Practice2.Models;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Practice2
{
    public partial class VehicleEntryPage : ContentPage
    {
        public VehicleEntryPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)BindingContext;
            
            await App.Database.SaveNoteAsync(vehicle);
            await Navigation.PopAsync();
        }
        //async void OnDeleteButtonClicked(object sender, EventArgs e)
        //{
        //    var vehicle = (Vehicle)BindingContext;
        //    await App.Database.DeleteNoteAsync(vehicle);
        //    await Navigation.PopAsync();
        //}
    }
}
