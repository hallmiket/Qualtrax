using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MinStack
    {
        string[] stackCalls = new string[] { "MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin" };

        List<double> values;

        public MinStack()
        {
            values = new List<double>();
            return;
        }

        public void push(double valueToPush)
        {
            if (valueToPush >= Math.Pow(-2, 31) && valueToPush <= (Math.Pow(2, 31) - 1))
            {
                values.Add(valueToPush);
            }
            return;
        }

        public void pop()
        {
            values.RemoveAt(values.Count() - 1);
            return;
        }

        public double top()
        {
            return values.FirstOrDefault();
        }

        public double getMin()
        {
            return values.Min();
        }

       
    }

    public class parseBracketString
    {
        public bool parseTheString(string s)
        {
            string sOpen1 = "(";
            string sClose1 = ")";
            string sOpen2 = "{";
            string sClose2 = "}";
            string sOpen3 = "[";
            string sClose3 = "]";
            bool returnThis1 = true;
            bool returnThis2 = true;
            bool returnThis3 = true;

            if (s == null)
            {
                return false;
            }
            if (s.Length > Math.Pow(10, 4) || s.Length < 2)
            {
                return false;
            }

            //if the length of the string is odd, then it cannot be correct
            if (s.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                //check if brackets match: Handles Examples 1, 2, 3 & 4 in the Question doc
                for (int i = 0; i <= s.Length - 2; i++)
                {
                    if (s[i].ToString() == sOpen1)
                    {
                        if (s[i + 1].ToString() != sClose1 && s[(s.Length - 1) - i].ToString() != sClose1)
                        {
                            returnThis1 = false;
                        }
                    }
                    else if (s[i].ToString() == sOpen2 && s[i + 1].ToString() != sClose2)
                    {
                        if (s[i + 1].ToString() != sClose2 && s[(s.Length - 1) - i].ToString() != sClose2)
                        {
                            returnThis2 = false;
                        }
                    }
                    else if (s[i].ToString() == sOpen3)
                    {
                        if (s[i + 1].ToString() != sClose3 && s[(s.Length - 1) - i].ToString() != sClose3)
                        {
                            returnThis3 = false;
                        }
                    }
                }
            }

            return returnThis1 && returnThis2 && returnThis3;
        }
    }
}
