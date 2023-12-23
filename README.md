# ReminderApp
ReminderApp - Xamarin.Forms Project

This project involves building a multi-page ReminderApp using Xamarin.Forms, integrating an on-device SQLite database. It requires knowledge of XAML, C#, page navigation, data binding, and CRUD (Create, Read, Update, Delete) operations in a database context.

Application Description
The ReminderApp is designed to allow users to save and manage text-based reminders. It stores these reminders in a local SQLite database and includes two main pages for user interaction.

Pages Overview
Page 1: Reminder List
Displays a scrollable list of reminders entered by the user.
Each item in the list is selectable, leading to Page 2 for editing.
Includes a "+" button for adding new reminders, navigating to Page 2 with an empty entry area.
Page 2: Reminder Edit/Creation
Contains a display/entry area for reminders.
Features "Save" and "Delete" buttons.
"Save": Creates a new entry for new reminders or updates existing ones.
"Delete": Removes the reminder from the database or clears the text for new entries.
Footer
Both pages include a footer displaying the student ID and name (e.g., S123456 Bill Gunn), centered horizontally.

Development Requirements
Xamarin.Forms: For UI design and navigation.
SQLite: For local database management.
XAML/C#: For app logic and design.
Uses nuget packet manager for SQLite