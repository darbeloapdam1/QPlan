using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QPlan.Services
{
    public interface IFileReadWrite
    {
        Task<bool> WriteToFile(string text);
        Task<string> ReadFromFile();
    }
}
