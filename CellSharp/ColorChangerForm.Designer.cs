namespace CellSharp
{
    partial class ColorChangerForm
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
            this.GridColorDialog = new System.Windows.Forms.ColorDialog();
            this.CellColorDialog = new System.Windows.Forms.ColorDialog();
            this.BackColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GridColor = new System.Windows.Forms.Button();
            this.btn_CellsColor = new System.Windows.Forms.Button();
            this.btn_BackColor = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridColorDialog
            // 
            this.GridColorDialog.AnyColor = true;
            this.GridColorDialog.FullOpen = true;
            // 
            // CellColorDialog
            // 
            this.CellColorDialog.AnyColor = true;
            this.CellColorDialog.FullOpen = true;
            // 
            // BackColorDialog
            // 
            this.BackColorDialog.AnyColor = true;
            this.BackColorDialog.Color = System.Drawing.Color.White;
            this.BackColorDialog.FullOpen = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_BackColor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_CellsColor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_GridColor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Accept, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 116);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cells";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Grid";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Background";
            // 
            // btn_GridColor
            // 
            this.btn_GridColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GridColor.BackColor = System.Drawing.Color.Black;
            this.btn_GridColor.FlatAppearance.BorderSize = 0;
            this.btn_GridColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GridColor.Location = new System.Drawing.Point(84, 3);
            this.btn_GridColor.Name = "btn_GridColor";
            this.btn_GridColor.Size = new System.Drawing.Size(75, 23);
            this.btn_GridColor.TabIndex = 21;
            this.btn_GridColor.UseVisualStyleBackColor = false;
            this.btn_GridColor.Click += new System.EventHandler(this.btn_GridColor_Click);
            // 
            // btn_CellsColor
            // 
            this.btn_CellsColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CellsColor.BackColor = System.Drawing.Color.Black;
            this.btn_CellsColor.FlatAppearance.BorderSize = 0;
            this.btn_CellsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CellsColor.Location = new System.Drawing.Point(84, 32);
            this.btn_CellsColor.Name = "btn_CellsColor";
            this.btn_CellsColor.Size = new System.Drawing.Size(75, 23);
            this.btn_CellsColor.TabIndex = 22;
            this.btn_CellsColor.UseVisualStyleBackColor = false;
            this.btn_CellsColor.Click += new System.EventHandler(this.btn_CellsColor_Click);
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BackColor.BackColor = System.Drawing.Color.White;
            this.btn_BackColor.FlatAppearance.BorderSize = 0;
            this.btn_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackColor.Location = new System.Drawing.Point(84, 61);
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(75, 23);
            this.btn_BackColor.TabIndex = 23;
            this.btn_BackColor.UseVisualStyleBackColor = false;
            this.btn_BackColor.Click += new System.EventHandler(this.btn_BackColor_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Accept.Location = new System.Drawing.Point(3, 90);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 24;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(84, 90);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // ColorChangerForm
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(188, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChangerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog GridColorDialog;
        private System.Windows.Forms.ColorDialog CellColorDialog;
        private System.Windows.Forms.ColorDialog BackColorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_BackColor;
        private System.Windows.Forms.Button btn_CellsColor;
        private System.Windows.Forms.Button btn_GridColor;
        private System.Windows.Forms.Button btn_Accept;
    }
}