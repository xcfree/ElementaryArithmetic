using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElementaryArithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateNumericUpDownControlsMaximum()
        {
            decimal addPercentage = numericUpDownAdd.Value;
            decimal minusPercentage = numericUpDownMinus.Value;
            decimal multiplyPercentage = numericUpDownMultiply.Value;
            decimal dividePercentage = numericUpDownDivide.Value;

            numericUpDownAdd.Maximum = 100 - minusPercentage - multiplyPercentage - dividePercentage;
            numericUpDownMinus.Maximum = 100 - addPercentage - multiplyPercentage - dividePercentage;
            numericUpDownMultiply.Maximum = 100 - addPercentage - minusPercentage - dividePercentage;
            numericUpDownDivide.Maximum = 100 - addPercentage - minusPercentage - multiplyPercentage;
        }
        
        private void numericUpDownAdd_ValueChanged(object sender, EventArgs e)
        {
            // 避免光标在输入框最左跳动影响视线
            labelAdd.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownMinus_ValueChanged(object sender, EventArgs e)
        {
            // 避免光标在输入框最左跳动影响视线
            labelMinus.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownMultiply_ValueChanged(object sender, EventArgs e)
        {
            // 避免光标在输入框最左跳动影响视线
            labelMultiply.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void numericUpDownDivide_ValueChanged(object sender, EventArgs e)
        {
            // 避免光标在输入框最左跳动影响视线
            labelDivide.Focus();
            updateNumericUpDownControlsMaximum();
        }

        private void buttonEvenDistribute_Click(object sender, EventArgs e)
        {
            numericUpDownAdd.Maximum = 25;
            numericUpDownMinus.Maximum = 25;
            numericUpDownMultiply.Maximum = 25;
            numericUpDownDivide.Maximum = 25;

            numericUpDownAdd.Value = 25;
            numericUpDownMinus.Value = 25;
            numericUpDownMultiply.Value = 25;
            numericUpDownDivide.Value = 25;
        }

    }
}
