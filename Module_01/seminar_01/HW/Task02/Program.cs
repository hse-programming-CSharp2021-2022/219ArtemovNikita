using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] surname = new string[5];
            surname[0] = "       //////  ////////  ////////  |||||||  ||/       //|     //////   //     //";
            surname[1] = "      //   ||  ||    //     ||     ||       ||//     //||   //     //  //    //";
            surname[2] = "     //////||  ||/////      ||     ||||||   || //   // ||  //     //   //   //";
            surname[3] = "    //     ||  ||    //     ||     ||       ||  // //  ||  //    //    // //";
            surname[4] = "   //      ||  ||     //    ||     |||||||  ||   //    ||  //////      ///";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(surname[i]);
            }

            Console.ReadLine();
        }
    }
}

