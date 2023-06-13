using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                else if(numbers[i] % 2 != 0)
                {
                    answer -= numbers[i];
                }
                else
                {
                    answer += 0;
                }
            }   
                return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> answer = new List<string>() { str1, str2, str3, str4 };
            return answer.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> answer = new List<int>() { number1, number2, number3, number4 };
            return answer.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            
            bool answer = double.TryParse(input,out double nonName);
            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            //    int answer = 0;
            //    int even = 0;
            //for (int i = 0; i > numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        even++;
            //        answer += numbers[i];

            //    }
            //}
            //return answer / even;

            try
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == 0 || number == 1)
            {
                return 1;
            }
            if(number >= 2)
            {
                var factorial = number * Factorial(number - 1);
                return factorial;
            }
            return 0;
        }
    }
}
