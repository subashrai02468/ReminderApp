using System;
using System.IO;
using ReminderApp.Models;
using Xamarin.Forms;

namespace ReminderApp.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class ReminderEntryPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadReminder(value);
            }
        }

        public ReminderEntryPage()
        {
            InitializeComponent();

            // Set the BindingContext of the page to a new reminder.
            BindingContext = new Reminder();
        }

        async void LoadReminder(string itemId)
        {
            try
            {
                int id = Convert.ToInt32(itemId);
                // Retrieve the reminder and set it as the BindingContext of the page.
                Reminder reminder = await App.Database.GetReminderAsync(id);
                BindingContext = reminder;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load reminder.");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var reminder = (Reminder)BindingContext;
            reminder.Date = DateTime.UtcNow;
            if (!string.IsNullOrWhiteSpace(reminder.Text))
            {
                await App.Database.SaveReminderAsync(reminder);
            }

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var reminder = (Reminder)BindingContext;
            await App.Database.DeleteReminderAsync(reminder);

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }

    }
}