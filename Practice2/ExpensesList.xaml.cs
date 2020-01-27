using System;
using System.Collections.Generic;
using Practice2.Models;
using Practice2.Data;

using Xamarin.Forms;

namespace Practice2
{
    public partial class ExpensesList : ContentPage
    {
        public ExpensesList()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            expenseList.ItemsSource = await App.Database.GetNotesAsync();
        }
        async void onAddExpenseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpenseEntryPage
            {
                BindingContext = new Vehicle()
            });
        }
        //async void OnExpenseSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem != null)
        //    {
        //        await Navigation.PushAsync(new ExpenseCalculation
        //        {
        //            BindingContext = e.SelectedItem as Vehicle
        //        });
        //    }
        //}
    }
}
