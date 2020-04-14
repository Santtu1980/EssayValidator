namespace EssayValidator
{
    partial class AEVMainForm
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
            this.button_Validate = new System.Windows.Forms.Button();
            this.textBox_PathToEssayDocument = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Validate
            // 
            this.button_Validate.Location = new System.Drawing.Point(12, 68);
            this.button_Validate.Name = "button_Validate";
            this.button_Validate.Size = new System.Drawing.Size(75, 23);
            this.button_Validate.TabIndex = 0;
            this.button_Validate.Text = "Validate";
            this.button_Validate.UseVisualStyleBackColor = true;
            this.button_Validate.Click += new System.EventHandler(this.button_Validate_Click);
            // 
            // textBox_PathToEssayDocument
            // 
            this.textBox_PathToEssayDocument.Location = new System.Drawing.Point(12, 32);
            this.textBox_PathToEssayDocument.Name = "textBox_PathToEssayDocument";
            this.textBox_PathToEssayDocument.Size = new System.Drawing.Size(378, 20);
            this.textBox_PathToEssayDocument.TabIndex = 1;
            // 
            // AEVMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_PathToEssayDocument);
            this.Controls.Add(this.button_Validate);
            this.Name = "AEVMainForm";
            this.Text = "An Essay Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Validate;
        private System.Windows.Forms.TextBox textBox_PathToEssayDocument;
    }
}

