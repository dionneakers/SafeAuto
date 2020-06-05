using System;
using System.IO;
using log4net;

namespace CodeKata
{
    public class TripProcess{

        public TripResult Process(string file)
        {
            var fileInfo = new FileInfo(file); // throws ArgumentNullException
            if (fileInfo.Exists == false || fileInfo.Length == 0)
            {
                throw new ArgumentException("File must exist and have a length greater than zero", nameof(file));
            }
            
            //https:docs.microsoft.com/en-us/dotnet/api/system.io.file.openread?view=netcore-3.1
            var fs = new FileStream(fileInfo.FullName, FileMode.Open)
            {
                return Process(fs);
            }
        }
    }
}
