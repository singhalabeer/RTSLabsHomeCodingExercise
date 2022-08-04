using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RTSLabsHomeCodingExercise
{
    class HelperMethods
    {

        /// <summary>
        /// This method accepts two arguments
        /// 1. An unsorted collection of integers(the list) 
        /// 2. an integer(the comparison value)
        /// it  returns a hash/object/map/etc.with the keys "above" and "below" with the corresponding count of integers 
        /// from the list that are above or below the comparison value
        ///  Example usage:
        ///  input: [1, 5, 2, 1, 10], 6
        ///  output: { "above": 1, "below": 4 }
        /// </summary>
        /// <param name="unsortedList"></param>
        /// <param name="compareValue"></param>
        public static Hashtable aboveBelow(List<int> unsortedList, int compareValue)
        {
            int above_count = 0;
            int below_count = 0;

            //loop through the elements in the unsorted list of ints
            foreach (int element in unsortedList)
            {
                //if element value is below compare-value then increment below-count
                if (element < compareValue)
                {
                    below_count++;
                }
                //if element value is above the compare-value then increment above-count
                if (element > compareValue)
                {
                    above_count++;
                }
                //Note: we are not doing anything if the element is "equal" to compare-value as it is not specified in the requirements.
            }

            //instantiate the hashtable object to store the values
            Hashtable hashTable = new Hashtable();
            hashTable.Add("above", above_count);
            hashTable.Add("below", below_count);

            return hashTable;
        }

        /// <summary>
        /// This method accepts two arguments
        /// 1. a string (the original string)
        /// 2. a positive integer(the rotation amount)
        /// it returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning
        /// Example usage:
        /// input: "MyString", 2
        /// output: "ngMyStri"
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="rotationAmount"></param>
        public static string stringRotation(string inputString, int rotationAmount)
        {
            string returnString = string.Empty;
            //We are going to use queues for this method.
            //queue is FIFO, which means first-one in is first-one out
            //when we queue at a counter we join the queue at the end and we are the first one in the queue to exit
            //this works nicely for the rotation problem but we will need to reverse the string as a character array.


            //transfer the string to a character array and reverse it as the string so we the last element is the first in the queue.
            //this is done as the method is to rotate from the right-end of the input string
            char[] reverseArray = inputString.ToCharArray();
            Array.Reverse(reverseArray);

            //instantiate a queue object
            Queue<char> strqueue = new Queue<char>();
            //fill the queue object with the reverse character array we reversed.
            foreach (char charelement in reverseArray)
            { strqueue.Enqueue(charelement); }

            //now we perform the rotation from by using the queue FIFO principle.
            //since we reversed the last character in the string is the first in the queue so if it leaves or dequeues it will be first to comeout.
            //and then we will place it back in the queue which will place it at the end of the queue in principle causing the rotation effect in the input string
            char tempChar;
            for (int i = 1; i <= rotationAmount; i++)
            {
                tempChar = strqueue.Dequeue();//out from the front
                strqueue.Enqueue(tempChar);//in at the end
            }

            //We need to now transfer the queue to a character array and then rotation it to get string in its original format.
            char[] rotatedArray = strqueue.ToArray();
            Array.Reverse(rotatedArray);
            returnString = new string(rotatedArray);

            return (returnString);

        }

    }
}
