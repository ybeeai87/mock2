using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment2mock
{
    class Program
    {
        static void Main(string[] args)
        {

            //how to reupload:

            // go to starting folder to upload, lookfor folder that has:
            // .github, assessment2a, asessment2a.pdf
            //go to mockassessment2 folder, git bash
            //on git bash: already cloned, so no need to git init
            // git add ., git status to confirm
            // git commit -m "Finished"
            //git push
            //check the repo for the commit

            //1
            string[] values = AddValues("Yousif", "Apple", "Chronic");
            //need to add foreach to test
            foreach (string x in values)
            {
                Console.WriteLine(x);
            }

            //2
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(SumArray(numbers));

            //3
            //create list with values that can be used and new list that will use the method
            // using the first list to use list and variables.
            //list needs to use foreach to check
            List<int> Lnumbers = new List<int> { 1, 2, 3, 4, 5 };
            //create new list to hold results
            List<int> results = RemoveNum(Lnumbers, 3);//choose string and int to remove
            //create foreach to test
            foreach (int x in results)
            {
                Console.WriteLine(x);
            }

            //4
            List<string> fruit = AddToList("cherries");
            foreach (string x in fruit)
            {
                Console.WriteLine(x);
            }

            //5
            //to test method with correct work
            Console.WriteLine(TryMe(10,5));
            // to test of arthimatic exception (divide by 0)
            Console.WriteLine(TryMe(10,0));
        }
        //returns a string array
        static string[] AddValues(string a, string b, string c)
        {
            string[] result = { a, b, c };
            return result;
        }
        static int SumArray(int[] a)
        {
            //using linq
            //  return a.Sum();

            int result = 0;
            foreach (int num in a)
            {
                result += num;
            }
            return result;
        }
        //return List and int
        static List<int> RemoveNum(List<int> a, int b)
        {
            //using List method Remove
            a.Remove(b); //returns back a bool
            return a;
            //store removed numbers
            //int index = -1; //so it can run use -1 not 0
            //for (int i = 0; i < a.Count; i++)
            //{
            //    if(a[i] == b)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //if (index != -1)
            //{
            //    a.RemoveAt(index);//use RemoveAt list method
            // return a;
        }
    
    //return back list of string
    static List<string> AddToList(string x)
    {
        //make sure to create a new list
        List<string> result = new List<string>
            { "grapes",
              "oranges",
              x };

        return result;
    }
    static int TryMe (int num1, int num2)
    {
        int result = 9;
            try
            {
                result = num1 / num2;
            }
            catch (ArithmeticException e)
            {
                return 9;
                //result = 9;
            }
            return result;

    }
}
}

