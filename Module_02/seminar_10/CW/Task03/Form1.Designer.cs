namespace Task03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(800, 450);
            this.button.TabIndex = 0;
            this.button.Text = "Увеличить форму";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "Form1";
            this.Text = "Изменение размар формы";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button;
    }
}