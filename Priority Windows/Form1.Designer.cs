namespace Priority_Windows
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BurstBox = new System.Windows.Forms.TextBox();
            this.ArrivalBox = new System.Windows.Forms.TextBox();
            this.PrioBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.resBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.TextBox();
            this.ResultFlow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burst Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority ";
            // 
            // BurstBox
            // 
            this.BurstBox.Location = new System.Drawing.Point(167, 152);
            this.BurstBox.Name = "BurstBox";
            this.BurstBox.Size = new System.Drawing.Size(133, 20);
            this.BurstBox.TabIndex = 2;
            // 
            // ArrivalBox
            // 
            this.ArrivalBox.Location = new System.Drawing.Point(167, 116);
            this.ArrivalBox.Name = "ArrivalBox";
            this.ArrivalBox.Size = new System.Drawing.Size(133, 20);
            this.ArrivalBox.TabIndex = 1;
            // 
            // PrioBox
            // 
            this.PrioBox.Location = new System.Drawing.Point(167, 185);
            this.PrioBox.Name = "PrioBox";
            this.PrioBox.Size = new System.Drawing.Size(133, 20);
            this.PrioBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(140, 221);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 35);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resBtn
            // 
            this.resBtn.BackColor = System.Drawing.Color.Gold;
            this.resBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBtn.Location = new System.Drawing.Point(248, 221);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(101, 35);
            this.resBtn.TabIndex = 7;
            this.resBtn.Text = "Show result";
            this.resBtn.UseVisualStyleBackColor = false;
            this.resBtn.Click += new System.EventHandler(this.resBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the processes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // Namee
            // 
            this.Namee.Location = new System.Drawing.Point(167, 75);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(133, 20);
            this.Namee.TabIndex = 0;
            this.Namee.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // ResultFlow
            // 
            this.ResultFlow.AutoSize = true;
            this.ResultFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ResultFlow.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultFlow.ForeColor = System.Drawing.Color.Navy;
            this.ResultFlow.Location = new System.Drawing.Point(12, 282);
            this.ResultFlow.Name = "ResultFlow";
            this.ResultFlow.Size = new System.Drawing.Size(158, 22);
            this.ResultFlow.TabIndex = 11;
            this.ResultFlow.Text = "Result will be here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(479, 344);
            this.Controls.Add(this.ResultFlow);
            this.Controls.Add(this.Namee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.PrioBox);
            this.Controls.Add(this.ArrivalBox);
            this.Controls.Add(this.BurstBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Priority Preemptive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BurstBox;
        private System.Windows.Forms.TextBox ArrivalBox;
        private System.Windows.Forms.TextBox PrioBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Namee;
        private System.Windows.Forms.Label ResultFlow;
    }
}

