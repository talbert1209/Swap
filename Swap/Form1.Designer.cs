namespace Swap
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
            this.Lloyd = new System.Windows.Forms.Button();
            this.Lucinda = new System.Windows.Forms.Button();
            this.Swap = new System.Windows.Forms.Button();
            this.Talk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lloyd
            // 
            this.Lloyd.Location = new System.Drawing.Point(26, 12);
            this.Lloyd.Name = "Lloyd";
            this.Lloyd.Size = new System.Drawing.Size(134, 39);
            this.Lloyd.TabIndex = 0;
            this.Lloyd.Text = "Lloyd";
            this.Lloyd.UseVisualStyleBackColor = true;
            this.Lloyd.Click += new System.EventHandler(this.Lloyd_Click);
            // 
            // Lucinda
            // 
            this.Lucinda.Location = new System.Drawing.Point(26, 61);
            this.Lucinda.Name = "Lucinda";
            this.Lucinda.Size = new System.Drawing.Size(134, 39);
            this.Lucinda.TabIndex = 1;
            this.Lucinda.Text = "Lucinda";
            this.Lucinda.UseVisualStyleBackColor = true;
            this.Lucinda.Click += new System.EventHandler(this.Lucinda_Click);
            // 
            // Swap
            // 
            this.Swap.Location = new System.Drawing.Point(26, 110);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(134, 39);
            this.Swap.TabIndex = 2;
            this.Swap.Text = "Swap!";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // Talk
            // 
            this.Talk.Location = new System.Drawing.Point(26, 159);
            this.Talk.Name = "Talk";
            this.Talk.Size = new System.Drawing.Size(134, 39);
            this.Talk.TabIndex = 3;
            this.Talk.Text = "Talk";
            this.Talk.UseVisualStyleBackColor = true;
            this.Talk.Click += new System.EventHandler(this.Talk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 220);
            this.Controls.Add(this.Talk);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.Lucinda);
            this.Controls.Add(this.Lloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lloyd;
        private System.Windows.Forms.Button Lucinda;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.Button Talk;
    }
}

