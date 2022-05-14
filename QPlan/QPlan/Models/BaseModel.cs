using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string foto { get; set; }
        public BaseModel()
        {

        }
    }
}
