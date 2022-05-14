using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QPlan.Services
{
    public class Constants
    {
        public const string DatabaseFilename = "QPlanSQLite.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite | // open the database in read/write mode
            SQLiteOpenFlags.Create |    // create the database if it doesn't exist
            SQLiteOpenFlags.SharedCache;// enable multi-threaded database access

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
