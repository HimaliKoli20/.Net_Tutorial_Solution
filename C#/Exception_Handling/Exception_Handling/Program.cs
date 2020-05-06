using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {          
                streamReader = new StreamReader(@"C:\Users\DELL\Desktop\Git Practice\Server SQL\Text file\Test1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }

        //Most specific exceptions are always written on the top 
            catch(FileNotFoundException ex)
            {
                // Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Please check if file {0} exists ", ex.FileName);
            }
            //All exception inherites from base exception class
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if(streamReader!=null)
                {
                    streamReader.Close();
                }               
            }            
        }
    }
}
