internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");






        {

            //Console.WriteLine("Hello World!");

            //Arrays are used to store multiple values in 

            //a single variable, instead of declaring separate 

            //variables for each value.             //To declare an array, define the variable type with

            //square brackets:            

            //            string[] BackendCourse = { "Dotnet", "java", "python", "Php","abc" };

            //            Array.Sort(BackendCourse);   //Sorting of Array 

            //            Console.WriteLine(BackendCourse[3]);

            //            Console.WriteLine(BackendCourse[2]); Console.WriteLine(BackendCourse[0] + BackendCourse[1]); BackendCourse[3] = "Services";//Changing the array index 

            //            Console.WriteLine(BackendCourse[3]);

            //            Console.WriteLine(BackendCourse.Length - 1); 

            //            foreach (var item in BackendCourse)  //Getting all the courses 

            //            {

            //                Console.WriteLine(item.ToString());

            //            }

            //            for (int i = 0; i < BackendCourse.Length; i++)

            //            {

            //                Console.WriteLine(BackendCourse[i]);

            //            }
            //        }

            //    }

            //}

            int[] Numbers = { 1, 2, 3, 4, 5 };

            Array.Sort(Numbers);

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }


            foreach (var item in Numbers)  //Getting all the courses 

                    {

                              Console.WriteLine(item.ToString());

                    }
        }
    }
}
