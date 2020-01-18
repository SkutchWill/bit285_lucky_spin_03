using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class TextTransformService
    {
        public string numberToText(int num)
        {
            string numChar;
            switch (num)
            {            
                case 1:
                    numChar = "One";
                    break;
                case 2:
                    numChar = "Two";
                    break;
                case 3:
                    numChar = "Three";
                    break;
                case 4:
                    numChar = "Four";
                    break;
                case 5:
                    numChar = "Five";
                    break;
                case 6:
                    numChar = "Six";
                    break;
                case 7:
                    numChar = "Seven";
                    break;
                case 8:
                    numChar = "Eight";
                    break;
                case 9:
                    numChar = "Nine";
                    break;
                default:
                    numChar = "Numbers";
                    break;

            }
            return numChar;
        }
    }
}
