using PluginDM;

namespace PluginBuilderDM
{
    public class Starter:PluginIDM
    {
        public string Plugin_Discriminator()
        {
            return "pn";
        }
        public string Plugin_Name()
        {
            return "Plugin Name";
        }

        public string Plugin_Description()
        {
            return "Plugin Description";
        }

        public string Plugin_Version()
        {
            return "1.0.0.0";
        }

        /*public void MenuAdder(System.Windows.Forms.ToolStripItem ts)
        {
            ts.Click += ts_Click;
        }

        void ts_Click(object sender, EventArgs e)
        {
            Library_Dashboard frm = new Library_Dashboard();
            frm.ShowDialog();
        }*/
    }
}
