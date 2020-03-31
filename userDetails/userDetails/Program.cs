using System;
using System.Collections.Generic;

namespace userDetails
{
    public class Program
    {
        public static List<Object> list = new List<Object>();
        static void Main(string[] args)
        {
            int a;
            bool b;
            string t;
            string ans;
            try
            {
                void UserFunc()
                {
                    Console.WriteLine("Enter your input");
                    string input = Console.ReadLine();
                    if (Int32.TryParse(input, out a))
                    {
                        t = "integer";
                    }
                    else
                    if (Boolean.TryParse(input, out b))
                    {
                        t = "Boolean";
                    }
                    else
                        t = "string";
                    switch (t)
                    {
                        case "integer":
                            Input<int> intGenericClass = new Input<int>();
                            intGenericClass.store(int.Parse(input));
                            Console.WriteLine("your input type was integer");
                            break;
                        case "string":
                            Input<string> intGenericClass1 = new Input<string>();
                            intGenericClass1.store(input);
                            Console.WriteLine("your input type was string");
                            break;
                        case "Boolean":
                            Input<bool> intGenericClass2 = new Input<bool>();
                            intGenericClass2.store(bool.Parse(input));
                            Console.WriteLine("your input type was Boolean");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to continue? (y/n)");
                    ans = Console.ReadLine();


                }
                do
                { UserFunc(); }
                while (ans == "y");
                if(ans!="n" && ans!="y")
                {
                    Console.WriteLine("Wrong choice");
                }
                userDetails.Input<Object>.retreive();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }


    }


}

