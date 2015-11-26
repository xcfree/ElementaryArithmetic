namespace ElementaryArithmetic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelMinus = new System.Windows.Forms.Label();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.labelDivide = new System.Windows.Forms.Label();
            this.numericUpDownAdd = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinus = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMultiply = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDivide = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.buttonEvenDistribute = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(15, 29);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(17, 12);
            this.labelAdd.TabIndex = 2;
            this.labelAdd.Text = "加";
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Location = new System.Drawing.Point(15, 54);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(17, 12);
            this.labelMinus.TabIndex = 3;
            this.labelMinus.Text = "减";
            // 
            // labelMultiply
            // 
            this.labelMultiply.AutoSize = true;
            this.labelMultiply.Location = new System.Drawing.Point(15, 83);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(17, 12);
            this.labelMultiply.TabIndex = 4;
            this.labelMultiply.Text = "乘";
            // 
            // labelDivide
            // 
            this.labelDivide.AutoSize = true;
            this.labelDivide.Location = new System.Drawing.Point(15, 107);
            this.labelDivide.Name = "labelDivide";
            this.labelDivide.Size = new System.Drawing.Size(17, 12);
            this.labelDivide.TabIndex = 5;
            this.labelDivide.Text = "除";
            // 
            // numericUpDownAdd
            // 
            this.numericUpDownAdd.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAdd.Location = new System.Drawing.Point(50, 27);
            this.numericUpDownAdd.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownAdd.Name = "numericUpDownAdd";
            this.numericUpDownAdd.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownAdd.TabIndex = 6;
            this.numericUpDownAdd.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownAdd.ValueChanged += new System.EventHandler(this.numericUpDownAdd_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEvenDistribute);
            this.groupBox1.Controls.Add(this.numericUpDownDivide);
            this.groupBox1.Controls.Add(this.numericUpDownMultiply);
            this.groupBox1.Controls.Add(this.numericUpDownMinus);
            this.groupBox1.Controls.Add(this.labelAdd);
            this.groupBox1.Controls.Add(this.labelMinus);
            this.groupBox1.Controls.Add(this.labelMultiply);
            this.groupBox1.Controls.Add(this.numericUpDownAdd);
            this.groupBox1.Controls.Add(this.labelDivide);
            this.groupBox1.Location = new System.Drawing.Point(264, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "题型分布（%）";
            // 
            // numericUpDownMinus
            // 
            this.numericUpDownMinus.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMinus.Location = new System.Drawing.Point(50, 54);
            this.numericUpDownMinus.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMinus.Name = "numericUpDownMinus";
            this.numericUpDownMinus.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownMinus.TabIndex = 7;
            this.numericUpDownMinus.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMinus.ValueChanged += new System.EventHandler(this.numericUpDownMinus_ValueChanged);
            // 
            // numericUpDownMultiply
            // 
            this.numericUpDownMultiply.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMultiply.Location = new System.Drawing.Point(50, 81);
            this.numericUpDownMultiply.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMultiply.Name = "numericUpDownMultiply";
            this.numericUpDownMultiply.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownMultiply.TabIndex = 8;
            this.numericUpDownMultiply.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMultiply.ValueChanged += new System.EventHandler(this.numericUpDownMultiply_ValueChanged);
            // 
            // numericUpDownDivide
            // 
            this.numericUpDownDivide.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDivide.Location = new System.Drawing.Point(50, 107);
            this.numericUpDownDivide.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownDivide.Name = "numericUpDownDivide";
            this.numericUpDownDivide.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownDivide.TabIndex = 9;
            this.numericUpDownDivide.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownDivide.ValueChanged += new System.EventHandler(this.numericUpDownDivide_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "题量";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(77, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 21);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "填空占比（%）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "难度";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(106, 74);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 21);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(63, 51);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(98, 21);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonEvenDistribute
            // 
            this.buttonEvenDistribute.Location = new System.Drawing.Point(30, 134);
            this.buttonEvenDistribute.Name = "buttonEvenDistribute";
            this.buttonEvenDistribute.Size = new System.Drawing.Size(75, 23);
            this.buttonEvenDistribute.TabIndex = 17;
            this.buttonEvenDistribute.Text = "平均分布";
            this.buttonEvenDistribute.UseVisualStyleBackColor = true;
            this.buttonEvenDistribute.Click += new System.EventHandler(this.buttonEvenDistribute_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(17, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "不出现0、1等简单运算";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(228, 16);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "乘法中一个因数必须是一位数或整十数";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 156);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(216, 16);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "除法中除数可以是一位数或者整十数";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "以内";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "生成习题";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "四则运算习题生成器";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Label labelDivide;
        private System.Windows.Forms.NumericUpDown numericUpDownAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownDivide;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiply;
        private System.Windows.Forms.NumericUpDown numericUpDownMinus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button buttonEvenDistribute;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

