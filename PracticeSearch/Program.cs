using System;

namespace PracticeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // initianilizing array a
            int[] a = { 4, 2, 1, 7, 3, 9, 5 };
            // the integer to be searched in the array
            int s = 6;

            // calling the linearSearch method by passing the array and the search element to the called funcion
            linearSearch(a , s);

            // Display exit message
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        } // end of main

        // method that performs linear search taking array and search element as arguements
        public static void linearSearch(int[] a, int s)
        {
            // setting flag to 0
            int flag = 0;

            // for loop for matching the search element to each element of the array. If it matches, set flag to 1 and break the loop
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                {
                    flag = 1;
                    break;
                } //end of if
            } // end of for loop i

            // Displaying whether the element is present in the array based on the value in flag variable
            if (flag == 1)
            {
                Console.WriteLine(s + " is present in array ");
            } // end of if(flag == 1)
            else
            {
                Console.WriteLine(s + " is not present in array ");
            } // end of else
        } // end of linearSearch()

    } // end of class
} // end of namespace
