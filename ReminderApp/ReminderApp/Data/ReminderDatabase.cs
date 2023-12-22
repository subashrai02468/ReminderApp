using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ReminderApp.Models;

namespace ReminderApp.Data
{
    public class ReminderDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ReminderDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Reminder>().Wait();
        }

        public Task<List<Reminder>> GetRemindersAsync()
        {
            //Get all reminders.
            return database.Table<Reminder>().ToListAsync();
        }

        public Task<Reminder> GetReminderAsync(int id)
        {
            // Get a specific reminder.
            return database.Table<Reminder>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveReminderAsync(Reminder reminder)
        {
            if (reminder.ID != 0)
            {
                // Update an existing reminder.
                return database.UpdateAsync(reminder);
            }
            else
            {
                // Save a new reminder.
                return database.InsertAsync(reminder);
            }
        }

        public Task<int> DeleteReminderAsync(Reminder reminder)
        {
            // Delete a reminder.
            return database.DeleteAsync(reminder);
        }
    }
}