using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            string one = "cat125";
            string two = "cat124";



            if (stringSort(one, two))
            {
                Console.WriteLine(one + " comes first");
            }
            else
            {
                Console.WriteLine(two + " comes first");
            }

            Console.Read();
        }

        //public static string sort(string one, string two)
        //{
        //    int length = one.Length <= two.Length ? one.Length : two.Length;
        //    bool same = true;

        //    for (int i = 0; i < length; i++)
        //    {
        //        if ((int)one.ToLower()[i] > (int)two.ToLower()[i])
        //        {
        //            same = false;
        //            return two;    
        //        }
        //    }
        //    if (same && one.Length > two.Length)
        //    {
        //        return two;
        //    }
        //    return one;
        //}

        public static bool stringSort(string one, string two)
        {
            int length = one.Length <= two.Length ? one.Length : two.Length;
            bool same = true;

            for (int i = 0; i < length; i++)
            {
                if ((int)one.ToLower()[i] > (int)two.ToLower()[i])
                {
                    same = false;
                    return false;
                }
                else if ((int)one.ToLower()[i] < (int)two.ToLower()[i])
                {
                    same = false;
                    return true;
                }
            }
            if (same && one.Length > two.Length)
            {
                return false;
            }
            return true;
        }

    }
}
