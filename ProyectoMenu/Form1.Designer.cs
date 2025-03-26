namespace ProyectoMenu
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
            FractalesBtn = new Button();
            SuspendLayout();
            // 
            // FractalesBtn
            // 
            FractalesBtn.Location = new Point(48, 104);
            FractalesBtn.Name = "FractalesBtn";
            FractalesBtn.Size = new Size(94, 29);
            FractalesBtn.TabIndex = 0;
            FractalesBtn.Text = "Fractales";
            FractalesBtn.UseVisualStyleBackColor = true;
            FractalesBtn.Click += Fractales_Btn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 570);
            Controls.Add(FractalesBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button FractalesBtn;
    }
}
