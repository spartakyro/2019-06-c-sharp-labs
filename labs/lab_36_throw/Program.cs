using System;

namespace lab_36_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                throw new Exception("something terrible has happened");

            }

            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            

            try
            {
                //main code for whole company
                try
                {
                    //code for your department
                    
                    try
                    {
                        //my code : exception HERE *************
                        
                        throw new ArithmeticException("hey your arithmatic is lousy");
                    }
                    catch
                    {
                        //dont handle yere
                        throw;

                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    throw;
                }
            }

            catch(Exception e)
            {
                //yes handle here
                Console.WriteLine(e.Message);
            }
        }
    }
}
