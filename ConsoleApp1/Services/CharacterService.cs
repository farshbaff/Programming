using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class CharacterService
    {
        /// <summary>
        /// The function gets an integer number and converts it to character.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static char ConvertIntToChar(int num) => Convert.ToChar(num);
        //public static char ConvertIntToChar(int num) => (char)num;
        public static int ConvertCharToInt(char ch) => Convert.ToInt32(ch);
    }
}
