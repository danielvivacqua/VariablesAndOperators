using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int age = 65;
            //    string why = "because I said so";
            //    char firstInitial = 'L';

            Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double amountEach = 13.53d;

            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine("Reservation: " +  reserveName);
            Console.WriteLine("Total Due: $" + totalBill);














            ////initializing new firstname variable
            //string firstName = "Mike";
            ////Printing the value of firstName to the console
            //Console.WriteLine(firstName);

            //int birthMonth = 10;
            //Console.WriteLine(birthMonth);



        }
    }
}
