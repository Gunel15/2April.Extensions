using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AprilHomeTaskExtensions
{
   public static class Helper
    {


        public static bool IsOdd(int Number)
        {
            bool check = false;
            if (Number % 2 == 1)
            check = true;
            return check;
        }
        

        public static bool IsEven(int Number)
        {
            bool check = false;
            if (Number % 2 == 0) 
            check = true;
            return check;
        }

        public static bool HasDigit(string value)
        {
            bool check = false;
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                    check = true;
            }
            return check;
        }

        public static bool CheckPassword(string value)
        {
            if (value.Length > 8 )
            {
                bool hasdigit = false;
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        hasdigit = true;
                        break;
                    }

                }
                return hasdigit;
                bool hasupper = false;
                foreach (char c in value)
                {
                    if (char.IsUpper(c))
                    {
                        hasupper = true;
                        break;
                    }

                }
                return hasupper;
                bool haslower = false;
                foreach (char c in value)
                {
                    if (char.IsLower(c))
                    {
                        haslower = true;
                        break;
                    }

                }
                return haslower;
                
                    
                

            }
            
        }
    }
}
