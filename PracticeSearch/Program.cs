using System;

namespace PracticeSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            // initianilizing array a
            //int[] a = { 4, 2, 1, 7, 3, 9, 5};

            // the integer to be searched in the array
            //int s = 6;

            // calling the linearSearch(a, s) method to search an element by passing the array and the search element to the called funcion
            //linearSearch(a , s);

            // calling selectionSort(a) method to sort the array by passing the array to the called function
            //int[] sortedarray = selectionSort(a);
            //printArray(sortedarray);

            // calling bubbleSort(a) method to sort the array by passing the array to the called function
            //bubbleSort(a);

            // --------------------- Question 1 --------------------
            // calling rotLeft method d number of times by passing the array and times of rotation (d) to the called function
            //int d = 2;
            //int[] a = { 1, 2, 3, 4, 5, 6, 7};
            //int[] r = rotLeft(a, d);
            //printArray(r); // printing the resultant array

            // --------------------- Question 2 --------------------

            // method to find maximum number of toys that can be bought within a budget of k amount
            //Console.WriteLine("\n\nMaximum toys that can be bought are: ");
            //int k = 50; // k is the total amount 
            //int[] prices = { 1, 12, 5, 111, 200, 1000, 10 }; // array of the prices of the toys
            //int[] prices = { 1, 2, 3, 4 };
            //Console.WriteLine(maximumToys(prices, k));

            // --------------------- Question 4 --------------------
            // method missingNumbers to find missing numbers in an array
            Console.WriteLine("\n\nMissing numbers: ");
            //int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            //int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] arr1 = {1, 2, 3,};
            int[] brr = { 1, 2, 3, 4, 4, 5 };
            int[] r2 = missingNumbers(arr1, brr);

            // calling the newSort(a) method by passing the array to the called function
            //newSort(a);

            // Display exit message
            Console.WriteLine("\nPress any key to exit");
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

        // method to perform selection sort ascending order
        public static int[] selectionSort(int[] a)
        {
            // selection is taking each element of the array, comparing it to all other element to find the lowest and swaping the lowest value to the first position of unsorted array
            for(int i = 0; i < a.Length; i++)
            {
                int min = a[i]; // assigning the first element to be the minimum in the begining of sort
                int minindex = i; // keeping track of the position of the minimum element
                // Comparing an element with all other array elements through this array
                for(int j = i+1; j < a.Length; j++)
                {
                    // If the element is lower then the assigned minimum, swaping, otherwise no swaping 
                    if(a[j] < min)
                    {
                        min = a[j];
                        minindex = j;

                    } // end of if

                } // end of for loop j

                a[minindex] = a[i];
                a[i] = min;

            } // end of for loop i

            // displaying the sorted array            
            return (a);

        } // end of selectionSort(int[] a)

        // method to perform bubble sort ascending order
        public static void bubbleSort(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    } // end of if  

                } // end of for loop i
              
            } // end of for loop i

            printArray(a);
        } // end of bubbleSort(int[] a)

        // method to perform bubble sort ascending order
        public static void newSort(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;                      
                    } // end of if                    

                } // end of for loop j

            } // end of for loop i

            // Displaying the sorted array
            printArray(a);

        } // end of bubbleSort(int[] a)

        // method to print an array
        public static void printArray(int[] a)
        {
            Console.WriteLine("The array is: ");

            // for loop to print each element to the array with some space between them
            for( int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");

            } // end of for loop i

        } // end of printArray(int[] a)

        // rotLeft method that returns an array rotated a specified  number of times
        static int[] rotLeft(int[] a, int d)
        {
            // running for loop d number of times for rotating left
            for(int i = 0; i < d; i++)
            {
                int temp = a[0]; // holding the first array element in temp so that its position can be emptied to move the second element to its place
                // using for loop to shift all array element one position to the left
                for (int j = 0; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                } // end of for loop j 
                a[a.Length - 1] = temp; // assigning the temp value to the last of array hence completing one left rotation
            } // end of for loop i
            return a;
        } // end of rotLeft method

        // method to find the sum of elements of an array
        static int arraySum(int [] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length-1; i++)
            {
                // calculating the sum and storing the value in variable sum
                sum = sum + a[i];
            } // end of for loop i

            // returns the sum of the array elements to the calling function
            return (sum);

        } // end of method arraySum(int[] a)

        // method to find the maximum number of toys that can be bought in a given budget of k dollars
        static int maximumToys(int[] prices, int k)
        {
            // sorting the price array
            int[] sortedprices = selectionSort(prices);
            // if the sum of all prices in the array is less than k amount return all toys
            int sumPrices = arraySum(sortedprices);
            if (sumPrices < k)
            {
                return (sortedprices.Length);
            } //end of if

            else
            {
                int sum = 0; // variable sum holds the addition of prices till it is less than or equal to k amount
                int i = 0; // i is the number of toys
                // Perform while loop till the addition of prices is less than or equal to k amount
                while (sum <= k)
                {
                    sum = sum + sortedprices[i];
                    i++;
                } // end of while loop

                return (i - 1);
            }
        } // end of maximumToys method

        // missing number method
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            // for loop for each array element
            for(int i = 0; i < brr.Length; i++)
            {
                // calculating the frequeny of that array element in array brr
                int freq1 = 0;
                for(int j = 0; j < brr.Length; j++)
                {
                    if(brr[i] == brr[j])
                    {
                        freq1++;
                    } // end of if

                } // end of for loop j

                // calculating the frequeny of that array element in array arr
                int freq2 = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (brr[i] == arr[k])
                    {
                         freq2++;
                    } // end of if

                } // end of for loop k 

                // if the frequency of that number in array brr is not equal to its frequency in arr, print it, meaning its missing
                if(freq1 != freq2 || freq1 > freq2)
                {
                    Console.WriteLine(brr[i]);
                }


            } // end of for loop i
            return null;
        } // end of missingNumbers method


    } // end of class
} // end of namespace
