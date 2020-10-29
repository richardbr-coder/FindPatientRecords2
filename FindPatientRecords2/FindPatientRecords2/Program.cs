using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FindPatientRecords2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read and show from the file
            string line = "";
            int id;
            Console.WriteLine("Enter minimum balance:");
            id = Convert.ToInt32(Console.ReadLine());
            //Try
            try
            {
                //text reader
                using (StreamReader sr = new StreamReader("PatientRecords.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        //split the line to extract the balance
                        string[] tokens = line.Split(' ');
                        //if balance is gretaer than entered
                        if (Convert.ToInt32(tokens[2]) >= id)
                            Console.WriteLine(line);
                    }
                }
            }
            //Exception handling
            catch
            {
                Console.WriteLine("ERROR - The file is invalid or no data found");
            }
            Console.ReadKey();
        }
    }
}