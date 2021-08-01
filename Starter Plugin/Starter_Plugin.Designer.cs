namespace Starter_Plugin
{
    partial class Starter_Plugin
    {
        #region Required for support and correct functioning, do not modify the contents of this method.
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter_Plugin));
            this.Text = new System.Windows.Forms.Label();
            this.PluginIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Text.BackColor = System.Drawing.Color.Transparent;
            this.Text.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Text.Location = new System.Drawing.Point(12, 9);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(976, 482);
            this.Text.TabIndex = 1;
            this.Text.Text = "Hello, i\'m a Plugin!";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PluginIcon.Location = new System.Drawing.Point(12, 9);
            this.PluginIcon.MaximumSize = new System.Drawing.Size(36, 36);
            this.PluginIcon.MinimumSize = new System.Drawing.Size(36, 36);
            this.PluginIcon.Name = "PluginIcon";
            this.PluginIcon.Size = new System.Drawing.Size(36, 36);
            this.PluginIcon.TabIndex = 2;
            this.PluginIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Starter_Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.PluginIcon);
            this.Controls.Add(this.Text);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Starter_Plugin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starter Plugin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Label PluginIcon;
    }
}