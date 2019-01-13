using System;

namespace Algorytmy_graficzne
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_RysujOdcinek = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_RysujOdcinek
            // 
            this.BTN_RysujOdcinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_RysujOdcinek.Location = new System.Drawing.Point(667, 12);
            this.BTN_RysujOdcinek.Name = "BTN_RysujOdcinek";
            this.BTN_RysujOdcinek.Size = new System.Drawing.Size(126, 45);
            this.BTN_RysujOdcinek.TabIndex = 1;
            this.BTN_RysujOdcinek.Text = "Rysuj odcinek";
            this.BTN_RysujOdcinek.UseVisualStyleBackColor = true;
            this.BTN_RysujOdcinek.Click += new System.EventHandler(this.BTN_RysujOdcinek_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(333, 12);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 2;
            this.TB1.Text = "20;20";
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(492, 12);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 20);
            this.TB2.TabIndex = 3;
            this.TB2.Text = "150;108";
            this.TB2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "P0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "P1=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BTN_RysujOdcinek);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_RysujOdcinek;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

