using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class employee : person, IQtable
    {
        public int ID { get; set; }     //  Employee class member

        public override void SayName()  //  Called the method SayName
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);   //  Prints
        }

        public void Quit(employee employee)  // Calling the Quit method
        {
            Console.WriteLine("This method of interface is implemented on employee object for the student with the ID number " + ID + ".");
            Console.ReadLine();

        }
    }
}