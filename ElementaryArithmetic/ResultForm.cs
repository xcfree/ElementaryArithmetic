using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ElementaryArithmetic
{
    public partial class ResultForm : Form
    {
        const int fixColumnWidth = 20;

        public ResultForm(string[] exerciseArray) //, int exVolumeAdd, int exVolumeMinus, int exVolumeMultiply, int exVolumeDivide)
        {
            InitializeComponent();

            this.printDocument1.OriginAtMargins = true;//启用页边距
            this.pageSetupDialog1.EnableMetric = true; //以毫米为单位
            this.pageSetupDialog1.PageSettings.Margins.Top = 0;
            this.pageSetupDialog1.PageSettings.Margins.Left = 20;
            this.pageSetupDialog1.PageSettings.Margins.Right = 0;
            this.pageSetupDialog1.PageSettings.Margins.Bottom = 0;

            fillTextboxEx(exerciseArray); //, exVolumeAdd, exVolumeMinus, exVolumeMultiply, exVolumeDivide);
        }

        private void fillTextboxEx(string[] exArrary) //, int exVolAdd, int exVolMinus, int exVolMultiply, int exVolDivide)
        {
            textBoxEx.AppendText("                                钱氏口算");
            textBoxEx.AppendText(Environment.NewLine);
            textBoxEx.AppendText(Environment.NewLine);
            textBoxEx.AppendText("                          ___月___日   得分：");
            textBoxEx.AppendText(Environment.NewLine);
            
            for (int i = 0; i < exArrary.Length; i++)
            {
                if (i % 4 == 0)
                    textBoxEx.AppendText(Environment.NewLine);
                //textBoxEx.AppendText(exArrary[i]); // + "  \t\t");
                textBoxEx.AppendText(adjustStringByLength(exArrary[i], fixColumnWidth)); 
            }

            if (exArrary.Length % 4 != 0)
                textBoxEx.AppendText(Environment.NewLine);

            //textBoxEx.AppendText(Environment.NewLine);
            //textBoxEx.AppendText("共" + (exVolAdd + exVolMinus + exVolMultiply + exVolDivide) + "题目，加法" + exVolAdd + "题，减法" + exVolMinus + "题，乘法" + exVolMultiply + "题，除法" + exVolDivide + "题");
            //textBoxEx.AppendText(Environment.NewLine);
            //textBoxEx.AppendText(Environment.NewLine);

        }

        private string adjustStringByLength(string inputString, int length)
        {
            string adjustedString = inputString;
            while (Encoding.Default.GetByteCount(adjustedString) < length)
            {
                adjustedString += " ";
            }
            return adjustedString;
        }

        private void buttonPageSetup_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog(); 
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(textBoxEx.Text, new Font("宋体", 14, FontStyle.Bold), Brushes.Black, 30, 105);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
