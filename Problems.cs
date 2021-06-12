using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice
{
    public class Problems
    {
        public Problems()
        {

        }

        public void isValid(string s)
        {
            char[] charArr = s.ToCharArray();
            int[] freq = new int[s.Length];
            int i, j;

            for(i = 0; i < s.Length; i++)
            {
                freq[i] = 1;
                for(j = i + 1; j < s.Length; j++)
                {
                    if(charArr[i] == charArr[j])
                    {
                        freq[i]++;
                        charArr[j] = '0';
                    }
                }
            }

            Console.WriteLine("Print out frequencies");

            for(i = 0; i < freq.Length; i++)
            {
                if(charArr[i] != ' ' && charArr[i] != '0')
                {
                    Console.WriteLine(charArr[i] + ":" + freq[i]);
                }
            }
        }
    }
}
