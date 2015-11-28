using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ElementaryArithmetic
{
    class ArithmeticExerciseFactory
    {
        public ArrayList ProduceAddEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = "＋";

            if (fillInBlankPercentage > 1)
                fillInBlankPercentage = 1;
            else if (fillInBlankPercentage < 0)
                fillInBlankPercentage = 0;
            int blankVolume = (int)(volume * fillInBlankPercentage);
            int nonBlankVolume = volume - blankVolume;

            ArrayList exList = new ArrayList();
            if (maxFactor < 1)
            {
                return exList;
            }
            // 如果难度超过20就不出现因子0、1这种简单题目了
            int minFactor = (maxFactor > 20 ? 2 : 0);
            // 减少重复题目，如果发现重复则再试一次
            // 另外如果难度太低可能会导致无法保证不重复的情况下出够题目同时也考虑效率问题，只重试10次
            int repeatedTimes = 0;
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; )
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                string equation = factor1 + operation + factor2 + "=";
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }
            }
            for (int i = 0; i < blankVolume; )
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                string equation;
                if (random.Next() % 2 == 0)
                    equation = factor1 + operation + "(   )" + "=" + (factor1 + factor2);
                else
                    equation = "(   )" + operation + factor2 + "=" + (factor1 + factor2);
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }
            }
            return exList;
        }
        public ArrayList ProduceMinusEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = "－";

            if (fillInBlankPercentage > 1)
                fillInBlankPercentage = 1;
            else if (fillInBlankPercentage < 0)
                fillInBlankPercentage = 0;
            int blankVolume = (int)(volume * fillInBlankPercentage);
            int nonBlankVolume = volume - blankVolume;

            ArrayList exList = new ArrayList();
            if (maxFactor < 1)
            {
                return exList;
            }
            // 如果难度超过20就不出现因子0、1这种简单题目了
            int minFactor = (maxFactor > 20 ? 2 : 0);
            // 减少重复题目，如果发现重复则再试一次
            // 另外如果难度太低可能会导致无法保证不重复的情况下出够题目同时也考虑效率问题，只重试10次
            int repeatedTimes = 0;
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; )
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                string equation = (factor1+factor2) + operation + factor1 + "=";
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
            for (int i = 0; i < blankVolume; )
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                string equation; 
                if (random.Next() % 2 == 0)
                    equation = (factor1+factor2) + operation + "(   )" + "=" + factor2;
                else
                    equation = "(   )" + operation + factor1 + "=" + factor2;
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
            return exList;
        }
        public ArrayList ProduceMultiplyEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = "×";

            if (fillInBlankPercentage > 1)
                fillInBlankPercentage = 1;
            else if (fillInBlankPercentage < 0)
                fillInBlankPercentage = 0;
            int blankVolume = (int)(volume * fillInBlankPercentage);
            int nonBlankVolume = volume - blankVolume;

            ArrayList exList = new ArrayList();
            if (maxFactor < 1)
            {
                return exList;
            }
            // 因子最大值取平方根，避免其中某个因子过大时另一个因子只能取1-3这些小数值
            //maxFactor = (int)Math.Sqrt(maxFactor);
            // 如果难度超过10就不出现因子0、1这种简单题目了
            //int minFactor = (maxFactor > 5 ? 3 : 0);
            int minFactor = 0;
            // 减少重复题目，如果发现重复则再试一次
            // 另外如果难度太低可能会导致无法保证不重复的情况下出够题目同时也考虑效率问题，只重试10次
            int repeatedTimes = 0;
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; )
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    //factor1 = random.Next(minFactor, maxFactor / minFactor);
                    // 乘法其中一个因子必须是个位数
                    factor1 = random.Next(minFactor, 9);
                    //factor1 = random.Next(minFactor, maxFactor);
                    if (factor1 == 0 || factor1 == 1)
                    {
                        // 因子为0或1的题目只出现一次
                        minFactor = 2;
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor));
                    }
                    else
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                    //factor2 = random.Next(minFactor, maxFactor);
                    if (random.Next() % 2 == 0)
                    {
                        int tmp = factor1;
                        factor1 = factor2;
                        factor2 = tmp;
                    }
                }
                string equation = factor1 + operation + factor2 + "=";
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
            for (int i = 0; i < blankVolume; )
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    // 乘法其中一个因子必须是个位数
                    factor1 = random.Next(minFactor, 9);
                    if (factor1 == 0 || factor1 == 1)
                    {
                        // 因子为0或1的题目只出现一次
                        minFactor = 2;
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor));
                    }
                    else
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                string equation;
                if (random.Next() % 2 == 0)
                    equation = factor1 + operation + "(   )" + "=" + (factor1*factor2);
                else
                    equation = "(   )" + operation + factor1 + "=" + (factor1*factor2);
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
 
            return exList;
        }
        public ArrayList ProduceDivideEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = "÷";

            if (fillInBlankPercentage > 1)
                fillInBlankPercentage = 1;
            else if (fillInBlankPercentage < 0)
                fillInBlankPercentage = 0;
            int blankVolume = (int)(volume * fillInBlankPercentage);
            int nonBlankVolume = volume - blankVolume;

            ArrayList exList = new ArrayList();
            if (maxFactor < 1)
            {
                return exList;
            }
            // 因子最大值取平方根，避免其中某个因子过大时另一个因子只能取1-3这些小数值
            //maxFactor = (int)Math.Sqrt(maxFactor);
            // 如果难度超过10就不出现因子0、1这种简单题目了
            //int minFactor = (maxFactor > 5 ? 3 : 0);
            int minFactor = 1;
            // 减少重复题目，如果发现重复则再试一次
            // 另外如果难度太低可能会导致无法保证不重复的情况下出够题目同时也考虑效率问题，只重试10次
            int repeatedTimes = 0;
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; )
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    // 
                    factor1 = random.Next(minFactor, 9);
                    if (factor1 == 0 || factor1 == 1)
                    {
                        // 因子为0或1的题目只出现一次
                        minFactor = 2;
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor));
                    }
                    else
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
               }
                string equation = (factor1*factor2 + random.Next(0, Math.Min(factor1, factor2))) + operation + factor1 + "=";
                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
            for (int i = 0; i < blankVolume; )
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    // 
                    factor1 = random.Next(minFactor, 9);
                    if (factor1 == 0 || factor1 == 1)
                    {
                        // 因子为0或1的题目只出现一次
                        minFactor = 2;
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor));
                    }
                    else
                        factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                string equation;
                int remainder = random.Next(0, Math.Min(factor1, factor2));
                if (random.Next() % 2 == 0)
                {
                    equation = (factor1 * factor2 + remainder) + operation + "(   )" + "=" + factor1;
                }
                else
                    equation = "(   )" + operation + factor1 + "=" + factor2;
                if (remainder != 0)
                    equation += "……" + remainder;

                if (repeatedTimes > 10 || !exList.Contains(equation))
                {
                    exList.Add(equation);
                    repeatedTimes = 0;
                    i++;
                }
                else
                {
                    repeatedTimes++;
                }

            }
 
            return exList;
        }

    }
}
