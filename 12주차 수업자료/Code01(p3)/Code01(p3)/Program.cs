using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code01_p3_
{
    class Program
    {

        static void OnWrongPathType(String type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(
                    "Usage: ConsoleApp1.exe<Path> [Type:File/Directory]");
            }

            String path = args[0];
            String type = "File";
            if(args.Length > 1)
            {
                type = args[1];
            }

            if (File.Exists(path) || Directory.Exists(path))
            {
                if(type == "File")
                {
                    File.SetLastWriteTime(path, DateTime.Now);
                }else if(type == "Directory")
                {
                    Directory.SetLastWriteTime(path, DateTime.Now);
                }
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} {type}");

            }
            else
            {
                if(type == "File")
                {
                    File.Create(path).Close();
                }else if(type == "Directory")
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Created {path} {type}");

            }





        }
    }
}
