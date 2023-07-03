using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {

            employee employee = new employee(); //  instantiated an object of class "Employee"
            employee.firstName = "Ali";      //  First Property of the employee object
            employee.lastName = "Yasa";      //  Second property of the employee object 
            employee.SayName();                     //  Calling the "SayName" method on object of class "Employee"
            IQtable quittable = new employee();  //  Here the Employee object morphed to Iquittable interface
            employee.ID = 77;                   //  Third class member

            //  Interface method
            employee.Quit(employee);                //  This statement implements the "Quit" method with given parameter
            Console.ReadLine();                     //  Keeps the console open

        }
    }
}
