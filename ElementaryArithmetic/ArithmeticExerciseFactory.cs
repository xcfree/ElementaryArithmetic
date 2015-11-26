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
            string operation = " ＋ ";

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
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; i++)
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                exList.Add(factor1 + operation + factor2 + " = ");
            }
            for (int i = 0; i < blankVolume; i++)
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                if (random.Next() % 2 == 0)
                    exList.Add(factor1 + operation + "(    )" + " = " + (factor1 + factor2));
                else
                    exList.Add("(    )" + operation + factor2 + " = " + (factor1 + factor2));
            }
            return exList;
        }
        public ArrayList ProduceMinusEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = " － ";

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
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; i++)
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                exList.Add((factor1+factor2) + operation + factor1 + " = ");
            }
            for (int i = 0; i < blankVolume; i++)
            {
                int factor1 = random.Next(minFactor, maxFactor - minFactor);
                int factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor - factor1));
                if (random.Next() % 2 == 0)
                    exList.Add((factor1+factor2) + operation + "(    )" + " = " + factor2);
                else
                    exList.Add("(    )" + operation + factor1 + " = " + factor2);
            }
            return exList;
        }
        public ArrayList ProduceMultiplyEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = " × ";

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
            // 如果难度超过10就不出现因子0、1这种简单题目了
            int minFactor = (maxFactor > 10 ? 2 : 1);
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; i++)
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    factor1 = random.Next(minFactor, maxFactor / minFactor);
                    factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                exList.Add(factor1 + operation + factor2 + " = ");
            }
            for (int i = 0; i < blankVolume; i++)
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    factor1 = random.Next(minFactor, maxFactor / minFactor);
                    factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                if (random.Next() % 2 == 0)
                    exList.Add(factor1 + operation + "(    )" + " = " + (factor1*factor2));
                else
                    exList.Add("(    )" + operation + factor2 + " = " + (factor1*factor2));
            }
 
            return exList;
        }
        public ArrayList ProduceDivideEx(int volume, int maxFactor, double fillInBlankPercentage)
        {
            string operation = " ÷ ";

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
            // 如果难度超过10就不出现因子0、1这种简单题目了
            int minFactor = (maxFactor > 10 ? 2 : 1);
            Random random = new Random();
            for (int i = 0; i < nonBlankVolume; i++)
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    factor1 = random.Next(minFactor, maxFactor / minFactor);
                    factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                exList.Add((factor1*factor2) + operation + factor1 + " = ");
            }
            for (int i = 0; i < blankVolume; i++)
            {
                int factor1, factor2;
                if (maxFactor == 1)
                {
                    factor1 = 0;
                    factor2 = 0;
                }
                else
                {
                    factor1 = random.Next(minFactor, maxFactor / minFactor);
                    factor2 = random.Next(minFactor, Math.Max(minFactor + 1, maxFactor / factor1));
                }
                if (random.Next() % 2 == 0)
                    exList.Add((factor1*factor2) + operation + "(    )" + " = " + factor2);
                else
                    exList.Add("(    )" + operation + factor1 + " = " + factor2);
            }
 
            return exList;
        }

    }
}
