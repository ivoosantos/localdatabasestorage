﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace localdatabasestorage
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
