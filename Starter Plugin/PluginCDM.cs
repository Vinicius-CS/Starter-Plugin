using PluginDM;

namespace Starter_Plugin
{
    class PluginCDM : PluginIDM
    {
        string PluginDiscriminator = "SP";
        string PluginName = "Starter Plugin";
        string PluginDescription = "A starter Plugin for developers!";
        string PluginVersion = "1.0.0.0";

        System.Windows.Forms.UserControl PluginHomeInterface = new Home();

        public string Plugin_Discriminator
        {
            get { return PluginDiscriminator; }
        }

        public string Plugin_Name
        {
            get { return PluginName; }
        }

        public string Plugin_Description
        {
            get { return PluginDescription; }
        }

        public string Plugin_Version
        {
            get { return PluginVersion; }
        }

        public System.Windows.Forms.UserControl Plugin_HomeInterface
        {
            get { return PluginHomeInterface; }
        }
    }
}