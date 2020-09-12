//Devante Little
// Commissioned salary calculator
//this program asks for employee name and weekly earnings and displays the paycheck stub with all the calculated values.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalaryCalculator
{
    class SalaryCalculator
    {
        static void Main(string[] args)                                             // constants
        {
            const double COMMISSION = .07,
                         TAX_FED = .18,
                         TAX_RET = .15,
                         TAX_SOC = .09;

            double commission_Cut, tax_Fed, tax_Ret, social_Tax, pay_Final, deductions_Total, sales_Total;
            string name = GetInput("Employee Name:");
            sales_Total = double.Parse(GetInput("weekly sales"));


            commission_Cut = CalcMoney(sales_Total, COMMISSION);
            tax_Fed = CalcMoney(TAX_FED, commission_Cut);
            tax_Ret = CalcMoney(TAX_RET, commission_Cut);
            social_Tax = CalcMoney(TAX_SOC, commission_Cut);
            deductions_Total = AddCalc(tax_Fed, tax_Ret, social_Tax);
            pay_Final = CalcCheck(commission_Cut, deductions_Total);


            DisplayEarnings(name, commission_Cut, tax_Fed, tax_Ret, social_Tax, pay_Final, deductions_Total, sales_Total, TAX_FED, TAX_SOC, TAX_RET, COMMISSION);
        }



        public static string GetInput(string temp)
        {
            WriteLine("Please enter your {0}", temp);
            temp = ReadLine();
            return temp;
        }
        public static double CalcMoney(double amt1, double amt2)
        {
            return (amt1 * amt2);
        }

        public static double AddCalc(double tax1, double tax2, double tax3)
        {
            return (tax1 + tax2 + tax3);
        }


        public static double CalcCheck(double gain1, double lost2)
        {


            return (gain1 - lost2);
        }
        public static void DisplayEarnings(string name, double commission_Cut, double tax_Fed, double tax_Ret, double social_Tax, double deductions_Total, double pay_Final, double sales_Total,double TAX_FED,double TAX_SOC, double TAX_RET, double COMMISSION )

        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~output~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine();
            WriteLine("Employee Name : {0}", name);
            WriteLine();
            WriteLine("{0:P} of total commission was {1:c}",COMMISSION,commission_Cut);
            WriteLine();
            WriteLine("{0:p0} of Federal tax deductions was {1:c}",TAX_FED,tax_Fed );
            WriteLine();
            WriteLine("{0:p0} of retirement tax deductions was {1:c}",TAX_RET,tax_Ret);
            WriteLine();
            WriteLine("{0:p0} of social security tax deductions was {1:c}",TAX_SOC, social_Tax);
            WriteLine();
            WriteLine("Your total deductions were {0:c}",deductions_Total);
            WriteLine();
            WriteLine("Your final take home pay is {0:c}",pay_Final);
            WriteLine("____________________________________________________________________________");
        }

        }
     }
    
         


          




        

