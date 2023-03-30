namespace Projeto_Vi_Pa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícío2AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercícío2AToolStripMenuItem,
            this.exercício2BToolStripMenuItem,
            this.exercício2CToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem.Text = "Exercício1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercícío2AToolStripMenuItem
            // 
            this.exercícío2AToolStripMenuItem.Name = "exercícío2AToolStripMenuItem";
            this.exercícío2AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercícío2AToolStripMenuItem.Text = "Exercícío 2A";
            this.exercícío2AToolStripMenuItem.Click += new System.EventHandler(this.exercícío2AToolStripMenuItem_Click);
            // 
            // exercício2BToolStripMenuItem
            // 
            this.exercício2BToolStripMenuItem.Name = "exercício2BToolStripMenuItem";
            this.exercício2BToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício2BToolStripMenuItem.Text = "Exercício 2B";
            this.exercício2BToolStripMenuItem.Click += new System.EventHandler(this.exercício2BToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exercício2CToolStripMenuItem
            // 
            this.exercício2CToolStripMenuItem.Name = "exercício2CToolStripMenuItem";
            this.exercício2CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício2CToolStripMenuItem.Text = "Exercício 2C ";
            this.exercício2CToolStripMenuItem.Click += new System.EventHandler(this.exercício2CToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Exercícios de Condicionais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícío2AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2CToolStripMenuItem;
    }
}

