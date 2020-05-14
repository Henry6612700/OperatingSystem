/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 04/05/2020
 * Time: 08.39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CPU
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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.tblog = new System.Windows.Forms.RichTextBox();
        	this.qC = new System.Windows.Forms.RichTextBox();
        	this.btnclock = new System.Windows.Forms.Button();
        	this.load = new System.Windows.Forms.Button();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.qCTextBox = new System.Windows.Forms.RichTextBox();
        	this.browse = new System.Windows.Forms.Button();
        	this.tampilanfile = new System.Windows.Forms.RichTextBox();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.qBTextBox = new System.Windows.Forms.RichTextBox();
        	this.qB = new System.Windows.Forms.RichTextBox();
        	this.qATextBox = new System.Windows.Forms.RichTextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.qA = new System.Windows.Forms.RichTextBox();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.panel1.SuspendLayout();
        	this.panel3.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Controls.Add(this.panel3);
        	this.panel1.Location = new System.Drawing.Point(12, 12);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(913, 570);
        	this.panel1.TabIndex = 0;
        	this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
        	this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(194, 10);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(533, 31);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Simulasi Penjadwalan Dalam Sistem Operasi";
        	// 
        	// panel3
        	// 
        	this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
        	this.panel3.Controls.Add(this.tblog);
        	this.panel3.Controls.Add(this.qC);
        	this.panel3.Controls.Add(this.btnclock);
        	this.panel3.Controls.Add(this.load);
        	this.panel3.Controls.Add(this.textBox2);
        	this.panel3.Controls.Add(this.label2);
        	this.panel3.Controls.Add(this.qCTextBox);
        	this.panel3.Controls.Add(this.browse);
        	this.panel3.Controls.Add(this.tampilanfile);
        	this.panel3.Controls.Add(this.textBox1);
        	this.panel3.Controls.Add(this.label5);
        	this.panel3.Controls.Add(this.label3);
        	this.panel3.Controls.Add(this.label7);
        	this.panel3.Controls.Add(this.qBTextBox);
        	this.panel3.Controls.Add(this.qB);
        	this.panel3.Controls.Add(this.qATextBox);
        	this.panel3.Controls.Add(this.label4);
        	this.panel3.Controls.Add(this.qA);
        	this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.panel3.Location = new System.Drawing.Point(12, 44);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(878, 513);
        	this.panel3.TabIndex = 8;
        	// 
        	// tblog
        	// 
        	this.tblog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tblog.Location = new System.Drawing.Point(276, 308);
        	this.tblog.Name = "tblog";
        	this.tblog.ReadOnly = true;
        	this.tblog.Size = new System.Drawing.Size(586, 100);
        	this.tblog.TabIndex = 9;
        	this.tblog.Text = "";
        	// 
        	// qC
        	// 
        	this.qC.BackColor = System.Drawing.SystemColors.Window;
        	this.qC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qC.Location = new System.Drawing.Point(616, 53);
        	this.qC.Name = "qC";
        	this.qC.ReadOnly = true;
        	this.qC.Size = new System.Drawing.Size(246, 249);
        	this.qC.TabIndex = 12;
        	this.qC.Text = "";
        	// 
        	// btnclock
        	// 
        	this.btnclock.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnclock.Location = new System.Drawing.Point(421, 455);
        	this.btnclock.Name = "btnclock";
        	this.btnclock.Size = new System.Drawing.Size(88, 41);
        	this.btnclock.TabIndex = 0;
        	this.btnclock.Text = "Clock";
        	this.btnclock.UseVisualStyleBackColor = true;
        	this.btnclock.Click += new System.EventHandler(this.btnclock_Click);
        	// 
        	// load
        	// 
        	this.load.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.load.Location = new System.Drawing.Point(324, 455);
        	this.load.Name = "load";
        	this.load.Size = new System.Drawing.Size(75, 41);
        	this.load.TabIndex = 7;
        	this.load.Text = "load";
        	this.load.UseVisualStyleBackColor = true;
        	this.load.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// textBox2
        	// 
        	this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox2.Location = new System.Drawing.Point(529, 427);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.ReadOnly = true;
        	this.textBox2.Size = new System.Drawing.Size(52, 38);
        	this.textBox2.TabIndex = 1;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(421, 432);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(102, 17);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "CLOCK TIME  :";
        	// 
        	// qCTextBox
        	// 
        	this.qCTextBox.BackColor = System.Drawing.SystemColors.Window;
        	this.qCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qCTextBox.Location = new System.Drawing.Point(616, 23);
        	this.qCTextBox.Name = "qCTextBox";
        	this.qCTextBox.ReadOnly = true;
        	this.qCTextBox.Size = new System.Drawing.Size(246, 28);
        	this.qCTextBox.TabIndex = 13;
        	this.qCTextBox.Text = "";
        	// 
        	// browse
        	// 
        	this.browse.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.browse.Location = new System.Drawing.Point(243, 455);
        	this.browse.Name = "browse";
        	this.browse.Size = new System.Drawing.Size(75, 41);
        	this.browse.TabIndex = 4;
        	this.browse.Text = "Browse File";
        	this.browse.UseVisualStyleBackColor = true;
        	this.browse.Click += new System.EventHandler(this.BrowseClick);
        	// 
        	// tampilanfile
        	// 
        	this.tampilanfile.Location = new System.Drawing.Point(18, 308);
        	this.tampilanfile.Name = "tampilanfile";
        	this.tampilanfile.ReadOnly = true;
        	this.tampilanfile.Size = new System.Drawing.Size(194, 188);
        	this.tampilanfile.TabIndex = 6;
        	this.tampilanfile.Text = "";
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        	this.textBox1.Location = new System.Drawing.Point(245, 427);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.ReadOnly = true;
        	this.textBox1.Size = new System.Drawing.Size(154, 22);
        	this.textBox1.TabIndex = 3;
        	// 
        	// label5
        	// 
        	this.label5.BackColor = System.Drawing.SystemColors.Window;
        	this.label5.Location = new System.Drawing.Point(237, 313);
        	this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(34, 18);
        	this.label5.TabIndex = 15;
        	this.label5.Text = "Log";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.BackColor = System.Drawing.Color.Gainsboro;
        	this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(20, 6);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(72, 19);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "QUEUE A";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.BackColor = System.Drawing.Color.Gainsboro;
        	this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.Location = new System.Drawing.Point(618, 8);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(70, 19);
        	this.label7.TabIndex = 3;
        	this.label7.Text = "QUEUE C";
        	// 
        	// qBTextBox
        	// 
        	this.qBTextBox.BackColor = System.Drawing.SystemColors.Window;
        	this.qBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qBTextBox.Location = new System.Drawing.Point(309, 23);
        	this.qBTextBox.Name = "qBTextBox";
        	this.qBTextBox.ReadOnly = true;
        	this.qBTextBox.Size = new System.Drawing.Size(272, 28);
        	this.qBTextBox.TabIndex = 8;
        	this.qBTextBox.Text = "";
        	// 
        	// qB
        	// 
        	this.qB.BackColor = System.Drawing.SystemColors.Window;
        	this.qB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qB.Location = new System.Drawing.Point(309, 52);
        	this.qB.Name = "qB";
        	this.qB.ReadOnly = true;
        	this.qB.Size = new System.Drawing.Size(272, 250);
        	this.qB.TabIndex = 12;
        	this.qB.Text = "";
        	// 
        	// qATextBox
        	// 
        	this.qATextBox.BackColor = System.Drawing.SystemColors.Window;
        	this.qATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qATextBox.Location = new System.Drawing.Point(18, 23);
        	this.qATextBox.Name = "qATextBox";
        	this.qATextBox.ReadOnly = true;
        	this.qATextBox.Size = new System.Drawing.Size(260, 28);
        	this.qATextBox.TabIndex = 7;
        	this.qATextBox.Text = "";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.BackColor = System.Drawing.Color.Gainsboro;
        	this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(312, 8);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(70, 19);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "QUEUE B";
        	// 
        	// qA
        	// 
        	this.qA.BackColor = System.Drawing.SystemColors.Window;
        	this.qA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.qA.Location = new System.Drawing.Point(18, 52);
        	this.qA.Name = "qA";
        	this.qA.ReadOnly = true;
        	this.qA.Size = new System.Drawing.Size(260, 250);
        	this.qA.TabIndex = 6;
        	this.qA.Text = "";
        	// 
        	// openFileDialog1
        	// 
        	this.openFileDialog1.FileName = "openFileDialog1";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(938, 594);
        	this.Controls.Add(this.panel1);
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.Load += new System.EventHandler(this.Form1Load);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel3.ResumeLayout(false);
        	this.panel3.PerformLayout();
        	this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.RichTextBox qATextBox;
        private System.Windows.Forms.RichTextBox qBTextBox;
        private System.Windows.Forms.RichTextBox qB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox qCTextBox;
        private System.Windows.Forms.RichTextBox qC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.RichTextBox tampilanfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tblog;
        private System.Windows.Forms.RichTextBox qA;
        private System.Windows.Forms.Label label1;
    }
}
