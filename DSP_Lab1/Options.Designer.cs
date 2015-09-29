namespace DSP_Lab1
{
    partial class Options
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
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.nudPeriodDel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPhaseShift = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmplitude = new System.Windows.Forms.NumericUpDown();
            this.nonStatMeanFunc = new System.Windows.Forms.RadioButton();
            this.harmonicSumFunc = new System.Windows.Forms.RadioButton();
            this.statMeandrFunc = new System.Windows.Forms.RadioButton();
            this.harmonicFunc = new System.Windows.Forms.RadioButton();
            this.gbNoise = new System.Windows.Forms.GroupBox();
            this.nudSnrIn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.whiteNoise = new System.Windows.Forms.RadioButton();
            this.rbSaveSignal = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhaseShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).BeginInit();
            this.gbNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnrIn)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.nudPeriodDel);
            this.gbFunction.Controls.Add(this.label3);
            this.gbFunction.Controls.Add(this.label2);
            this.gbFunction.Controls.Add(this.nudPhaseShift);
            this.gbFunction.Controls.Add(this.label1);
            this.gbFunction.Controls.Add(this.nudAmplitude);
            this.gbFunction.Controls.Add(this.nonStatMeanFunc);
            this.gbFunction.Controls.Add(this.harmonicSumFunc);
            this.gbFunction.Controls.Add(this.statMeandrFunc);
            this.gbFunction.Controls.Add(this.harmonicFunc);
            this.gbFunction.Location = new System.Drawing.Point(12, 12);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(309, 153);
            this.gbFunction.TabIndex = 0;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Функция";
            // 
            // nudPeriodDel
            // 
            this.nudPeriodDel.DecimalPlaces = 2;
            this.nudPeriodDel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPeriodDel.Location = new System.Drawing.Point(225, 116);
            this.nudPeriodDel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPeriodDel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPeriodDel.Name = "nudPeriodDel";
            this.nudPeriodDel.Size = new System.Drawing.Size(52, 20);
            this.nudPeriodDel.TabIndex = 10;
            this.nudPeriodDel.Tag = "";
            this.nudPeriodDel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "d=";
            // 
            // nudPhaseShift
            // 
            this.nudPhaseShift.DecimalPlaces = 1;
            this.nudPhaseShift.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPhaseShift.Location = new System.Drawing.Point(126, 116);
            this.nudPhaseShift.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPhaseShift.Name = "nudPhaseShift";
            this.nudPhaseShift.Size = new System.Drawing.Size(52, 20);
            this.nudPhaseShift.TabIndex = 6;
            this.nudPhaseShift.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A=";
            // 
            // nudAmplitude
            // 
            this.nudAmplitude.DecimalPlaces = 1;
            this.nudAmplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAmplitude.Location = new System.Drawing.Point(32, 116);
            this.nudAmplitude.Name = "nudAmplitude";
            this.nudAmplitude.Size = new System.Drawing.Size(52, 20);
            this.nudAmplitude.TabIndex = 4;
            this.nudAmplitude.Tag = "";
            this.nudAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nonStatMeanFunc
            // 
            this.nonStatMeanFunc.AutoSize = true;
            this.nonStatMeanFunc.Location = new System.Drawing.Point(7, 92);
            this.nonStatMeanFunc.Name = "nonStatMeanFunc";
            this.nonStatMeanFunc.Size = new System.Drawing.Size(249, 17);
            this.nonStatMeanFunc.TabIndex = 3;
            this.nonStatMeanFunc.Text = "Нестационарный меандр со скважностью 2";
            this.nonStatMeanFunc.UseVisualStyleBackColor = true;
            // 
            // harmonicSumFunc
            // 
            this.harmonicSumFunc.AutoSize = true;
            this.harmonicSumFunc.Location = new System.Drawing.Point(7, 68);
            this.harmonicSumFunc.Name = "harmonicSumFunc";
            this.harmonicSumFunc.Size = new System.Drawing.Size(214, 17);
            this.harmonicSumFunc.TabIndex = 2;
            this.harmonicSumFunc.Text = "Сумма двух гармонических сигналов";
            this.harmonicSumFunc.UseVisualStyleBackColor = true;
            // 
            // statMeandrFunc
            // 
            this.statMeandrFunc.AutoSize = true;
            this.statMeandrFunc.Location = new System.Drawing.Point(7, 44);
            this.statMeandrFunc.Name = "statMeandrFunc";
            this.statMeandrFunc.Size = new System.Drawing.Size(140, 17);
            this.statMeandrFunc.TabIndex = 1;
            this.statMeandrFunc.Text = "Стационарный меандр";
            this.statMeandrFunc.UseVisualStyleBackColor = true;
            // 
            // harmonicFunc
            // 
            this.harmonicFunc.AutoSize = true;
            this.harmonicFunc.Checked = true;
            this.harmonicFunc.Location = new System.Drawing.Point(7, 20);
            this.harmonicFunc.Name = "harmonicFunc";
            this.harmonicFunc.Size = new System.Drawing.Size(239, 17);
            this.harmonicFunc.TabIndex = 0;
            this.harmonicFunc.TabStop = true;
            this.harmonicFunc.Text = "Гармонический сигнал вида A*sin(2п/N+d)";
            this.harmonicFunc.UseVisualStyleBackColor = true;
            // 
            // gbNoise
            // 
            this.gbNoise.Controls.Add(this.nudSnrIn);
            this.gbNoise.Controls.Add(this.label4);
            this.gbNoise.Controls.Add(this.whiteNoise);
            this.gbNoise.Location = new System.Drawing.Point(327, 12);
            this.gbNoise.Name = "gbNoise";
            this.gbNoise.Size = new System.Drawing.Size(200, 100);
            this.gbNoise.TabIndex = 1;
            this.gbNoise.TabStop = false;
            this.gbNoise.Text = "Помеха";
            // 
            // nudSnrIn
            // 
            this.nudSnrIn.DecimalPlaces = 2;
            this.nudSnrIn.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSnrIn.Location = new System.Drawing.Point(66, 42);
            this.nudSnrIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSnrIn.Name = "nudSnrIn";
            this.nudSnrIn.Size = new System.Drawing.Size(120, 20);
            this.nudSnrIn.TabIndex = 2;
            this.nudSnrIn.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SNR in = ";
            // 
            // whiteNoise
            // 
            this.whiteNoise.AutoSize = true;
            this.whiteNoise.Checked = true;
            this.whiteNoise.Location = new System.Drawing.Point(7, 20);
            this.whiteNoise.Name = "whiteNoise";
            this.whiteNoise.Size = new System.Drawing.Size(92, 17);
            this.whiteNoise.TabIndex = 0;
            this.whiteNoise.TabStop = true;
            this.whiteNoise.Text = "\"Белый\" шум";
            this.whiteNoise.UseVisualStyleBackColor = true;
            // 
            // rbSaveSignal
            // 
            this.rbSaveSignal.AutoSize = true;
            this.rbSaveSignal.Location = new System.Drawing.Point(337, 126);
            this.rbSaveSignal.Name = "rbSaveSignal";
            this.rbSaveSignal.Size = new System.Drawing.Size(160, 17);
            this.rbSaveSignal.TabIndex = 2;
            this.rbSaveSignal.Text = "Сохранять входной сигнал";
            this.rbSaveSignal.UseVisualStyleBackColor = true;
            this.rbSaveSignal.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(455, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbSaveSignal);
            this.Controls.Add(this.gbNoise);
            this.Controls.Add(this.gbFunction);
            this.MaximumSize = new System.Drawing.Size(558, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 262);
            this.Name = "Options";
            this.Text = "Настройки";
            this.gbFunction.ResumeLayout(false);
            this.gbFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhaseShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).EndInit();
            this.gbNoise.ResumeLayout(false);
            this.gbNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnrIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPhaseShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmplitude;
        private System.Windows.Forms.RadioButton nonStatMeanFunc;
        private System.Windows.Forms.RadioButton harmonicSumFunc;
        private System.Windows.Forms.RadioButton statMeandrFunc;
        private System.Windows.Forms.RadioButton harmonicFunc;
        private System.Windows.Forms.GroupBox gbNoise;
        private System.Windows.Forms.NumericUpDown nudSnrIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton whiteNoise;
        private System.Windows.Forms.RadioButton rbSaveSignal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudPeriodDel;
    }
}