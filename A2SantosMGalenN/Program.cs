/* Program.cs
 * Console Application to calculate online registration for a monthly subscription company. 
 * 
 * Revision History:
 *   Matheus Santos and Nicholas Galen, 2024.02.04: Created 
 *  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SantosMGalenN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int age;
            string startMonth;
            string referredByClient;
            double ageFee;
            double startMonthAdjustment;
            double clientReferralDiscount;
            double subtotal;
            double finalFee;
            double hst;
            double cityServicesTaxes; 
            double hstRate = 0.13;
            double cityServicesTaxRate = 0.08;


            //Step 1: Age Fee
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 19)
            {
                ageFee = 10;
            }
            else if(age >=20 && age <= 29)
            {
                ageFee = 25.50;
            }
            else if (age >= 30 && age <= 59)
            {
                ageFee = 50.50;
            }
            else
            {
                ageFee = 0;
            }

            //Step 2: Start Month Adjustment
            Console.WriteLine("Enter the start month of your subscription (e.g. January): ");
            startMonth = Console.ReadLine().ToLower();

            switch (startMonth)
            {
                case "january":
                case "february":
                    startMonthAdjustment = -10;
                    break;
                case "march":
                case "april":
                    startMonthAdjustment = ageFee * 0.10;
                    break;
                case "may":
                    startMonthAdjustment = 20;
                    break;
                default:
                    startMonthAdjustment = 0;
                    break;
            }

            //Step 3: Client Referral Discount
            Console.WriteLine("Have you been referred by an existing client? (Y/N): ");
            referredByClient = Console.ReadLine().ToUpper();
            
            if (referredByClient == "Y")
            {
                clientReferralDiscount = - 10.50;
            }
            else 
            {
                clientReferralDiscount = 0;
            }

            //Step 4: Subtotal
            subtotal = ageFee + startMonthAdjustment + clientReferralDiscount;
           
            if(subtotal < 0)
            {
                subtotal = 0;
            }

            //Step 5: Taxes
            hst = subtotal * hstRate;
            cityServicesTaxes = subtotal * cityServicesTaxRate;

            //Step 6: Final Fee
            finalFee = subtotal + hst + cityServicesTaxes;

            //Step 7: Outputs
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("Your age: " + age + " years old.");
            Console.WriteLine("Your registration month: " + startMonth);

            Console.WriteLine("\nMonthly subscription based on age: $" + ageFee.ToString("0.00"));//The ("0.00") formats the number as a string with 2 decimal places.
            Console.Write("Start monthly adjustment:        ");
            if (startMonthAdjustment < 0)
            {
                //The Math.Abs() function has been added to display some values ensuring it is displayed as a positive value.
                Console.WriteLine(" -$" + Math.Abs(startMonthAdjustment).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("  $" + startMonthAdjustment.ToString("0.00"));
            }

            Console.Write("Client referral adjustment:      ");
            if (clientReferralDiscount < 0)
            {
                //The Math.Abs() function has been added to display some values ensuring it is displayed as a positive value.
                Console.WriteLine(" -$" + Math.Abs(clientReferralDiscount).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("  $" + clientReferralDiscount.ToString("0.00"));
            }

            Console.WriteLine("Subtotal:                          $" + subtotal.ToString("0.00"));

            Console.WriteLine("\nHST:                               $" + hst.ToString("0.00"));
            Console.WriteLine("City Services Tax:                 $" + cityServicesTaxes.ToString("0.00"));

            Console.WriteLine("\nFinal Monthly Subscription Total:  $" + finalFee.ToString("0.00"));

            // Exit the program
            Console.ReadKey();
        }
    }
}
