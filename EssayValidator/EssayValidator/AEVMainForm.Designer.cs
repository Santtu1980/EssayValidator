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
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.button_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Validate
            // 
            this.button_Validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Validate.Location = new System.Drawing.Point(713, 32);
            this.button_Validate.Name = "button_Validate";
            this.button_Validate.Size = new System.Drawing.Size(75, 23);
            this.button_Validate.TabIndex = 0;
            this.button_Validate.Text = "Validate";
            this.button_Validate.UseVisualStyleBackColor = true;
            this.button_Validate.Click += new System.EventHandler(this.button_Validate_Click);
            // 
            // textBox_PathToEssayDocument
            // 
            this.textBox_PathToEssayDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PathToEssayDocument.Location = new System.Drawing.Point(12, 32);
            this.textBox_PathToEssayDocument.Name = "textBox_PathToEssayDocument";
            this.textBox_PathToEssayDocument.Size = new System.Drawing.Size(614, 20);
            this.textBox_PathToEssayDocument.TabIndex = 1;
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Location = new System.Drawing.Point(12, 58);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.Size = new System.Drawing.Size(776, 380);
            this.dataGridView_result.TabIndex = 2;
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.Location = new System.Drawing.Point(632, 32);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 3;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // AEVMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.dataGridView_result);
            this.Controls.Add(this.textBox_PathToEssayDocument);
            this.Controls.Add(this.button_Validate);
            this.Name = "AEVMainForm";
            this.Text = "An Essay Validator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Validate;
        private System.Windows.Forms.TextBox textBox_PathToEssayDocument;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label1;
    }
}

