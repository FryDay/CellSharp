﻿namespace CellSharp
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
            this.pix_Grid = new System.Windows.Forms.PictureBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Iterations = new System.Windows.Forms.NumericUpDown();
            this.lbl_Iterations = new System.Windows.Forms.Label();
            this.chk_DrawGrid = new System.Windows.Forms.CheckBox();
            this.sldr_Speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BirthMin = new System.Windows.Forms.NumericUpDown();
            this.txt_BirthMax = new System.Windows.Forms.NumericUpDown();
            this.txt_SurvivalMin = new System.Windows.Forms.NumericUpDown();
            this.txt_SurvivalMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_IncludeSelf = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pix_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldr_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BirthMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BirthMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SurvivalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SurvivalMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pix_Grid
            // 
            this.pix_Grid.Location = new System.Drawing.Point(12, 12);
            this.pix_Grid.Name = "pix_Grid";
            this.pix_Grid.Size = new System.Drawing.Size(551, 551);
            this.pix_Grid.TabIndex = 0;
            this.pix_Grid.TabStop = false;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(488, 569);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(407, 569);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // txt_Iterations
            // 
            this.txt_Iterations.Location = new System.Drawing.Point(508, 598);
            this.txt_Iterations.Name = "txt_Iterations";
            this.txt_Iterations.Size = new System.Drawing.Size(55, 20);
            this.txt_Iterations.TabIndex = 3;
            // 
            // lbl_Iterations
            // 
            this.lbl_Iterations.AutoSize = true;
            this.lbl_Iterations.Location = new System.Drawing.Point(394, 600);
            this.lbl_Iterations.Name = "lbl_Iterations";
            this.lbl_Iterations.Size = new System.Drawing.Size(108, 13);
            this.lbl_Iterations.TabIndex = 4;
            this.lbl_Iterations.Text = "Iterations (0 = Infinite)";
            // 
            // chk_DrawGrid
            // 
            this.chk_DrawGrid.AutoSize = true;
            this.chk_DrawGrid.Checked = true;
            this.chk_DrawGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_DrawGrid.Location = new System.Drawing.Point(484, 624);
            this.chk_DrawGrid.Name = "chk_DrawGrid";
            this.chk_DrawGrid.Size = new System.Drawing.Size(79, 17);
            this.chk_DrawGrid.TabIndex = 5;
            this.chk_DrawGrid.Text = "Draw Grid?";
            this.chk_DrawGrid.UseVisualStyleBackColor = true;
            // 
            // sldr_Speed
            // 
            this.sldr_Speed.LargeChange = 1;
            this.sldr_Speed.Location = new System.Drawing.Point(259, 598);
            this.sldr_Speed.Maximum = 2;
            this.sldr_Speed.Name = "sldr_Speed";
            this.sldr_Speed.Size = new System.Drawing.Size(104, 45);
            this.sldr_Speed.TabIndex = 6;
            this.sldr_Speed.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Slow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birth Range:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Survivial Range:";
            // 
            // txt_BirthMin
            // 
            this.txt_BirthMin.Location = new System.Drawing.Point(110, 577);
            this.txt_BirthMin.Name = "txt_BirthMin";
            this.txt_BirthMin.Size = new System.Drawing.Size(40, 20);
            this.txt_BirthMin.TabIndex = 12;
            this.txt_BirthMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txt_BirthMax
            // 
            this.txt_BirthMax.Location = new System.Drawing.Point(178, 577);
            this.txt_BirthMax.Name = "txt_BirthMax";
            this.txt_BirthMax.Size = new System.Drawing.Size(40, 20);
            this.txt_BirthMax.TabIndex = 13;
            this.txt_BirthMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txt_SurvivalMin
            // 
            this.txt_SurvivalMin.Location = new System.Drawing.Point(110, 603);
            this.txt_SurvivalMin.Name = "txt_SurvivalMin";
            this.txt_SurvivalMin.Size = new System.Drawing.Size(40, 20);
            this.txt_SurvivalMin.TabIndex = 14;
            this.txt_SurvivalMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_SurvivalMax
            // 
            this.txt_SurvivalMax.Location = new System.Drawing.Point(178, 603);
            this.txt_SurvivalMax.Name = "txt_SurvivalMax";
            this.txt_SurvivalMax.Size = new System.Drawing.Size(40, 20);
            this.txt_SurvivalMax.TabIndex = 15;
            this.txt_SurvivalMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "->";
            // 
            // chk_IncludeSelf
            // 
            this.chk_IncludeSelf.AutoSize = true;
            this.chk_IncludeSelf.Location = new System.Drawing.Point(110, 636);
            this.chk_IncludeSelf.Name = "chk_IncludeSelf";
            this.chk_IncludeSelf.Size = new System.Drawing.Size(88, 17);
            this.chk_IncludeSelf.TabIndex = 18;
            this.chk_IncludeSelf.Text = "Include Self?";
            this.chk_IncludeSelf.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 125;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 655);
            this.Controls.Add(this.chk_IncludeSelf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SurvivalMax);
            this.Controls.Add(this.txt_SurvivalMin);
            this.Controls.Add(this.txt_BirthMax);
            this.Controls.Add(this.txt_BirthMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sldr_Speed);
            this.Controls.Add(this.chk_DrawGrid);
            this.Controls.Add(this.lbl_Iterations);
            this.Controls.Add(this.txt_Iterations);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.pix_Grid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pix_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldr_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BirthMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BirthMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SurvivalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SurvivalMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pix_Grid;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.NumericUpDown txt_Iterations;
        private System.Windows.Forms.Label lbl_Iterations;
        private System.Windows.Forms.CheckBox chk_DrawGrid;
        private System.Windows.Forms.TrackBar sldr_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_BirthMin;
        private System.Windows.Forms.NumericUpDown txt_BirthMax;
        private System.Windows.Forms.NumericUpDown txt_SurvivalMin;
        private System.Windows.Forms.NumericUpDown txt_SurvivalMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_IncludeSelf;
        private System.Windows.Forms.Timer timer;
    }
}

