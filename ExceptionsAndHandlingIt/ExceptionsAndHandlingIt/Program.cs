using System;

namespace ExceptionsAndHandlingIt
{
    class Program
    {
        static int div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            
          //  ask:
          
            try
            {
               // int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(div(1, 0));
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            //    goto ask;
            }
            finally
            {
                Console.WriteLine("Finally Statement");
            }
          
            Student std = null; // We want to throw an exception that won't allow this to be null
            try
            {
                Student.printInfo(std); // static so you have to use class name then '.'
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
    public class Student
    {
        public static void printInfo(Student st)
        {
            if (st == null)
            
                throw new NullReferenceException("Student can't be null");
            
            Console.WriteLine("Student");

        }
    }
}
