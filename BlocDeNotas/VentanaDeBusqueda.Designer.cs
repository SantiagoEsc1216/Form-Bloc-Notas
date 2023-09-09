namespace BlocDeNotas
{
    partial class VentanaDeBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDeBusqueda));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Result_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Search_TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Prev_button = new System.Windows.Forms.ToolStripButton();
            this.Search_button = new System.Windows.Forms.ToolStripButton();
            this.Next_button = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Result_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 38);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Result_Label
            // 
            this.Result_Label.Enabled = false;
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(152, 17);
            this.Result_Label.Text = "Coincidencias encontradas:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search_TextBox,
            this.Prev_button,
            this.Search_button,
            this.Next_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(250, 38);
            this.Search_TextBox.Text = "Buscar";
            // 
            // Prev_button
            // 
            this.Prev_button.AutoSize = false;
            this.Prev_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Prev_button.Image = ((System.Drawing.Image)(resources.GetObject("Prev_button.Image")));
            this.Prev_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Prev_button.Name = "Prev_button";
            this.Prev_button.Size = new System.Drawing.Size(35, 35);
            this.Prev_button.Text = "Anterior";
            this.Prev_button.Click += new System.EventHandler(this.Prev_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.AutoSize = false;
            this.Search_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search_button.Image = ((System.Drawing.Image)(resources.GetObject("Search_button.Image")));
            this.Search_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(35, 35);
            this.Search_button.Text = "Buscar";
            this.Search_button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Next_button
            // 
            this.Next_button.AutoSize = false;
            this.Next_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next_button.Image = ((System.Drawing.Image)(resources.GetObject("Next_button.Image")));
            this.Next_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(35, 35);
            this.Next_button.Text = "Siguiente";
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // VentanaDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 60);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaDeBusqueda";
            this.Text = "Ventana De Busqueda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaDeBusqueda_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox Search_TextBox;
        private System.Windows.Forms.ToolStripButton Prev_button;
        private System.Windows.Forms.ToolStripButton Search_button;
        private System.Windows.Forms.ToolStripButton Next_button;
        private System.Windows.Forms.ToolStripStatusLabel Result_Label;
    }
}