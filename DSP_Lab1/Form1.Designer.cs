namespace DSP_Lab1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panlnputSignal = new System.Windows.Forms.Panel();
            this.panFilteredSignal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudIterationsCount = new System.Windows.Forms.NumericUpDown();
            this.lbSnrOut = new System.Windows.Forms.Label();
            this.filterTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterationsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panlnputSignal
            // 
            this.panlnputSignal.Location = new System.Drawing.Point(12, 25);
            this.panlnputSignal.Name = "panlnputSignal";
            this.panlnputSignal.Size = new System.Drawing.Size(314, 127);
            this.panlnputSignal.TabIndex = 0;
            // 
            // panFilteredSignal
            // 
            this.panFilteredSignal.Location = new System.Drawing.Point(12, 183);
            this.panFilteredSignal.Name = "panFilteredSignal";
            this.panFilteredSignal.Size = new System.Drawing.Size(314, 127);
            this.panFilteredSignal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число тактов накопления М = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SNR out =";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(524, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(524, 144);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Text = "Настройки";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(524, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudIterationsCount
            // 
            this.nudIterationsCount.Location = new System.Drawing.Point(501, 23);
            this.nudIterationsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIterationsCount.Name = "nudIterationsCount";
            this.nudIterationsCount.Size = new System.Drawing.Size(67, 20);
            this.nudIterationsCount.TabIndex = 8;
            this.nudIterationsCount.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lbSnrOut
            // 
            this.lbSnrOut.AutoSize = true;
            this.lbSnrOut.Location = new System.Drawing.Point(395, 47);
            this.lbSnrOut.Name = "lbSnrOut";
            this.lbSnrOut.Size = new System.Drawing.Size(35, 13);
            this.lbSnrOut.TabIndex = 9;
            this.lbSnrOut.Text = "label4";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(524, 115);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Исходный сигнал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сигнал после фильтрации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbSnrOut);
            this.Controls.Add(this.nudIterationsCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panFilteredSignal);
            this.Controls.Add(this.panlnputSignal);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(627, 361);
            this.MinimumSize = new System.Drawing.Size(627, 361);
            this.Name = "Form1";
            this.Text = "Лабораторная работа  №1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIterationsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panlnputSignal;
        private System.Windows.Forms.Panel panFilteredSignal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudIterationsCount;
        private System.Windows.Forms.Label lbSnrOut;
        private System.Windows.Forms.Timer filterTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

