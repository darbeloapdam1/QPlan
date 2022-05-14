using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace QPlan.Services
{
    public class FileReader : IFileReadWrite
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "login.txt");
        public static string[] constants = { "user:", ";", "password:" };
        public FileReader()
        {
        }

        public async Task<bool> CheckLoginData()
        {
            try
            {
                string text = await ReadFromFile();
                string[] datos = text.Split(';');
                string user = datos[0].Split(':')[1];
                string pass = datos[1].Split(':')[1];
                if (!user.Equals("") && !pass.Equals(""))
                {
                    return true;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return false;
        }

        public async Task<string[]> GetLoginData()
        {
            string text = await ReadFromFile();
            string[] datos = text.Split(';');
            string[] resul = new string[2];
            resul[0] = datos[0].Split(':')[1];
            resul[1] = datos[1].Split(':')[1];
            return resul;
        }

        public async Task<string> ReadFromFile()
        {
            string resul = string.Empty;
            TextReader reader = null;
            try
            {
                reader = new StreamReader(fileName);
                if (File.Exists(fileName))
                {
                    resul = await reader.ReadToEndAsync();
                }
            }catch(Exception ex)
            {
                throw new Exception("File Reading Error Occured", ex.InnerException);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
            return resul;
        }

        public async Task<bool> WriteToFile(string text)
        {
            bool resul = true;
            TextWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                await writer.WriteAsync(text);
            }catch(Exception ex)
            {
                throw new Exception("File writing error occured", ex.InnerException);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
            return resul;
        }
    }
}
