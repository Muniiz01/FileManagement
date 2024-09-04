namespace FileManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.maximize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 46);
            this.panel1.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = global::FileManagement.Properties.Resources.icons8_subtração_16;
            this.minimize.Location = new System.Drawing.Point(1318, 8);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 31);
            this.minimize.TabIndex = 0;
            this.minimize.UseVisualStyleBackColor = false;
            // 
            // maximize
            // 
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Image = global::FileManagement.Properties.Resources.icons8_janela_16;
            this.maximize.Location = new System.Drawing.Point(1350, 8);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(30, 31);
            this.maximize.TabIndex = 0;
            this.maximize.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = global::FileManagement.Properties.Resources.icons8_excluir_16;
            this.exit.Location = new System.Drawing.Point(1380, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 31);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1419, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button maximize;
    }
}

