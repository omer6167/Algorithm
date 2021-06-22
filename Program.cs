using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Primitives;

namespace Algorithm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           

            Console.ReadLine();
        }



        #region DayChallenges




        /// <summary>
        /// Problem Day-16 Exceptions - String to Integer
        /// </summary>
        /// <param name="str"></param>
        public static string StringToInteger(string str)
        {
            return int.TryParse(str, out int num) ? $"{num}" : $"Bad String";
        }

        /// <summary>
        /// Problem Day-28 from Hackerrank
        /// </summary>
        public static void Regex()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            List<string> namesList = new List<string>();
            String emailRegEx = "[a-z]+@gmail\\.com$";
            Regex rgx = new Regex(emailRegEx);

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                if (rgx.IsMatch(emailID))
                {
                    namesList.Add(firstName);
                }
            }

            namesList.Sort();
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }


        /// <summary>
        /// Problem Day-11 Arrays2Dim From Hackerrank
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int ArraysTwoDim(int[][] arr)
        {

            int temp = 0, max = Int32.MinValue;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];


                    if (i == 0 && j == 0)
                        max = temp;

                    if (temp > max)
                        max = temp;
                }
            return max;
        }

        /// <summary>
        /// Problem Day-10 Binary Numbers
        /// </summary>
        public static int BinaryNumbers(int N)
        {
            string binary = string.Empty;
            string chRemain = string.Empty;
            int consecutive = 0;
            int sum = 0;
            List<int> consecutivesList = new List<int>();

            do
            {
                N = Math.DivRem(N, 2, out int remain);
                chRemain += remain.ToString();
            } while (N != 0);

            for (int i = chRemain.Length - 1; i >= 0; i--)
            {
                binary += chRemain[i];
            }

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {

                    consecutive += 1;
                }
                if (binary[i] == '0' || i + 1 == binary.Length)
                {

                    consecutivesList.Add(consecutive);
                    consecutive = 0;
                }
            }

            return consecutivesList.Max();
        }

        /// <summary>
        /// Problem Day-9 DictionarieAndMaps From HackerRank
        /// </summary>
        public static void DictionarieAndMaps()
        {
            try
            {
                Dictionary<string, string> myDictionary = new Dictionary<string, string>();

                int.TryParse(Console.ReadLine(), out int N);

                for (int i = 0; i < N; i++)
                {
                    string s = Console.ReadLine();
                    string[] words = s.Split(' ');

                    myDictionary.Add(words[0], words[1]);
                }

                string[] keyComparers = new string[myDictionary.Count];


                for (int i = 0; i < myDictionary.Count; i++)
                {
                    keyComparers[i] = Console.ReadLine();

                }

                for (int i = 0; i < myDictionary.Count; i++)
                {
                    if (myDictionary.ContainsKey(keyComparers[i]))
                    {
                        myDictionary.TryGetValue(keyComparers[i], out string value);

                        Console.WriteLine($"{keyComparers[i]}={value}");
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }


            //foreach (var kvp in myDictionary)
            //{
            //    int i = 0;
            //    if (kvp.Key==keyComparers[i])
            //    {
            //        Console.WriteLine($"{kvp.Key}={kvp.Value}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }
            //}
        }

        /// <summary>
        ///  Problem Day-7 Arrays From HackerRank 
        /// </summary>
        /// <param name="N"></param>
        /// <param name="arr"></param>
        public static void Arrays(params int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Problem Day-6 Let's Review From Hackerrank
        /// </summary>
        public static void Review()
        {
            int a = int.Parse(Console.ReadLine());
            List<string> inputList = new List<string>();


            for (int i = 0; i < a; i++)
            {
                inputList.Add(Console.ReadLine());
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                string odd = string.Empty, even = string.Empty;
                for (int j = 0; j < inputList[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        odd += inputList[i][j];
                    }
                    else
                    {
                        even += inputList[i][j];
                    }


                }
                Console.WriteLine($"{odd} {even}");
            }

        }


        /// <summary>
        /// Problem Day-5 Loops From Hackerrank
        /// </summary>
        /// <param name="N"></param>
        public static IEnumerable<string> Loops(int N)
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return $"{N} x {i} = {N * i}";
            }

        }


        /// <summary>
        /// Problem Day-ConditionalStatements From Hackerrank
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string ConditionalStatements(int n)
        {
            if (n % 2 != 0 || 6 <= n && n <= 20)
            {
                return $"Weird";
            }

            return $"Not Weird";
        }


        /// <summary>
        /// Problem Day-2 Operator From Hackerrank
        /// </summary>
        /// <param name="meal_cost"></param>
        /// <param name="tip_percent"></param>
        /// <param name="tax_percent"></param>
        public static void Solve(double meal_cost = 12, int tip_percent = 20, int tax_percent = 8)
        {
            decimal tip = (decimal)(meal_cost * tip_percent) / 100;
            decimal tax = (decimal)(meal_cost * tax_percent) / 100;


            decimal total_cost = (decimal)meal_cost + tip + tax;

            int total = (int)Math.Round(total_cost);

            Console.WriteLine(total);
        }




        #endregion

        /// <summary>
        /// Print the minimum number of bribes necessary or Too chaotic if someone has bribed more than  people.
        /// </summary>
        /// <param name="q">the positions of the people after all bribes</param>
        public static void MinimumBribes(List<int> q)
        {
            int bribe = 0;
            int len = q.Count - 1;

            for (int i = 0; i < len; i++)
            {

                if (q[i] > i + 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = i+1; j < q.Count; j++)
                {
                    if (q[j]<q[i])
                        bribe++;
                }
            }


            Console.WriteLine(bribe);
            

            /* Time limit Exeeded */
            
            //int numbOfBribes = 0;
            //int len = q.Count - 1;
            //for (int i = 0; i < len; i++)
            //{
            //    if (q[i] > i + 3)
            //    {
            //        Console.WriteLine("Too chaotic");
            //        return;
            //    }
            //    for (int j = i + 1; j < q.Count; j++)
            //    {
            //        if (q[j] < q[i])
            //            numbOfBribes++;
            //    }
            //}
            //Console.WriteLine(numbOfBribes);
        }

        /// <summary>
        /// Find the maximum hourglass sum
        /// </summary>
        /// <param name="arr">an array of integers</param>
        /// <returns>the maximum hourglass sum</returns>
        public static int HourglassSum(List<List<int>> arr)
        {
            int max = int.MinValue; // Values can be negatif

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1]
                                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }

            return max;
        }



        /// <summary>
        /// Given two strings, if they share a common substring return "YES", else "NO"
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static string TwoStrings(string s1, string s2)
        {
            // Easiest way
            //return s1.Distinct().Intersect(s2.Distinct()).Any() ? "YES" : "NO"; 

            var isS1Dist = false;
            var isS2Dist = false;

            var s1Dist = string.Empty;
            var s2Dist = string.Empty;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1Dist.Length; j++)
                {

                    if (s1[i] == s1[j])
                    {
                        isS1Dist = true;
                        break;
                    }
                }
                if (isS1Dist == false)
                {
                    s1Dist += s1[i];
                }

                isS1Dist = false;
            }


            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = 0; j < s2Dist.Length; j++)
                {

                    if (s2[i] == s2[j])
                    {
                        isS2Dist = true;
                        break;
                    }
                }
                if (isS2Dist == false)
                {
                    s2Dist += s2[i];
                }

                isS2Dist = false;
            }

            for (int i = 0; i < s1Dist.Length; i++)
            {
                for (int j = 0; j < s2Dist.Length; j++)
                {
                    if (s1Dist[i] == s2Dist[j])
                    {
                        return "YES";
                    }
                }
            }

            return "NO";

        }

        /// <summary>
        /// Given a list of toy prices and an amount to spend, determine the maximum number of gifts he can buy.
        /// Each toy can be purchased only once
        /// </summary>
        /// <param name="prices">The Toy prices</param>
        /// <param name="k">Marks budget</param>
        /// <returns></returns>
        public static int MaximumToys(List<int> prices, int k)
        {
            int maxNum = 0;
            int sum = 0;
            prices.Sort();

            for (int i = 0; i < prices.Capacity; i++)
            {

                sum += prices[i];
                maxNum++;

                if (sum == k)
                    break;

                if (sum > k)
                {
                    maxNum--;
                    break;
                }
            }
            return maxNum;
        }

        /// <summary>
        /// Find the minimum number of swaps required to sort the array in ascending order.
        /// </summary>
        /// <param name="arr">an unordered array of integers</param>
        /// <returns>the minimum number of swaps to sort the array</returns>
        public static int MinimumSwaps(params int[] arr)
        {
            int i, minSwap = 0, n = arr.Length;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == i + 1)
                    continue;

                Swap(ref arr[i], ref arr[arr[i] - 1]);

                minSwap++;
                i--;

            }

            return minSwap;
        }

        /// <summary>
        /// Swap two value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }


        /// <summary>
        /// You must split it into two contiguous substrings,
        /// Then determine the minimum number of characters to change to make the two substrings into anagrams of one another.
        /// Two words are anagrams of one another if their letters can be rearranged to form the other word.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Anagram(string s)
        {
            if (s.Length % 2 != 0) return -1;

            string first = s.Substring(0, s.Length / 2);
            string second = s.Substring(s.Length / 2);

            //foreach (char ch in first)
            //{
            //    if (second.IndexOf(ch) == -1) continue;
            //    second = second.Remove(second.IndexOf(ch), 1);
            //}
            foreach (var ch in first.Where(ch => second.IndexOf(ch) != -1))
            {
                second = second.Remove(second.IndexOf(ch), 1);
            }

            return second.Length;
        }


        /// <summary>
        /// Return the index of a character that can be removed to make the string a palindrome
        /// İf it is not possible,or it is already palindrome return -1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int PalindromeIndex(string s)
        {
            //s = s.ToLower();

            for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
            {
                if (s[i] == s[j]) continue;

                StringSegment str = new StringSegment(s, i + 1, s.Length - i - i - 1); // need nuget
                for (int a = 0, b = str.Length - 1; a < str.Length; a++, b--)
                {
                    if (str[a] == str[b]) continue;

                    StringSegment str2 = new StringSegment(s, i, s.Length - j - j - 1);
                    for (int k = 0, l = str2.Length - 1; k < str2.Length; k++, l--)
                    {
                        if (str2[k] != str2[l]) continue;
                        return j;
                    }
                }
                return i;
            }
            return -1;

            //İt can be that way
            //for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
            //{
            //    if (s[i] == s[j]) continue;

            //    string str = s.Remove(i, 1);
            //    for (int a = i, b = j - 1; a < str.Length; a++, b--)
            //    {
            //        if (str[a] == str[b]) continue;

            //        string str2 = s.Remove(j, 1);
            //        for (int k = i, l = j - 1; k < str2.Length; k++, l--)
            //        {
            //            if (str2[k] != str2[l]) continue;
            //            return j;
            //        }
            //    }
            //    return i;
            //}
            //return -1;
        }

        /// <summary>
        /// How many numbers can be generated with input numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Calculate(params int[] numbers)
        {
            int max = numbers.Length;
            int result = 0;

            int multiplication = 1;
            for (int j = 1; j < max;)
            {
                var i = j;
                for (; i <= max;)
                {
                    multiplication *= i;
                    i++;
                }
                j++;
                result += multiplication;
                multiplication = 1;
            }
            result += max;

            return result;
        } //exam

        /// <summary>
        /// Sorting algorithm for small to big
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] OrderSmallToBig(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= array[i]) continue;
                    var temporary = array[i];

                    array[i] = array[j];

                    array[j] = temporary;
                }
            }
            return array;
        } //exam

        /// <summary>
        /// Input string will be valid if all characters of the string appear the same number of times
        /// Also if we can remove just one character
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string IsValid(string s)
        {
            string isValid = "NO";
            string deleted = string.Empty;

            int numInt = 0;

            int small;
            int big;

            for (int i = 0; i < s.Length; i++)
            {
                if (deleted.IndexOf(s[i]) == -1)
                {
                    deleted += s[i];
                }
            }
            int[] nums = new int[deleted.Length];

            for (int i = 0; i < deleted.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (deleted[i] == s[j])
                    {
                        numInt++;
                    }

                }
                nums[i] = numInt;

                numInt = 0;
            }

            small = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (small > nums[i])
                {
                    small = nums[i];
                }
            }
            big = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (big < nums[i])
                {
                    big = nums[i];
                }
            }

            int smalltoplam = 0;
            int bigToplam = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                smalltoplam += small - nums[i];
                bigToplam += big - nums[i];
            }


            if (smalltoplam == -1 || bigToplam == 1 || smalltoplam == 0 || bigToplam == 0)
            {
                isValid = "YES";
            }

            if (small == 1)
            {
                int count = 0;
                int isEqual = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {

                    if (isEqual == nums[i])
                    {

                    }
                    else
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    isValid = "YES";
                }
            }

            return isValid;
        }

        /// <summary>
        /// String must be non-repetitive 
        /// Returns the minimum number of deletions required
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// 
        public static int AlternatingCharacters(string s)
        {
            int deletions = 0;
            char character = s[0];

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (character == s[i + 1])
                {
                    deletions++;
                }
                else
                {
                    character = s[i + 1];
                }
            }
            return deletions;
        }

        /// <summary>
        /// Rotate the input array with input number 
        /// </summary>
        /// <param name="a">the array to rotate</param>
        /// <param name="d">the number of rotations</param>
        /// <returns></returns>
        public static int[] RotateLeft(int[] a, int d)
        {
            int dim = a.GetUpperBound(0);
            int ilk;
            int isBig = a.Length - d;
            int returnNum;

            if (isBig > 0) //if isBig > 0 , cant divisible to d/ a.Length
            {
                if (a.Length / 2 > d)
                {
                    for (int i = 0; i < d; i++)  //Make RoteLeft
                    {
                        ilk = a[0];

                        for (int j = 0; j < dim; j++)
                        {

                            a[j] = a[j + 1];

                        }
                        a[dim] = ilk; ;
                    }
                    return a;
                }
                else if (a.Length / 2 < d)
                {
                    returnNum = a.Length - d;

                    for (int i = 0; i < returnNum; i++) //Make RoteRight
                    {
                        ilk = a[^1];

                        for (int j = dim; j >= 1; j--)
                        {

                            a[j] = a[j - 1];

                        }
                        a[0] = ilk;
                    }
                    return a;
                }
                else // a.Length / 2 can be equal to d 
                {
                    for (int i = 0; i < d; i++)  //Make RoteLeft
                    {
                        ilk = a[0];

                        for (int j = 0; j < dim; j++)
                        {

                            a[j] = a[j + 1];

                        }
                        a[dim] = ilk; ;
                    }
                    return a;
                }
            }

            else if (isBig < 0)
            {
                if (d % a.Length < a.Length / 2) //Make RoteLeft
                {
                    returnNum = d % a.Length;
                    for (int i = 0; i < returnNum; i++)  //Make RoteLeft
                    {
                        ilk = a[0];

                        for (int j = 0; j < dim; j++)
                        {

                            a[j] = a[j + 1];

                        }
                        a[dim] = ilk; ;
                    }
                    return a;
                }
                else if (d % a.Length > a.Length / 2)
                {
                    returnNum = a.Length - d % a.Length;
                    for (int i = 0; i < returnNum; i++) //Make RoteRight
                    {
                        ilk = a[^1];

                        for (int j = dim; j >= 1; j--)
                        {

                            a[j] = a[j - 1];

                        }
                        a[0] = ilk; ;
                    }
                    return a;
                }
                else // d % a.Length can equal to 0
                {
                    return a;
                }
            }

            return a;
        }

        /// <summary>
        /// if class will cancelled?  return yes if class is cancelled 
        /// </summary>
        /// <param name="k">the threshold number of students</param>
        /// <param name="a"> the arrival times of the students</param>
        /// <returns></returns>
        public static string AngryProfessor(int k, int[] a) // 
        {
            int earlyNum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    earlyNum += 1;
                }
            }
            //int earlyNum = a.Count(t => t <= 0);     //it can be that way
            return earlyNum >= k ? "NO" : "YES";
        }

        /// <summary>
        /// Factorials with biginteger
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static BigInteger ExtraLongFactorials(int n)
        {
            BigInteger bigInt = 1;
            for (int i = 1; i <= n; i++) bigInt *= i;

            return bigInt;
        }

        /// <summary>
        /// Compare two list,add score the list where number is bigger
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] CompareTriplets(List<int> a, List<int> b)
        {
            int[] point = new int[2];
            int dimension = a.Capacity;
            int pointA = 0;
            int pointB = 0;

            for (int i = 0; i < dimension; i++)
            {
                if (a[i] > b[i])
                {
                    pointA += 1;
                }
                else if (b[i] > a[i])
                {
                    pointB += 1;
                }
            }
            point[0] = pointA;
            point[1] = pointB;

            return point;
        }

        /// <summary>
        /// Decimal number to binary number
        /// </summary>
        /// <param name="number">Defoult parameter is 13</param>
        /// <returns></returns>
        public static string DecimalToBınary(int number = 13)
        {
            string binary = string.Empty;
            string chRemain = string.Empty;
            do
            {
                number = Math.DivRem(number, 2, out int remain);
                chRemain += remain.ToString();
            } while (number != 0);

            for (int i = chRemain.Length - 1; i >= 0; i--)
            {
                binary += chRemain[i];
            }
            return binary;
        }


        /// <summary>
        /// return numbers if number is equal to digits cube
        /// </summary>
        public static string SumDigitCube()
        {
            string output = string.Empty;

            for (int i = 100; i < 1000; i++)
            {
                int copyNumber = i;
                double sumCube = 0;
                do
                {
                    var remain = copyNumber % 10;
                    sumCube += Math.Pow(remain, 3);
                    copyNumber /= 10;

                } while (copyNumber != 0);
                if (i == sumCube)
                {
                    output += $"({i})";
                }
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str1">Default:Computer Engineering</param>
        /// <param name="str2">Default:CSharp Programming Language</param>
        /// <returns></returns>
        public static string CommonChars(string str1 = "Computer Engineering", string str2 = "CSharp Programming Language")
        {
            string include = string.Empty;
            bool isInclude = false;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        isInclude = true;
                        break;
                    }
                }
                /*
                   if (str2.Any(t => str1[i] == t))
                   {
                   isInclude = true;
                   }
                 */
                if (isInclude && include.IndexOf(str1[i]) == -1)
                {
                    include += str1[i];
                }
                isInclude = false;
            }
            return include;
        }

        /// <summary>
        /// swap numbers value with no another variable
        /// </summary>
        /// <param name="a">default a = 10</param>
        /// <param name="b">default b = 5</param>
        /// <returns></returns>
        public static string SwapNumbers(int a = 10, int b = 5)
        {
            a *= b;
            b = a / b;
            a /= b;

            return $"New a value:{a},New b value:{b}";
        }

        /// <summary>
        /// Return number,number of digit and sum of digit from input number
        /// </summary>
        /// <param name="number"></param>
        public static string SumDigits(int number)
        {
            int sumDigit = 0;
            int numOfDigit = 0;
            int copyNum = number;
            do
            {
                var digit = number % 10;
                sumDigit += digit;
                number /= 10;
                numOfDigit += 1;

            } while (number != 0);

            return $"Number={copyNum} Number of Digit:{numOfDigit} Sum of Digit: {sumDigit}";
        }

        /// <summary>
        /// calculate the hypotenuse value
        /// </summary>
        /// <param name="a">Side length</param>
        /// <param name="b">Side length</param>
        /// <returns></returns>
        public static double Hypotenuse(int a, int b)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return hypotenuse;
        }

        /// <summary>
        /// Return square root numbers from start to end
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static ArrayList SquareRoot(int start, int end)
        {
            ArrayList intList = new ArrayList();

            for (int i = start; i <= end; i++)
            {
                for (int j = 10; j < 35; j++)
                {
                    if (j * j == i)
                    {
                        intList.Add(j);
                    }
                }
            }
            return intList;
        }

        /// <summary>
        /// Shifting duplicates to beginning except the first
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ShiftFront(string input)
        {
            //Shifting duplicates to beginning except the first
            //string output =  String.Empty;
            string rmvDuplicate = string.Empty;
            string duplicated = string.Empty;
            bool var = false;
            int count = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                    if (count >= 2)  //We're not doing any action for first duplicate
                    {
                        duplicated = $"{input[i]}{duplicated}";
                    }

                }
                for (int j = 0; j < rmvDuplicate.Length; j++)
                {
                    if (input[i] != rmvDuplicate[j]) continue;
                    var = true;
                    break;
                }
                if (var == false)
                {
                    rmvDuplicate += input[i];
                }
                var = false;
            }
            //string output = $"Duplicate numbers-{repeated},duplicate status removed-{rmvDuplicate}";
            string output = $"{duplicated}{rmvDuplicate}";

            return output;
        }

        /// <summary>
        /// Shifting duplicates to beginning 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ShiftFront(params int[] input)
        {
            string output = string.Empty;


            for (int i = 0; i < input.GetUpperBound(0); i++)
            {
                if (input[i] == input[i + 1])
                {
                    output = $"{input[i]}{output}";

                    if (i + 1 == input.GetUpperBound(0))
                    {
                        output = $"{output}{input[i]}";
                    }
                    continue;
                }
                output = $"{output}{input[i]}";
            }
            return output;
        }

        /// <summary>
        /// Split the string
        /// </summary>
        /// <param name="name">Default value = "Ömer Küçük"</param>
        /// <returns></returns>
        public static ObservableCollection<string> Split(string name = "Ömer Küçük")
        {
            string newName = string.Empty;
            ObservableCollection<string> list = new ObservableCollection<string>();
            int j = 0;

            for (int i = 0; i < name.Length; i++)
            {
                do
                {
                    newName += name[j];
                    j++;
                    if (name.Length == j)
                    {
                        break;
                    }
                } while (name[j] != ' ');
                list.Add(newName);
                newName = string.Empty;
                i = j;
            }
            return list;
        }

        /// <summary>
        /// For start number to end number Count Where Divided by 7 remain 3
        /// return the matching numbers
        /// </summary>
        /// <param name="count">count matching numbers</param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string DividedSeven(out int count, int start, int end)
        {
            string numbers = string.Empty;
            count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 7 != 3) continue;
                count++;
                numbers += $"({i})";
            }
            return numbers;
        }

        /// <summary>
        /// Calculate the exam result
        /// </summary>
        /// <param name="midterm"></param>
        /// <param name="finalExam"></param>
        /// <returns></returns>
        public static string ExamResult(int midterm, int finalExam)
        {
            string successDegree;
            int result = midterm * 4 / 10 + finalExam * 6 / 10;

            if (0 > midterm || midterm > 100 || 0 > finalExam || finalExam > 100)
            {
                throw new FormatException("exam scores must be between 0 and 100");
            }

            if (90 <= result && result <= 100)
            {
                successDegree = $"C:Highly Success:{result}";
            }
            else if (80 <= result && result < 90)
            {
                successDegree = $"B: Succesfull:{result}";
            }
            else if (70 <= result && result < 80)
            {
                successDegree = $"C:Pass the Lesson:{result}";
            }
            else if (60 <= result && result < 70)
            {
                successDegree = $"D:Conditional Pass:{result}";
            }
            else
            {
                successDegree = $"F:Failed:{result}";
            }
            return successDegree;
        }

        /// <summary>
        /// Formula of (-b + b2 – 4ac2a) 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double Formula(int a, int b, int c)
        {
            double result = -b + (Math.Pow(b, 2)) - (4 * a * Math.Pow(c, 2) * a);

            return result;
        }

        /// <summary>
        /// With Algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveDuplicateWithAlgorithm(string input)
        {
            input = input.ToLower();
            string output = string.Empty;
            int isInclude = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < output.Length; j++)
                {
                    if (input[i] == output[j])
                    {
                        isInclude = 1;
                        break;
                    }
                }
                if (isInclude == 0)
                    output += input[i];
                isInclude = 0;
            }
            return output;

            /*It can be this way
              foreach (var t1 in input)
            {
                if (output.Any(t => t1 == t))
                {
                    var = 1;
                } 

                if (var == 0)
                    output += t1;
                var = 0;
            }
             */
        }

        /// <summary>
        /// With İndexOf()
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveDuplicateWithIndexOf(string input)
        {
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (output.IndexOf(input[i]) == -1)
                {
                    output += input[i];
                }
            }
            /*
               *foreach (var t in input.Where(t => output.IndexOf(t) == -1))
               {
               output += t;
               }  // it can be this way
             */
            return output;
        }

        /// <summary>
        /// With HashSet
        /// </summary>
        /// <param name="str"></param>
        public static void RemoveDuplicateWithHashSet(string str)
        {
            HashSet<char> lhs = new HashSet<char>();
            foreach (var t in str)
                lhs.Add(t);

            // print string after deleting  
            // duplicate elements 
            foreach (char ch in lhs)
                Console.Write(ch);
        }

        /// <summary>
        /// Two string parameters is anagram?
        /// </summary>
        /// <param name="str1">first parameter</param>
        /// <param name="str2">second parameter</param>
        /// <returns></returns>
        public static bool IsAnagram(string str1, string str2)
        {
            bool isAnagram = true;

            if (str1.Length == str2.Length)
            {
                foreach (var t in str2)
                {
                    isAnagram = str1.IndexOf(t) != -1;
                }

                foreach (var t in str1)
                {
                    isAnagram = str2.IndexOf(t) != -1;
                }
            }
            else
            {
                isAnagram = false;
            }
            return isAnagram;
        }

        /// <summary>
        /// return the smallest word in string array
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string SmallestWord(params string[] words)
        {
            string smallWord = string.Empty;

            foreach (var t in words)
            {
                if (smallWord.Length > t.Length || smallWord.Length == 0)
                {
                    smallWord = t;
                }
            }
            smallWord = $"SmallestWord:{smallWord}";

            return smallWord;
        }

        /// <summary>
        /// retunr the longest word in string array
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LongestWord(params string[] words)
        {
            string longestWord = string.Empty;
            int counter = 0;
            string longestWordNew = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (longestWord.Length < words[i].Length)
                {
                    longestWord = words[i];

                }
                longestWordNew =
                    $"Word:{longestWord} Length: {longestWord.Length} İndexNumber:{i}";
            }
            // int sayac = uzunKelime.Count(t => t == ' '); //ıt can be this way
            for (int i = 0; i < longestWord.Length; i++)
            {
                if (longestWord[i] == ' ')
                {
                    counter++;
                }
            }
            longestWordNew = $"cavities :{counter} {longestWordNew}";

            return longestWordNew;
        }

        /// <summary>
        /// Calculate factorial of the parameter number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static long Factorial(int num)
        {
            long fac = 1;

            for (int i = 1; i <= num; i++) fac *= i;

            return fac;
        }

        /// <summary>
        /// Return prime numbers between start parameter to end parameter
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string PrimeNumber(int start = 0, int end = 100)
        {
            bool isPrime = false;
            string primeNumbers = string.Empty;
            if (start <= 2) primeNumbers += "(2)";

            for (int i = start; i <= end; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    primeNumbers += $"({i})";
                }
                isPrime = false;
            }
            return primeNumbers;
        }

        /// <summary>
        /// return the number of word in string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int WordCount(string data)
        {
            data = data.Trim();
            if (data == "")
            {
                return 0;
            }

            if (!data.Contains("  ")) return data.Split(' ').Count();

            while (data.Contains("  "))
            {
                data = data.Replace("  ", " ");
            }

            return data.Split(' ').Count();
        }

        /// <summary>
        /// String parameter isPalindrom? Return true if its pakindrom.
        /// A palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPalindrom(string input)
        {
            input = input.ToLower();
            for (int i = 0, j = input.Length - 1; j >= 0; i++, j--) //reversing input string
            {
                if (input[i] == input[j]) continue;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Return if number is Palindrom.A palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPalindrom(int number)
        {
            int revNumber = 0;
            int copySayi = number;
            do
            {
                var remain = number % 10;
                revNumber = (revNumber * 10) + remain;
                number /= 10;
            } while (number != 0);

            return copySayi == revNumber;
        }


        /// <summary>
        /// How many input character in input string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int HowMany(string str, char c)
        {
            int num = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (c == str[i])
                {
                    num++;
                }
            }
            return num;
        }

        /// <summary>
        /// Return the average of vowel character in string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float VowelCharsAvg(string str)
        {
            float result;
            float vowelChar = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'ı' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'ö' || str[i] == 'u' || str[i] == 'ü')
                {
                    vowelChar++;
                }
            }
            /* foreach (var t in str.Where(t => t == 'a' || t == 'e' || t == 'ı' || t == 'i' || t == 'o' ||
               t == 'ö' || t == 'u' || t == 'ü'))
               {
               sesliHarf++;
               }*/
            result = vowelChar / str.Length;

            return result;
        }

        /// <summary>
        /// Calculate Potential Energy with input numbers
        /// </summary>
        /// <param name="m">mass</param>
        /// <param name="h">height</param>
        /// <param name="g">Default g number = 9.8f</param>
        public static string PotentialEnergy(int m, int h, float g = 9.8f)
        {
            float sonuc = m * g * h;
            return $"Potential Energy: {sonuc}";
        }

        /// <summary>
        /// Calculate Kinetic Energy with input numbers
        /// </summary>
        /// <param name="m">mass</param>
        /// <param name="h">height</param>
        /// <param name="g">Defoult g number = 9.8f</param>
        public static string KineticEnergy(int m, int v)
        {
            double sonuc = (1 / 2) * m * Math.Pow(v, 2);
            return $"Kinetic Energy: {sonuc}";
        }


        /// <summary>
        /// Calculate average of the array containing start value to end value
        /// </summary>
        /// <param name="start">for start value</param>
        /// <param name="end">for end value</param>
        public static float AvgArray(int start, int end)
        {
            float sum = 0;
            float numsOfArray = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                numsOfArray++;
            }
            return sum / numsOfArray;
        }

        /// <summary>
        /// Calculate average of the array containing params numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static float AvgArray(params int[] numbers)
        {
            //int sum = sayi.Sum(); 
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            // ReSharper disable once PossibleLossOfFraction
            float avg = sum / numbers.Length;

            return avg;
        }


        /// <summary>
        /// Transform two dimensioanal array to one dimensioanal
        /// </summary>
        /// <param name="twoDimensional"></param>
        /// <returns></returns>
        public static int[] Transform(int[,] twoDimensional)
        {
            int a = twoDimensional.GetUpperBound(0) + 1;
            int b = twoDimensional.GetUpperBound(1) + 1;
            int arrayLength = a * b;
            int sayac = 0;
            int[] oneDimensional = new int[arrayLength];


            for (int i = 0; i <= twoDimensional.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= twoDimensional.GetUpperBound(1); j++)
                {
                    oneDimensional[sayac] = twoDimensional[i, j];
                    sayac += 1;
                }
            }
            return oneDimensional;
        }

        /// <summary>
        /// Numbers that are divisible by 4 and 5
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static ArrayList DivisibleNums(params int[] nums)
        {
            ArrayList divisible = new ArrayList();

            for (var i = 0; i < nums.Length; i++)
            {
                if (i % 4 == 0 && i % 5 == 0)
                {
                    divisible.Add(i);
                }
            }
            return divisible;
        }

        /// <summary>
        /// How many numbers smaller than parameter number in params numbers
        /// </summary>
        /// <param name="num"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SmallNumCount(int num, params int[] nums)
        {
            //return nums.Count(t => num < t); //it can be this way
            int sayac = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (num < nums[i])
                {
                    sayac++;
                }
            }
            return sayac;
        }

        /// <summary>
        /// return matrix transpose
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] Transpoz(int[,] matrix)
        {
            int a = matrix.GetUpperBound(0) + 1;
            int b = matrix.GetUpperBound(1) + 1;

            int[,] newMatris = new int[b, a];
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    newMatris[j, i] = matrix[i, j];
                }

            return newMatris;
        }


        /// <summary>
        /// Enter numbers to paramater until their sum does not bigger than 30 
        /// </summary>
        public static string SumThirty(params int[] numbers)
        {
            int sum = 0;
            string nums = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (sum >= 30)
                {
                    return $"Array sum bigger than 30,Your numbers is: {nums}";
                }
                nums += $"({numbers[i]})";
            }
            return nums;

            //ArrayList list = new ArrayList();
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine("Enter your number: ");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    sum += a;
            //    list.Add(a);

            //} while (sum < 30);
            //Console.WriteLine(list.Count);
        }




        #region For Console

        /// <summary>
        /// For Console
        /// </summary>
        public static void Triangle()//Copy
        {
            int i, j, k, l, n;
            Console.Write("Enter the Range=");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// For Console
        /// </summary>
        public static void MultiplicationTable()//Look again
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("  " + i + "*" + j + "=" + i * j + "  ");
                }
                Console.WriteLine("  ");
            }
        }

        /// <summary>
        /// For Console/// 
        /// </summary>
        public static void EvenAndOddNumbers()
        {
            int sumOdd = 0;
            int sumEven = 0;
            int countOdd = 0;
            int countEven = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even Number: " + i);
                    sumEven += i;
                    countEven++;
                }
                else
                {
                    Console.WriteLine("Odd Number: " + i);
                    sumOdd += i;
                    countOdd++;
                }
            }
            Console.WriteLine("Total of Even Numbers: " + countEven + "Sum of Even Numbers: " + sumEven);
            Console.WriteLine("Total of Odd Numbers: " + countOdd + " Sum of Odd Numbers " + sumOdd);
        }

        /// <summary>
        /// For Console
        /// Break When Input Number = Zero
        /// </summary>
        public static void UntilInputZero()
        {
            int input;
            int negative = 0;
            int positive = 0;
            int positiveCount = 0;
            int negativeCount = 0;
            do
            {
                Console.WriteLine("Input the number: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input <= 0)
                {
                    negative += input;
                    negativeCount++;
                }
                else
                {
                    positive += input;
                    positiveCount++;
                }
            } while (input != 0);

            int positiveAvg = positive / positiveCount;
            int negativeAvg = negative / negativeCount;

            Console.WriteLine($"Positive:{positive} Positive Numbers average:{positiveAvg} Negative:{negative} Negative numbers average:{negativeAvg}");
        }

        /// <summary>
        /// For Console
        /// </summary>
        /// <returns></returns>
        public static string[] FillString()
        {
            Console.WriteLine("How many words do you want to input: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            string[] wordArray = new string[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Input {0}. word", i + 1);
                wordArray[i] = Console.ReadLine();
            }
            return wordArray;
        }

        /// <summary>
        /// For Console
        /// </summary>
        public static void FillandPrintTwoDimensioal()
        {
            Console.WriteLine("Input the length of two dimensional array you will enter");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensioal = new int[a, b];

            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Input [{0}][{1}] :", i, j);
                    int m = Convert.ToInt32(Console.ReadLine());
                    twoDimensioal[i, j] = m;
                }

            for (int i = 0; i <= twoDimensioal.GetUpperBound((0)); i++)
                for (int j = 0; j <= twoDimensioal.GetUpperBound(1); j++)
                    Console.WriteLine(twoDimensioal[i, j]);
        }

        /// <summary>
        /// For Console
        /// </summary>
        /// <returns></returns>
        public static int[,] FillTwoDimendional()
        {
            Console.WriteLine("Input the length of two dimensional array");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensional = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Input = [{0}][{1}]: ", i, j);
                    int m = Convert.ToInt32(Console.ReadLine());
                    twoDimensional[i, j] = m;
                }
            }
            return twoDimensional;
        }

        /// <summary>
        /// For Console
        /// </summary>
        /// <returns></returns>
        public static int[] FillOneDimensional()
        {
            Console.WriteLine("Input the length of the array you will enter");
            int dimension = Convert.ToInt32(Console.ReadLine());
            int[] OneDimensional = new int[dimension];
            for (int i = 0; i < OneDimensional.Length; i++)
            {
                Console.WriteLine("Input {0}. number", i + 1);
                OneDimensional[i] = int.Parse(Console.ReadLine() ?? "0"); //if input is null = int.Parse(Console.ReadLine() ?? "0")
            }
            return OneDimensional;
        }

        /// <summary>
        /// For Console
        /// </summary>
        /// <param name="twoDimensional"></param>
        public static void PrintTwoDimensional(int[,] twoDimensional)
        {
            Console.WriteLine("Your Matrix: ");
            for (int i = 0; i <= twoDimensional.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= twoDimensional.GetUpperBound(1); j++)
                {
                    Console.Write(twoDimensional[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// For Console
        /// </summary>
        /// <param name="oneDimensional"></param>
        public static void PrintOneDimensional(params int[] oneDimensional)
        {
            Console.WriteLine("Your Matrix: ");
            foreach (var od in oneDimensional)
            {
                Console.WriteLine(od);
            }
        }

        /// <summary>
        /// For Console
        /// </summary>
        public static void SumMatrix()
        {
            Console.WriteLine("For First Matrix");
            int[,] firstMatrix = FillTwoDimendional();
            Console.WriteLine("For Second Matrix");
            int[,] secondMatrix = FillTwoDimendional();

            int a = firstMatrix.GetUpperBound(0) + 1;
            int b = secondMatrix.GetUpperBound(1) + 1;

            int[,] sumMatrix = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
        }


        #endregion


    }
}
