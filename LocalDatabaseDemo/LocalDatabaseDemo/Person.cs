using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LocalDatabaseDemo
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
