using System;
using static System.Console;
//Name: Karly Lamm
//Date: October 20th, 2020
/*Program Description: This is our first program using C#
 * This was written for module 1 */


namespace Module1_FirstAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize variables
            int quantity = 0;
            double item_price = 0.0;
            double total_price = 0.0;

            const double OVER_BUDGET_AMOUNT = 100.00;

            //prompt the user for values in variables
            Write("Enter the item price: ");
            item_price = Convert.ToDouble(ReadLine());

            Write("Enter the quantity purchased: ");
            quantity = Convert.ToInt32(ReadLine());

            //Calculate the total price
            total_price = item_price * quantity;

            if (total_price > OVER_BUDGET_AMOUNT)
            {
                WriteLine("You are over budget!");
            }

            WriteLine("The total is {0}", total_price.ToString("C"));

        }
    }
}


