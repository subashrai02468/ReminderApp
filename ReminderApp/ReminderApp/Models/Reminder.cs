using System;
using SQLite;

namespace ReminderApp.Models
{
    public class Reminder
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}