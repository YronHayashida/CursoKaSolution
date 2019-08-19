namespace CursoFormsAppProjNS
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
            this.codigoCursoLabel = new System.Windows.Forms.Label();
            this.codigoCursoTextBox = new System.Windows.Forms.TextBox();
            this.exibiCursoButton = new System.Windows.Forms.Button();
            this.nomeCursoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigoCursoLabel
            // 
            this.codigoCursoLabel.AutoSize = true;
            this.codigoCursoLabel.Location = new System.Drawing.Point(44, 73);
            this.codigoCursoLabel.Name = "codigoCursoLabel";
            this.codigoCursoLabel.Size = new System.Drawing.Size(84, 13);
            this.codigoCursoLabel.TabIndex = 0;
            this.codigoCursoLabel.Text = "Codigo do curso";
            // 
            // codigoCursoTextBox
            // 
            this.codigoCursoTextBox.Location = new System.Drawing.Point(134, 70);
            this.codigoCursoTextBox.Name = "codigoCursoTextBox";
            this.codigoCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoCursoTextBox.TabIndex = 1;
            // 
            // exibiCursoButton
            // 
            this.exibiCursoButton.Location = new System.Drawing.Point(57, 96);
            this.exibiCursoButton.Name = "exibiCursoButton";
            this.exibiCursoButton.Size = new System.Drawing.Size(166, 31);
            this.exibiCursoButton.TabIndex = 2;
            this.exibiCursoButton.Text = "Exibi nome do curso";
            this.exibiCursoButton.UseVisualStyleBackColor = true;
            this.exibiCursoButton.Click += new System.EventHandler(this.exibiCursoButton_Click);
            // 
            // nomeCursoLabel
            // 
            this.nomeCursoLabel.AutoSize = true;
            this.nomeCursoLabel.Location = new System.Drawing.Point(54, 144);
            this.nomeCursoLabel.Name = "nomeCursoLabel";
            this.nomeCursoLabel.Size = new System.Drawing.Size(0, 13);
            this.nomeCursoLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeCursoLabel);
            this.Controls.Add(this.exibiCursoButton);
            this.Controls.Add(this.codigoCursoTextBox);
            this.Controls.Add(this.codigoCursoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoCursoLabel;
        private System.Windows.Forms.TextBox codigoCursoTextBox;
        private System.Windows.Forms.Button exibiCursoButton;
        private System.Windows.Forms.Label nomeCursoLabel;
    }
}

