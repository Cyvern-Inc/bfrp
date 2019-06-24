namespace Rename_Files
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.delCharsTB = new System.Windows.Forms.TextBox();
            this.delCharsCB = new System.Windows.Forms.CheckBox();
            this.resultTB1 = new System.Windows.Forms.TextBox();
            this.resultTB2 = new System.Windows.Forms.TextBox();
            this.addCharsCB = new System.Windows.Forms.CheckBox();
            this.addCharsTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endRB = new System.Windows.Forms.RadioButton();
            this.startRB = new System.Windows.Forms.RadioButton();
            this.executeBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Directory";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(581, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 524);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(581, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 31);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Log";
            // 
            // delCharsTB
            // 
            this.delCharsTB.Location = new System.Drawing.Point(27, 165);
            this.delCharsTB.Name = "delCharsTB";
            this.delCharsTB.Size = new System.Drawing.Size(534, 30);
            this.delCharsTB.TabIndex = 6;
            this.delCharsTB.Enter += new System.EventHandler(this.delCharsTB_Enter);
            // 
            // delCharsCB
            // 
            this.delCharsCB.AutoSize = true;
            this.delCharsCB.Location = new System.Drawing.Point(27, 110);
            this.delCharsCB.Name = "delCharsCB";
            this.delCharsCB.Size = new System.Drawing.Size(336, 29);
            this.delCharsCB.TabIndex = 7;
            this.delCharsCB.Text = "Delete characters from file name(s)";
            this.delCharsCB.UseVisualStyleBackColor = true;
            this.delCharsCB.CheckedChanged += new System.EventHandler(this.delCharsCB_CheckedChanged);
            // 
            // resultTB1
            // 
            this.resultTB1.Location = new System.Drawing.Point(27, 222);
            this.resultTB1.Name = "resultTB1";
            this.resultTB1.ReadOnly = true;
            this.resultTB1.Size = new System.Drawing.Size(534, 30);
            this.resultTB1.TabIndex = 8;
            // 
            // resultTB2
            // 
            this.resultTB2.Location = new System.Drawing.Point(27, 404);
            this.resultTB2.Name = "resultTB2";
            this.resultTB2.ReadOnly = true;
            this.resultTB2.Size = new System.Drawing.Size(534, 30);
            this.resultTB2.TabIndex = 11;
            // 
            // addCharsCB
            // 
            this.addCharsCB.AutoSize = true;
            this.addCharsCB.Location = new System.Drawing.Point(27, 292);
            this.addCharsCB.Name = "addCharsCB";
            this.addCharsCB.Size = new System.Drawing.Size(294, 29);
            this.addCharsCB.TabIndex = 10;
            this.addCharsCB.Text = "Add characters to file name(s)";
            this.addCharsCB.UseVisualStyleBackColor = true;
            this.addCharsCB.CheckedChanged += new System.EventHandler(this.addCharsCB_CheckedChanged);
            // 
            // addCharsTB
            // 
            this.addCharsTB.Location = new System.Drawing.Point(27, 347);
            this.addCharsTB.Name = "addCharsTB";
            this.addCharsTB.Size = new System.Drawing.Size(534, 30);
            this.addCharsTB.TabIndex = 9;
            this.addCharsTB.Enter += new System.EventHandler(this.addCharsTB_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add characters to the start or end of file name(s)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.endRB);
            this.groupBox1.Controls.Add(this.startRB);
            this.groupBox1.Location = new System.Drawing.Point(475, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // endRB
            // 
            this.endRB.AutoSize = true;
            this.endRB.Location = new System.Drawing.Point(6, 63);
            this.endRB.Name = "endRB";
            this.endRB.Size = new System.Drawing.Size(68, 29);
            this.endRB.TabIndex = 1;
            this.endRB.TabStop = true;
            this.endRB.Text = "End";
            this.endRB.UseVisualStyleBackColor = true;
            // 
            // startRB
            // 
            this.startRB.AutoSize = true;
            this.startRB.Location = new System.Drawing.Point(6, 24);
            this.startRB.Name = "startRB";
            this.startRB.Size = new System.Drawing.Size(74, 29);
            this.startRB.TabIndex = 0;
            this.startRB.TabStop = true;
            this.startRB.Text = "Start";
            this.startRB.UseVisualStyleBackColor = true;
            // 
            // executeBtn
            // 
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.executeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.executeBtn.Location = new System.Drawing.Point(47, 566);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(168, 44);
            this.executeBtn.TabIndex = 14;
            this.executeBtn.Text = "Execute Batch";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(237, 587);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(324, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressText.Location = new System.Drawing.Point(282, 564);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(223, 20);
            this.progressText.TabIndex = 16;
            this.progressText.Text = "Progress (0/0 files renamed)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(949, 627);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTB2);
            this.Controls.Add(this.addCharsCB);
            this.Controls.Add(this.addCharsTB);
            this.Controls.Add(this.resultTB1);
            this.Controls.Add(this.delCharsCB);
            this.Controls.Add(this.delCharsTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rename Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delCharsTB;
        private System.Windows.Forms.CheckBox delCharsCB;
        private System.Windows.Forms.TextBox resultTB1;
        private System.Windows.Forms.TextBox resultTB2;
        private System.Windows.Forms.CheckBox addCharsCB;
        private System.Windows.Forms.TextBox addCharsTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton endRB;
        private System.Windows.Forms.RadioButton startRB;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressText;
    }
}

