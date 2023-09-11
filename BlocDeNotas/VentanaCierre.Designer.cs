namespace BlocDeNotas
{
    partial class VentanaCierre
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
            this.AlertLabel = new System.Windows.Forms.Label();
            this.UnsaveButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(9, 9);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(279, 13);
            this.AlertLabel.TabIndex = 0;
            this.AlertLabel.Text = "Parece que hay cambios sin guardar. ¿Qué desea hacer?";
            // 
            // UnsaveButton
            // 
            this.UnsaveButton.Location = new System.Drawing.Point(155, 25);
            this.UnsaveButton.Name = "UnsaveButton";
            this.UnsaveButton.Size = new System.Drawing.Size(75, 23);
            this.UnsaveButton.TabIndex = 1;
            this.UnsaveButton.Text = "No guardar";
            this.UnsaveButton.UseVisualStyleBackColor = true;
            this.UnsaveButton.Click += new System.EventHandler(this.UnsaveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Location = new System.Drawing.Point(74, 25);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VentanaCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 56);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UnsaveButton);
            this.Controls.Add(this.AlertLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaCierre";
            this.Load += new System.EventHandler(this.VentanaCierre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Button UnsaveButton;
        private System.Windows.Forms.Button SaveButton;
    }
}