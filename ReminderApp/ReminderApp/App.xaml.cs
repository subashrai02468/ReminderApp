using System;
using System.IO;
using ReminderApp.Data;
using Xamarin.Forms;

namespace ReminderApp
{
    public partial class App : Application
    {
        static ReminderDatabase database;

        // Create the database connection as a singleton.
        public static ReminderDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ReminderDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Reminders.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}