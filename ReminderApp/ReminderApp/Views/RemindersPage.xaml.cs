using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ReminderApp.Models;
using Xamarin.Forms;

namespace ReminderApp.Views
{
    public partial class RemindersPage : ContentPage
    {
        public RemindersPage()
        {
            InitializeComponent();
        }


        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the ReminderEntryPage, without passing any data.
            await Shell.Current.GoToAsync(nameof(ReminderEntryPage));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve all the reminders from the database, and set them as the
            // data source for the CollectionView.
            collectionView.ItemsSource = await App.Database.GetRemindersAsync();
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the ReminderEntryPage, passing the ID as a query parameter.
                Reminder reminder = (Reminder)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(ReminderEntryPage)}?{nameof(ReminderEntryPage.ItemId)}={reminder.ID.ToString()}");
            }
        }
    }
}