using Exceptions.Auth;
using Exceptions.Exceptionss;
using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exHomework,Practice
            //try
            //{
            //    int a = 5;
            //    int b = 0;
            //    var result = a / b;
            //    Console.WriteLine(result);

            //    //int[] arr = new int[3];
            //    //arr[7] = 8;

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Bize muraciet etdiyiniz ucun teshekkur edirik");
            //}

            //Divide(18, 2);

            //List<string> names = new List<string>() { "Orxan", "Emil", "Asif", "Nermin", "Sadiq" };

            //string search = "Asif";
            //NameException(names, search);
            #endregion

            #region Login Exception
            string email = "Orxan@gmail.com";
            int password = 12345;

            LoginException(email, password);
            #endregion


        }

        public static void Divide(int num1, int num2)
        {
            try
            {
                if (num2 == 2)
                {
                    throw new DivideException("num2 cant equal 2");
                }
                Console.WriteLine(num1/num2);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            
        }
        public static void NameException(List<string> names,string name)
        {
            try
            {
                //if (!names.Contains(name))
                //{
                //    throw new FindNameException("Not found name");
                //}

                var data = names.Find(m => m == name);
                if(data is null) throw new FindNameException("Not found name");
                Console.WriteLine("Tapildi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void LoginException(string email, int password)
        {
            try
            {
                if (password != 12345)
                {
                    throw new AccountException("Password wrong");
                }
                else
                {
                    Console.WriteLine("Girish olundu");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bize muraciet etdiyiniz ucun teshekkur edirik");
            }
        }
    }
}
