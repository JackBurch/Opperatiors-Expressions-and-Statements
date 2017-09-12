using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opperatiors_Expressions_and_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I'm declaring variables
            int x, y, a, b;
            //Assigning values to these int
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //additional math opperators

            //addition 
            x = 3 + 4;
            //subtraction 
            x = 4 - 3;
            //multiplication
            x = 10 * 5;
            //division
            x = 10 / 5;
            //evaulation opperators
            //equalitys 
            if( x == y)
            {
            }
            //Greater than opperators
            if(x > y)
            {
            }
            //Less than opperators
            if(x < y)
            {
            }
        
            //Conditional Opperators
            //Conditional AND
            if (x > y) && (a > b){
            }
            //Conditional OR 
            if (x > y) || (a > b){
            }
            // in line conditional operator
            string message = (x == 1) ? "Car" : "Boat";
            //Member acess and Method invpocation
            Console.WriteLine("Hi");
            }
    }
}
