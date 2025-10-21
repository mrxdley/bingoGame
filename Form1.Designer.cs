namespace Bingo
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
            this.pastNumberList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.curNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawBut = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Papyrus", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "B  I  N  G  O";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pastNumberList
            // 
            this.pastNumberList.FormattingEnabled = true;
            this.pastNumberList.Location = new System.Drawing.Point(560, 56);
            this.pastNumberList.Name = "pastNumberList";
            this.pastNumberList.Size = new System.Drawing.Size(120, 407);
            this.pastNumberList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(582, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Past Numbers";
            // 
            // curNum
            // 
            this.curNum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.curNum.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.curNum.Location = new System.Drawing.Point(419, 144);
            this.curNum.Name = "curNum";
            this.curNum.Size = new System.Drawing.Size(135, 149);
            this.curNum.TabIndex = 3;
            this.curNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(445, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Number";
            // 
            // drawBut
            // 
            this.drawBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawBut.Location = new System.Drawing.Point(439, 56);
            this.drawBut.Name = "drawBut";
            this.drawBut.Size = new System.Drawing.Size(89, 46);
            this.drawBut.TabIndex = 5;
            this.drawBut.Text = "DRAW";
            this.drawBut.UseVisualStyleBackColor = true;
            this.drawBut.Click += new System.EventHandler(this.drawBut_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(437, 429);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 30);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.drawBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.curNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pastNumberList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pastNumberList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label curNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button drawBut;
        private System.Windows.Forms.Button resetBtn;
    }
}

