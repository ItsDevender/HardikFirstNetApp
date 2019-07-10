namespace HardikFirstNetApp
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
            this.btnClickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickme
            // 
            this.btnClickme.Location = new System.Drawing.Point(189, 115);
            this.btnClickme.Name = "btnClickme";
            this.btnClickme.Size = new System.Drawing.Size(75, 23);
            this.btnClickme.TabIndex = 0;
            this.btnClickme.Text = "CLickMe";
            this.btnClickme.UseVisualStyleBackColor = true;
            this.btnClickme.Click += new System.EventHandler(this.BtnClickme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickme;
    }
}

