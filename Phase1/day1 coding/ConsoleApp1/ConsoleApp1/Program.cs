using System;
class Program

{

     static void Main(string[] args)

     {
        int i = 1, j = 16;

   while (++i <= j--)

   {

      j++;

   }

   Console.WriteLine(i + "  " + j);
        //  Program ctrl = new Program();

        //  ctrl.FindOutput();       

     }

 

     void FindOutput ()

     {

         int num;

         for (num = 10; num <= 15; num++)

         {

             while (Convert.ToBoolean(num))

             {

                 do

                 {

                     Console.WriteLine(1);

                     if (!Convert.ToBoolean(num >> 1))

                         break;

                 } while (Convert.ToBoolean(1));

                 break;

             }

         }

     }

}