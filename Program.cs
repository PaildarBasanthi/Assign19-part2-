using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19part2
{
    public delegate T Operation<T>(T num1, T num2);

    internal class Program
    {
        public static T Add<T>(T num1, T num2)
        {
            dynamic dNum1 = num1;
            dynamic dNum2 = num2;
            return dNum1 + dNum2;
        }
        public static T Subtract<T>(T num1, T num2)
        {
            dynamic dNum1 = num1;
            dynamic dNum2 = num2;
            return dNum1 - dNum2;
        }
        public static T Multiply<T>(T num1, T num2)
        {
            dynamic dNum1 = num1;
            dynamic dNum2 = num2;
            return dNum1 * dNum2;
        }
        public static T Divide<T>(T num1, T num2)
        {
            dynamic dNum1 = num1;
            dynamic dNum2 = num2;
            return dNum1 / dNum2;
        }
        static void Main(string[] args)
        {

            Operation<double> addOperation = Add<double>;
            Operation<double> subtractOperation = Subtract<double>;
            Operation<double> multiplyOperation = Multiply<double>;
            Operation<double> divideOperation = Divide<double>;

            Console.WriteLine("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 for Addition \nPress 2 for Subtraction\nPress 3 for Division\nPress 4 for Multiplication\n");


            double exp = double.Parse(Console.ReadLine());
            switch (exp)
            {

                case 1:
                    Console.WriteLine($" Result of Addition: {addOperation(num1, num2)}");
                    break;
                case 2:

                    Console.WriteLine($" Result of Subtraction: {subtractOperation(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($" Result of  Division: {divideOperation(num1, num2)}");
                    break;


                case 4:
                    Console.WriteLine($"Result of  Multiplication: {multiplyOperation(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("incorrect key\t Try again");
                    break;


            }


        }








    }
}
