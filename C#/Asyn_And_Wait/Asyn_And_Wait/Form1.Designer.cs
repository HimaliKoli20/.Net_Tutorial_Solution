namespace Asyn_And_Wait
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
            this.btnProcessFIle = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessFIle
            // 
            this.btnProcessFIle.Location = new System.Drawing.Point(362, 99);
            this.btnProcessFIle.Name = "btnProcessFIle";
            this.btnProcessFIle.Size = new System.Drawing.Size(75, 23);
            this.btnProcessFIle.TabIndex = 0;
            this.btnProcessFIle.Text = "Process File";
            this.btnProcessFIle.UseVisualStyleBackColor = true;
            this.btnProcessFIle.Click += new System.EventHandler(this.btnProcessFIle_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(359, 148);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessFIle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFIle;
        private System.Windows.Forms.Label lblCount;
    }
}

