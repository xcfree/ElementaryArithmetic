namespace ElementaryArithmetic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelMinus = new System.Windows.Forms.Label();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.labelDivide = new System.Windows.Forms.Label();
            this.numericUpDownAddPercentage = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEvenDistribute = new System.Windows.Forms.Button();
            this.numericUpDownDividePercentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMultiplyPercentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinusPercentage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownExVolume = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownFillInBlankPercentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxFactor = new System.Windows.Forms.NumericUpDown();
            this.buttonGenExercise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDividePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinusPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFillInBlankPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(15, 27);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(17, 12);
            this.labelAdd.TabIndex = 2;
            this.labelAdd.Text = "加";
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Location = new System.Drawing.Point(15, 55);
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
            this.labelDivide.Location = new System.Drawing.Point(15, 111);
            this.labelDivide.Name = "labelDivide";
            this.labelDivide.Size = new System.Drawing.Size(17, 12);
            this.labelDivide.TabIndex = 5;
            this.labelDivide.Text = "除";
            // 
            // numericUpDownAddPercentage
            // 
            this.numericUpDownAddPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAddPercentage.Location = new System.Drawing.Point(50, 23);
            this.numericUpDownAddPercentage.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownAddPercentage.Name = "numericUpDownAddPercentage";
            this.numericUpDownAddPercentage.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownAddPercentage.TabIndex = 6;
            this.numericUpDownAddPercentage.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownAddPercentage.ValueChanged += new System.EventHandler(this.numericUpDownAdd_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEvenDistribute);
            this.groupBox1.Controls.Add(this.numericUpDownDividePercentage);
            this.groupBox1.Controls.Add(this.numericUpDownMultiplyPercentage);
            this.groupBox1.Controls.Add(this.numericUpDownMinusPercentage);
            this.groupBox1.Controls.Add(this.labelAdd);
            this.groupBox1.Controls.Add(this.labelMinus);
            this.groupBox1.Controls.Add(this.labelMultiply);
            this.groupBox1.Controls.Add(this.numericUpDownAddPercentage);
            this.groupBox1.Controls.Add(this.labelDivide);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "题型分布（%）";
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
            // numericUpDownDividePercentage
            // 
            this.numericUpDownDividePercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDividePercentage.Location = new System.Drawing.Point(50, 107);
            this.numericUpDownDividePercentage.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownDividePercentage.Name = "numericUpDownDividePercentage";
            this.numericUpDownDividePercentage.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownDividePercentage.TabIndex = 9;
            this.numericUpDownDividePercentage.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownDividePercentage.ValueChanged += new System.EventHandler(this.numericUpDownDivide_ValueChanged);
            // 
            // numericUpDownMultiplyPercentage
            // 
            this.numericUpDownMultiplyPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMultiplyPercentage.Location = new System.Drawing.Point(50, 79);
            this.numericUpDownMultiplyPercentage.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMultiplyPercentage.Name = "numericUpDownMultiplyPercentage";
            this.numericUpDownMultiplyPercentage.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownMultiplyPercentage.TabIndex = 8;
            this.numericUpDownMultiplyPercentage.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMultiplyPercentage.ValueChanged += new System.EventHandler(this.numericUpDownMultiply_ValueChanged);
            // 
            // numericUpDownMinusPercentage
            // 
            this.numericUpDownMinusPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMinusPercentage.Location = new System.Drawing.Point(50, 51);
            this.numericUpDownMinusPercentage.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMinusPercentage.Name = "numericUpDownMinusPercentage";
            this.numericUpDownMinusPercentage.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownMinusPercentage.TabIndex = 7;
            this.numericUpDownMinusPercentage.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMinusPercentage.ValueChanged += new System.EventHandler(this.numericUpDownMinus_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "题量";
            // 
            // numericUpDownExVolume
            // 
            this.numericUpDownExVolume.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExVolume.Location = new System.Drawing.Point(247, 21);
            this.numericUpDownExVolume.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownExVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExVolume.Name = "numericUpDownExVolume";
            this.numericUpDownExVolume.Size = new System.Drawing.Size(53, 21);
            this.numericUpDownExVolume.TabIndex = 12;
            this.numericUpDownExVolume.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "填空占比（%）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "难度（以内）";
            // 
            // numericUpDownFillInBlankPercentage
            // 
            this.numericUpDownFillInBlankPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownFillInBlankPercentage.Location = new System.Drawing.Point(247, 49);
            this.numericUpDownFillInBlankPercentage.Name = "numericUpDownFillInBlankPercentage";
            this.numericUpDownFillInBlankPercentage.Size = new System.Drawing.Size(53, 21);
            this.numericUpDownFillInBlankPercentage.TabIndex = 15;
            this.numericUpDownFillInBlankPercentage.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownMaxFactor
            // 
            this.numericUpDownMaxFactor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxFactor.Location = new System.Drawing.Point(247, 77);
            this.numericUpDownMaxFactor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxFactor.Name = "numericUpDownMaxFactor";
            this.numericUpDownMaxFactor.Size = new System.Drawing.Size(53, 21);
            this.numericUpDownMaxFactor.TabIndex = 16;
            this.numericUpDownMaxFactor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonGenExercise
            // 
            this.buttonGenExercise.Location = new System.Drawing.Point(225, 146);
            this.buttonGenExercise.Name = "buttonGenExercise";
            this.buttonGenExercise.Size = new System.Drawing.Size(75, 23);
            this.buttonGenExercise.TabIndex = 22;
            this.buttonGenExercise.Text = "生成习题";
            this.buttonGenExercise.UseVisualStyleBackColor = true;
            this.buttonGenExercise.Click += new System.EventHandler(this.buttonGenExercise_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 194);
            this.Controls.Add(this.buttonGenExercise);
            this.Controls.Add(this.numericUpDownMaxFactor);
            this.Controls.Add(this.numericUpDownFillInBlankPercentage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownExVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钱氏口算";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDividePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiplyPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinusPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFillInBlankPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Label labelDivide;
        private System.Windows.Forms.NumericUpDown numericUpDownAddPercentage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownDividePercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiplyPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownMinusPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownExVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownFillInBlankPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxFactor;
        private System.Windows.Forms.Button buttonEvenDistribute;
        private System.Windows.Forms.Button buttonGenExercise;
    }
}

