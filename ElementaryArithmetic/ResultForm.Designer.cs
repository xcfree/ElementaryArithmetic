namespace ElementaryArithmetic
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.textBoxEx = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.buttonPageSetup = new System.Windows.Forms.Button();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEx
            // 
            this.textBoxEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEx.Location = new System.Drawing.Point(0, 0);
            this.textBoxEx.Multiline = true;
            this.textBoxEx.Name = "textBoxEx";
            this.textBoxEx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEx.Size = new System.Drawing.Size(421, 442);
            this.textBoxEx.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(333, 448);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "打印";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // buttonPageSetup
            // 
            this.buttonPageSetup.Location = new System.Drawing.Point(161, 448);
            this.buttonPageSetup.Name = "buttonPageSetup";
            this.buttonPageSetup.Size = new System.Drawing.Size(75, 23);
            this.buttonPageSetup.TabIndex = 2;
            this.buttonPageSetup.Text = "打印设置";
            this.buttonPageSetup.UseVisualStyleBackColor = true;
            this.buttonPageSetup.Click += new System.EventHandler(this.buttonPageSetup_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Location = new System.Drawing.Point(247, 448);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintPreview.TabIndex = 3;
            this.buttonPrintPreview.Text = "打印预览";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 476);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.buttonPageSetup);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.textBoxEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钱氏口算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEx;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button buttonPageSetup;
        private System.Windows.Forms.Button buttonPrintPreview;

    }
}