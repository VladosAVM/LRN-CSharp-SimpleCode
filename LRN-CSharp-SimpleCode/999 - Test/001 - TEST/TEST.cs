using System;
using System.Runtime.InteropServices;

namespace _001___TEST
{
    internal class Program
    {
        static int RomanToInt(string s)
        {
            bool isValidString = false;

            // String validate
            for (int i = 0; i < s.Length; i++) 
            {
                if ((s[i] == 'I' || s[i] == 'V' || s[i] == 'X' || s[i] == 'L' || s[i] == 'C' || s[i] == 'D' || s[i] == 'M') && (s.Length >= 1 && s.Length <= 15))
                    isValidString = true;
                else
                    break;
            }

            // Cpnvert roman to integer
            if (isValidString)
            {
                string compositeNumber;
                int result = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i + 1 < s.Length) // IOOR evade
                    {
                        compositeNumber = char.ToString(s[i]) + char.ToString(s[i + 1]);
                        bool isFound = false;
                        switch (compositeNumber)
                        {
                            case "IV":
                                result += 4;
                                isFound = true;
                                i++;
                                break;
                            case "IX":
                                result += 9;
                                isFound = true;
                                i++;
                                break;
                            case "XL":
                                result += 40;
                                isFound = true;
                                i++;
                                break;
                            case "XC":
                                result += 90;
                                isFound = true;
                                i++;
                                break;
                            case "CD":
                                result += 400;
                                isFound = true;
                                i++;
                                break;
                            case "CM":
                                result += 900;
                                isFound = true;
                                i++;
                                break;
                        }
                        if (!isFound)
                        {
                            switch (s[i])
                            {
                                case 'I':
                                    result += 1;
                                    break;
                                case 'V':
                                    result += 5;
                                    break;
                                case 'X':
                                    result += 10;
                                    break;
                                case 'L':
                                    result += 50;
                                    break;
                                case 'C':
                                    result += 100;
                                    break;
                                case 'D':
                                    result += 500;
                                    break;
                                case 'M':
                                    result += 1000;
                                    break;
                                default:
                                    result += 0;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        switch (s[i])
                        {
                            case 'I':
                                result += 1;
                                break;
                            case 'V':
                                result += 5;
                                break;
                            case 'X':
                                result += 10;
                                break;
                            case 'L':
                                result += 50;
                                break;
                            case 'C':
                                result += 100;
                                break;
                            case 'D':
                                result += 500;
                                break;
                            case 'M':
                                result += 1000;
                                break;
                            default:
                                result += 0;
                                break;
                        }
                    }
                }
                if (result >= 1 && result <= 3999)
                    return result;
                else
                    return 0;
            }
            else
                return 0;
        }

        static void Main()
        {

            string s = "MMMCMXCX";
            Console.WriteLine(RomanToInt(s));

        }

    }
}
