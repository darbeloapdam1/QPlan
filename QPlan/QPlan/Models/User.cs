using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public int esEstablecimiento { get; set; }
    }
}
