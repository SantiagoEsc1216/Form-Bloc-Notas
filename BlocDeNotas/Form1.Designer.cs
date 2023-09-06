using System;

namespace BlocDeNotas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_UndoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CopyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_PasteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_SearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.FileName_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool_StatusTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_OpenButton = new System.Windows.Forms.ToolStripButton();
            this.tool_SaveButton = new System.Windows.Forms.ToolStripButton();
            this.tool_SaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_UndoButton = new System.Windows.Forms.ToolStripButton();
            this.tool_CutButton = new System.Windows.Forms.ToolStripButton();
            this.tool_CopyButton = new System.Windows.Forms.ToolStripButton();
            this.tool_PasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.tool_SearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenButton,
            this.Menu_SaveButton,
            this.Menu_SaveAsButton,
            this.Menu_ExitButton});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menu_OpenButton
            // 
            this.menu_OpenButton.Name = "menu_OpenButton";
            this.menu_OpenButton.Size = new System.Drawing.Size(150, 22);
            this.menu_OpenButton.Text = "Abrir";
            this.menu_OpenButton.Click += new System.EventHandler(this.menu_OpenButton_Click);
            // 
            // Menu_SaveButton
            // 
            this.Menu_SaveButton.Name = "Menu_SaveButton";
            this.Menu_SaveButton.Size = new System.Drawing.Size(150, 22);
            this.Menu_SaveButton.Text = "Guardar";
            this.Menu_SaveButton.Click += new System.EventHandler(this.Menu_SaveButton_Click);
            // 
            // Menu_SaveAsButton
            // 
            this.Menu_SaveAsButton.Name = "Menu_SaveAsButton";
            this.Menu_SaveAsButton.Size = new System.Drawing.Size(150, 22);
            this.Menu_SaveAsButton.Text = "Guardar como";
            this.Menu_SaveAsButton.Click += new System.EventHandler(this.Menu_SaveAsButton_Click);
            // 
            // Menu_ExitButton
            // 
            this.Menu_ExitButton.Name = "Menu_ExitButton";
            this.Menu_ExitButton.Size = new System.Drawing.Size(150, 22);
            this.Menu_ExitButton.Text = "Salir";
            this.Menu_ExitButton.Click += new System.EventHandler(this.Menu_ExitButton_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_UndoButton,
            this.Menu_CutButton,
            this.Menu_CopyButton,
            this.Menu_PasteButton});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // Menu_UndoButton
            // 
            this.Menu_UndoButton.Enabled = false;
            this.Menu_UndoButton.Name = "Menu_UndoButton";
            this.Menu_UndoButton.Size = new System.Drawing.Size(180, 22);
            this.Menu_UndoButton.Text = "Deshacer";
            this.Menu_UndoButton.Click += new System.EventHandler(this.Menu_UndoButton_Click);
            // 
            // Menu_CutButton
            // 
            this.Menu_CutButton.Name = "Menu_CutButton";
            this.Menu_CutButton.Size = new System.Drawing.Size(180, 22);
            this.Menu_CutButton.Text = "Cortar";
            // 
            // Menu_CopyButton
            // 
            this.Menu_CopyButton.Name = "Menu_CopyButton";
            this.Menu_CopyButton.Size = new System.Drawing.Size(180, 22);
            this.Menu_CopyButton.Text = "Copiar";
            // 
            // Menu_PasteButton
            // 
            this.Menu_PasteButton.Name = "Menu_PasteButton";
            this.Menu_PasteButton.Size = new System.Drawing.Size(180, 22);
            this.Menu_PasteButton.Text = "Pegar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_SearchBox,
            this.Menu_SearchButton});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // Menu_SearchBox
            // 
            this.Menu_SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_SearchBox.Name = "Menu_SearchBox";
            this.Menu_SearchBox.Size = new System.Drawing.Size(100, 23);
            this.Menu_SearchBox.Text = "Ingrese texto";
            // 
            // Menu_SearchButton
            // 
            this.Menu_SearchButton.Name = "Menu_SearchButton";
            this.Menu_SearchButton.Size = new System.Drawing.Size(160, 22);
            this.Menu_SearchButton.Text = "Buscar";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileName_Text,
            this.toolStripStatusLabel1,
            this.tool_StatusTag});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // FileName_Text
            // 
            this.FileName_Text.Enabled = false;
            this.FileName_Text.Name = "FileName_Text";
            this.FileName_Text.Size = new System.Drawing.Size(121, 17);
            this.FileName_Text.Text = "Dirección del archivo:";
            this.FileName_Text.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tool_StatusTag
            // 
            this.tool_StatusTag.Enabled = false;
            this.tool_StatusTag.Name = "tool_StatusTag";
            this.tool_StatusTag.Size = new System.Drawing.Size(111, 17);
            this.tool_StatusTag.Text = "Estado:  Sin guardar";
            this.tool_StatusTag.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_OpenButton,
            this.tool_SaveButton,
            this.tool_SaveAsButton,
            this.toolStripSeparator1,
            this.tool_UndoButton,
            this.tool_CutButton,
            this.tool_CopyButton,
            this.tool_PasteButton,
            this.toolStripSeparator2,
            this.tool_SearchBox,
            this.tool_SearchButton,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tool_OpenButton
            // 
            this.tool_OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_OpenButton.Image")));
            this.tool_OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_OpenButton.Name = "tool_OpenButton";
            this.tool_OpenButton.Size = new System.Drawing.Size(23, 22);
            this.tool_OpenButton.Text = "toolStripButton1";
            this.tool_OpenButton.Click += new System.EventHandler(this.tool_OpenButton_Click);
            // 
            // tool_SaveButton
            // 
            this.tool_SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_SaveButton.Image")));
            this.tool_SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_SaveButton.Name = "tool_SaveButton";
            this.tool_SaveButton.Size = new System.Drawing.Size(23, 22);
            this.tool_SaveButton.Text = "toolStripButton2";
            this.tool_SaveButton.Click += new System.EventHandler(this.tool_SaveButton_Click);
            // 
            // tool_SaveAsButton
            // 
            this.tool_SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_SaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_SaveAsButton.Image")));
            this.tool_SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_SaveAsButton.Name = "tool_SaveAsButton";
            this.tool_SaveAsButton.Size = new System.Drawing.Size(23, 22);
            this.tool_SaveAsButton.Text = "toolStripButton3";
            this.tool_SaveAsButton.Click += new System.EventHandler(this.tool_SaveAsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_UndoButton
            // 
            this.tool_UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_UndoButton.Enabled = false;
            this.tool_UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_UndoButton.Image")));
            this.tool_UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UndoButton.Name = "tool_UndoButton";
            this.tool_UndoButton.Size = new System.Drawing.Size(23, 22);
            this.tool_UndoButton.Text = "toolStripButton4";
            this.tool_UndoButton.Click += new System.EventHandler(this.tool_UndoButton_Click);
            // 
            // tool_CutButton
            // 
            this.tool_CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_CutButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_CutButton.Image")));
            this.tool_CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_CutButton.Name = "tool_CutButton";
            this.tool_CutButton.Size = new System.Drawing.Size(23, 22);
            this.tool_CutButton.Text = "toolStripButton5";
            // 
            // tool_CopyButton
            // 
            this.tool_CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_CopyButton.Image")));
            this.tool_CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_CopyButton.Name = "tool_CopyButton";
            this.tool_CopyButton.Size = new System.Drawing.Size(23, 22);
            this.tool_CopyButton.Text = "toolStripButton6";
            // 
            // tool_PasteButton
            // 
            this.tool_PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_PasteButton.Image")));
            this.tool_PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_PasteButton.Name = "tool_PasteButton";
            this.tool_PasteButton.Size = new System.Drawing.Size(23, 22);
            this.tool_PasteButton.Text = "toolStripButton7";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_SearchBox
            // 
            this.tool_SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tool_SearchBox.Name = "tool_SearchBox";
            this.tool_SearchBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tool_SearchButton
            // 
            this.tool_SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("tool_SearchButton.Image")));
            this.tool_SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_SearchButton.Name = "tool_SearchButton";
            this.tool_SearchButton.Size = new System.Drawing.Size(23, 22);
            this.tool_SearchButton.Text = "toolStripButton8";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 49);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 379);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.Text = "Bloc de notas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveButton;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem Menu_ExitButton;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_UndoButton;
        private System.Windows.Forms.ToolStripMenuItem Menu_CutButton;
        private System.Windows.Forms.ToolStripMenuItem Menu_CopyButton;
        private System.Windows.Forms.ToolStripMenuItem Menu_PasteButton;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel FileName_Text;
        private System.Windows.Forms.ToolStripButton tool_OpenButton;
        private System.Windows.Forms.ToolStripButton tool_SaveButton;
        private System.Windows.Forms.ToolStripButton tool_SaveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_UndoButton;
        private System.Windows.Forms.ToolStripButton tool_CutButton;
        private System.Windows.Forms.ToolStripButton tool_CopyButton;
        private System.Windows.Forms.ToolStripButton tool_PasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tool_SearchBox;
        private System.Windows.Forms.ToolStripButton tool_SearchButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenButton;
        private System.Windows.Forms.ToolStripTextBox Menu_SearchBox;
        private System.Windows.Forms.ToolStripMenuItem Menu_SearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tool_StatusTag;
    }
}

