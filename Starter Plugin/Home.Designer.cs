namespace Starter_Plugin
{
    partial class Home
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PluginIcon = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PluginIcon
            // 
            this.PluginIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginIcon.AutoSize = true;
            this.PluginIcon.BackColor = System.Drawing.Color.Transparent;
            this.PluginIcon.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginIcon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PluginIcon.Image = global::Starter_Plugin.Properties.Resources.Device_Management_Plugin___Icon_36;
            this.PluginIcon.Location = new System.Drawing.Point(8, 8);
            this.PluginIcon.Margin = new System.Windows.Forms.Padding(0);
            this.PluginIcon.MaximumSize = new System.Drawing.Size(36, 36);
            this.PluginIcon.MinimumSize = new System.Drawing.Size(36, 36);
            this.PluginIcon.Name = "PluginIcon";
            this.PluginIcon.Size = new System.Drawing.Size(36, 36);
            this.PluginIcon.TabIndex = 9;
            this.PluginIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text
            // 
            this.Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Text.BackColor = System.Drawing.Color.Transparent;
            this.Text.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Text.Location = new System.Drawing.Point(0, 0);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(1000, 500);
            this.Text.TabIndex = 8;
            this.Text.Text = "Hello, i\'m a Plugin!";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PluginIcon);
            this.Controls.Add(this.Text);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PluginIcon;
        private System.Windows.Forms.Label Text;
    }
}
