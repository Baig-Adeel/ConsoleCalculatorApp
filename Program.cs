// See https://aka.ms/new-console-template for more information
using ConsoleCalculatorApp;
using System.Security.Cryptography.X509Certificates;

double input1 = 0;
double input2 = 0;
int operation = 0;
double result = 0;
Calculator objCalc = new Calculator();

Console.WriteLine("\t\tWellcome to Calculator App");
Console.WriteLine("-------------------------------------------------------------------");

while (operation != 5)
{
    Console.WriteLine("\t1:Divide\t2:Multiply\t3:Add\t4:Subtract\t5:Exit");
    Console.WriteLine("\t\t Please select an Operation from 1 to 5");
    try
    {
        operation = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {

        //Console.WriteLine("Please enter numbers only");
    }
    

    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("\tDividing....");
                getFirstValidNumber();
                getSecondValidNumber();
                if (input2 == 0)
                {
                    Console.WriteLine("\tYour Answer is Infinity....");
                }
                else
                {
                    result = objCalc.Divide(input1, input2);
                    Console.WriteLine($"\t Your Answer is : {result} ");
                    Console.WriteLine("-------------------------------------------------------------------\n\n");
                }
            }
            break;
        case 2:
            {
                Console.WriteLine("\tMultiplying....");
                getFirstValidNumber();
                getSecondValidNumber();
                result = objCalc.Multiply(input2, input2);
                Console.WriteLine($"\t Your Answer is :{result} ");
                Console.WriteLine("-------------------------------------------------------------------\n\n");
            }
            break;
        case 3:
            {
                Console.WriteLine("\tAdding....");
                getFirstValidNumber();
                getSecondValidNumber();
                result = objCalc.Add(input1, input2);
                Console.WriteLine($"\t Your Answer is :{result} ");
                Console.WriteLine("-------------------------------------------------------------------\n\n");
            }
            break;
        case 4:
            {
                Console.WriteLine("\tSubtracting....");
                getFirstValidNumber();
                getSecondValidNumber();
                result = objCalc.Subtract(input1, input2);
                Console.WriteLine($"\t Your Answer is :{result} ");
                Console.WriteLine("-------------------------------------------------------------------\n\n");
            }
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Please Select a valid number");
            break;
    }
}

    void getFirstValidNumber()
    {
        Console.WriteLine("\t Please enter your 1st Number");
        try
        {
            input1 = double.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            
            Console.WriteLine("\t Please enter a valid number");
            getFirstValidNumber();
        }
    }
    void getSecondValidNumber()
    {
        Console.WriteLine("\t Please enter your 2nd Number");
        try
        {
            input2 = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            
            Console.WriteLine("\t Please enter a valid number");
            getSecondValidNumber();
        }

    }



