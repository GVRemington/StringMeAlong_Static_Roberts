using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMeAlong_Static_Roberts
{
    static class StringManager
    {

        public static string _getData(string manipulateThis)
        { return manipulateThis; }

        public static string goBackwards(string toReverse)
        {
            string reverse = string.Empty;
            Char[] array = toReverse.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse = reverse + array[i];
            }
            return "\n\t The reverse of Sunbeam Tiger is:  " + reverse;
        }

        public static bool symetrical(string A)
        {
            bool _symetrical = false;
            string B = string.Empty;
            char[] array = A.ToCharArray();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                B = B + array[i];
            }
            foreach (char c in A)
            {
                foreach (char c2 in B)
                {
                    if (c == c2)
                    { _symetrical = true; }
                    else
                    { _symetrical = false; }
                }
            }
            return _symetrical;

        }
        public static bool Equals(object Bob, object Fred)
        {
            string A = _getData((string)Bob);
            string B = _getData((string)Fred);
            return A.Equals(B);
        }

        public static string ToString(string toString)
        {
            double value = 0;
            byte[] array = Encoding.ASCII.GetBytes(toString);
            string num = string.Empty;


            foreach (byte b in array)
            {
                value = value + b;

            }

            string valueS = value.ToString();

            foreach (char c in valueS) // lots of copy and paste here
            {

                if (c == '0')
                {
                    num = num + "zero ";
                }
                if (c == '1')
                {
                    num = num + "one ";
                }
                if (c == '2')
                {
                    num = num + "two ";
                }
                if (c == '3')
                {
                    num = num + "three ";
                }
                if (c == '4')
                {
                    num = num + "four ";
                }
                if (c == '5')
                {
                    num = num + "five ";
                }
                if (c == '6')
                {
                    num = num + "six ";
                }
                if (c == '7')
                {
                    num = num + "seven";
                }
                if (c == '8')
                {
                    num = num + "eight ";
                }
                if (c == '9')
                {
                    num = num + "nine ";
                }
            }
            return "\n\tThe values of Sunbeam Tiger are: " + value + " and: " + num;
        }

        //public string casePreservation(string preserveCapitals)//not working
        //{
        //    char[] array = preserveCapitals.ToCharArray();
        //    bool upper = true;
        //    string reverse = string.Empty;
        //    char[] array2 = reverse.ToCharArray();
        //    string finalReverse = string.Empty;

        //    foreach (char c in array)
        //    {
        //        for (int i = array.Length - 1; i >= 0; i--)
        //        {
        //            if (char.IsUpper(c))
        //            {
        //                reverse = reverse + char.ToUpper(c);
        //            }
        //            else
        //            {
        //                reverse = reverse + char.ToLower(c);
        //            }

        //        }
        //        //Console.WriteLine(c);
        //    }

        //    return reverse;



    }
}
