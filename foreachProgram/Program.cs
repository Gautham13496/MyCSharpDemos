internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        int[] Numbers = { 1, 2, 3, 4, 5, 6 };

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }




        {



            int i = 0;

            int j = 0;

            #region while and Do while loop

            while (i < 5)

            {

                Console.WriteLine(i);

                i++;

            }             //#region for do while 

            do

            {

                Console.WriteLine(i);

                i++;

            }

            while (i < 5);

            //#endregion

            #endregion

            #region check for continue and break

            while (i < 2)

            {

                if (i % 2 == 0)

                {

                    Console.WriteLine(i); Console.WriteLine("Iam Sameer");

                    i++;

                    //break;

                    continue;

                }
                Console.WriteLine(i);

                i++;

                Console.WriteLine("Iam Lilu");

            }



            #region for various for and for each loop 

            //#region for loop

            for (i = 0; i < 5; i++)

            {

                Console.WriteLine(i);

            }

            for (j = 10; j > 0; j--)

            {

                Console.WriteLine(j);

            }

            //#endregion

            //#region for each loop

            int k = 0;

            ////Diffrence in for and for loop is (For--> exec blck code unless

            ////expression rtn flse)-->Foreachobjectcollection(ObjectCollection) 

            //string[] Names = { "Sam", "Jinu", "Lilu", "Samb", "Samya" };

            //foreach (string k in Names)

            //{

            //    Console.WriteLine(k);

            //}

            //#endregion             #endregion        
            //}



        }
    }
    
}


