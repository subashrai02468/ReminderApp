﻿using ReminderApp.Views;
using Xamarin.Forms;

namespace ReminderApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ReminderEntryPage), typeof(ReminderEntryPage));
        }
    }
}