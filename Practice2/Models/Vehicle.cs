using System;
using SQLite;
namespace Practice2.Models
{
    public class Vehicle
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Expense { get; set; }
        public int Amount { get; set; }

    }
}
