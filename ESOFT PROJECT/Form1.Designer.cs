namespace ESOFT_PROJECT
{
    partial class frmmanagement
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
            this.btnstade_P = new System.Windows.Forms.Button();
            this.btnstade_O = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstade_P
            // 
            this.btnstade_P.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstade_P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstade_P.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstade_P.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstade_P.Location = new System.Drawing.Point(399, 30);
            this.btnstade_P.Margin = new System.Windows.Forms.Padding(4);
            this.btnstade_P.Name = "btnstade_P";
            this.btnstade_P.Size = new System.Drawing.Size(181, 102);
            this.btnstade_P.TabIndex = 0;
            this.btnstade_P.Text = "Staff Personal Details";
            this.btnstade_P.UseVisualStyleBackColor = false;
            this.btnstade_P.Click += new System.EventHandler(this.btnstade_P_Click);
            // 
            // btnstade_O
            // 
            this.btnstade_O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstade_O.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstade_O.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstade_O.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstade_O.Location = new System.Drawing.Point(399, 160);
            this.btnstade_O.Name = "btnstade_O";
            this.btnstade_O.Size = new System.Drawing.Size(181, 102);
            this.btnstade_O.TabIndex = 1;
            this.btnstade_O.Text = "Staff Salary Details";
            this.btnstade_O.UseVisualStyleBackColor = false;
            this.btnstade_O.Click += new System.EventHandler(this.btnstade_O_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(399, 279);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(181, 102);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ESOFT_PROJECT.Properties.Resources.images__22_new;
            this.pictureBox1.Location = new System.Drawing.Point(3, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(41, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 425);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 115);
            this.label5.TabIndex = 11;
            this.label5.Text = " Bettans Group of Companies(PVT) Ltd,\r\n                  Yatinuwara Veediya,\r\n   " +
                "                        Kandy.\r\n     Tel:  0812347865/0812378667\r\n              " +
                " Email:info@bettans.lk";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ESOFT_PROJECT.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(54, 79);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 103);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(668, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnstade_O);
            this.Controls.Add(this.btnstade_P);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmmanagement";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstade_P;
        private System.Windows.Forms.Button btnstade_O;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}