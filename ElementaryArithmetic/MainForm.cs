using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ElementaryArithmetic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void updateNumericUpDownControlsMaximum()
        {
            decimal addPercentage = numericUpDownAddPercentage.Value;
            decimal minusPercentage = numericUpDownMinusPercentage.Value;
            decimal multiplyPercentage = numericUpDownMultiplyPercentage.Value;
            decimal dividePercentage = numericUpDownDividePercentage.Value;

            numericUpDownAddPercentage.Maximum = 100 - minusPercentage - multiplyPercentage - dividePercentage;
            numericUpDownMinusPercentage.Maximum = 100 - addPercentage - multiplyPercentage - dividePercentage;
            numericUpDownMultiplyPercentage.Maximum = 100 - addPercentage - minusPercentage - dividePercentage;
            numericUpDownDividePercentage.Maximum = 100 - addPercentage - minusPercentage - multiplyPercentage;
        }
        
        private void numericUpDownAdd_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAddPercentage.Value = (int)numericUpDownAddPercentage.Value;
            // 避免光标在输入框最左跳动影响视线
            labelAdd.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownMinus_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMinusPercentage.Value = (int)numericUpDownMinusPercentage.Value;
            // 避免光标在输入框最左跳动影响视线
            labelMinus.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownMultiply_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMultiplyPercentage.Value = (int)numericUpDownMultiplyPercentage.Value;
            // 避免光标在输入框最左跳动影响视线
            labelMultiply.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownDivide_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDividePercentage.Value = (int)numericUpDownDividePercentage.Value;
            // 避免光标在输入框最左跳动影响视线
            labelDivide.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void buttonEvenDistribute_Click(object sender, EventArgs e)
        {
            numericUpDownAddPercentage.Maximum = 25;
            numericUpDownMinusPercentage.Maximum = 25;
            numericUpDownMultiplyPercentage.Maximum = 25;
            numericUpDownDividePercentage.Maximum = 25;

            numericUpDownAddPercentage.Value = 25;
            numericUpDownMinusPercentage.Value = 25;
            numericUpDownMultiplyPercentage.Value = 25;
            numericUpDownDividePercentage.Value = 25;
        }

        private void buttonGenExercise_Click(object sender, EventArgs e)
        {
            int maxFactor = decimal.ToInt32(numericUpDownMaxFactor.Value);
            if (maxFactor < 1)
            {
                MessageBox.Show("难度太低，请提高难度 :XD");
                return;
            }

            decimal addPercentage = numericUpDownAddPercentage.Value;
            decimal minusPercentage = numericUpDownMinusPercentage.Value;
            decimal multiplyPercentage = numericUpDownMultiplyPercentage.Value;
            decimal dividePercentage = numericUpDownDividePercentage.Value;
            decimal totalPercentage = addPercentage + minusPercentage + multiplyPercentage + dividePercentage;
            // 如果总占比小于100%，则根据现有占比平均分配
            if (totalPercentage == 0)
            {
                MessageBox.Show("所有题型占比都是0，请重新分配 :XD");
                return;
            }
            if (totalPercentage != 100)
            {
                numericUpDownAddPercentage.Value = (int)(addPercentage * 100 / totalPercentage);
                numericUpDownMinusPercentage.Value = (int)(minusPercentage * 100 / totalPercentage);
                numericUpDownMultiplyPercentage.Value = (int)(multiplyPercentage * 100 / totalPercentage);
                // 其实可以直接等于 numericUpDownDividePercentage.Maximum
                numericUpDownDividePercentage.Value = 100 - numericUpDownAddPercentage.Value - numericUpDownMinusPercentage.Value - numericUpDownMultiplyPercentage.Value;
            }
            int exVolumeAll = decimal.ToInt32(numericUpDownExVolume.Value);
            int exVolumeAdd = decimal.ToInt32(numericUpDownAddPercentage.Value * exVolumeAll / 100);
            int exVolumeMinus = decimal.ToInt32(numericUpDownMinusPercentage.Value * exVolumeAll / 100);
            int exVolumeMultiply = decimal.ToInt32(numericUpDownMultiplyPercentage.Value * exVolumeAll / 100);
            // 这个考虑用总数减去前三个数，避免整除导致最后四个题量加起来不是总题量
            int exVolumeDivide = decimal.ToInt32(numericUpDownDividePercentage.Value * exVolumeAll / 100);
            //int exVolumeDivide = decimal.ToInt32(exVolumeAll - exVolumeAdd - exVolumeMinus - exVolumeMultiply);
            int exVolumeDiff = exVolumeAll - exVolumeAdd - exVolumeMinus - exVolumeMultiply - exVolumeDivide;
            if (exVolumeDiff > 0)
            {
                if (exVolumeAdd > 0)
                    exVolumeAdd = exVolumeAdd + exVolumeDiff;
                else if (exVolumeMinus > 0)
                    exVolumeMinus = exVolumeMinus + exVolumeDiff;
                else if (exVolumeMultiply > 0)
                    exVolumeMultiply = exVolumeMultiply + exVolumeDiff;
                else
                    exVolumeDivide = exVolumeDivide + exVolumeDiff;
            }
            double fillInBlankPercentage = decimal.ToInt64(numericUpDownFillInBlankPercentage.Value) / 100.0;

            ArithmeticExerciseFactory exFactory = new ArithmeticExerciseFactory();
            ArrayList exerciseList = new ArrayList();
            exerciseList.AddRange(exFactory.ProduceAddEx(exVolumeAdd, maxFactor, fillInBlankPercentage));
            exerciseList.AddRange(exFactory.ProduceMinusEx(exVolumeMinus, maxFactor, fillInBlankPercentage));
            exerciseList.AddRange(exFactory.ProduceMultiplyEx(exVolumeMultiply, maxFactor, fillInBlankPercentage));
            exerciseList.AddRange(exFactory.ProduceDivideEx(exVolumeDivide, maxFactor, fillInBlankPercentage));
            // 打乱题目顺序
            string[] exerciseArray = (string[])exerciseList.ToArray(typeof(string));
            Random random = new Random();
            for (int i = 0; i < exerciseArray.Length; i++)
            {
                int r = random.Next(0, exerciseArray.Length);
                string tmp = exerciseArray[i];
                exerciseArray[i] = exerciseArray[r];
                exerciseArray[r] = tmp;

                Console.WriteLine("length: " + exerciseArray[i].Length);
            }

            new ResultForm(exerciseArray).ShowDialog(); //, exVolumeAdd, exVolumeMinus, exVolumeMultiply, exVolumeDivide).ShowDialog();

            //Console.WriteLine(DateTime.Now + " @ done with " + exerciseArray.Length + " questions.");
            //return;
        }


    }
}
