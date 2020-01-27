using System;
using System.Collections.Generic;
using Practice2.Models;
using Practice2.Data;
using SQLite;

using Xamarin.Forms;

namespace Practice2
{
    public partial class ExpenseEntryPage : ContentPage
    {
        public ExpenseEntryPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)BindingContext;

            await App.Database.SaveNoteAsync(vehicle);
            await Navigation.PopAsync();
        }
    }
}
