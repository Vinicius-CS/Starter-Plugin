using PluginDM;

namespace Starter_Plugin
{
    public class PluginCDM : PluginIDM
    {
        string PluginDiscriminator = "sp";
        string PluginName = "Starter Plugin";
        string PluginDescription = "A starter Plugin for developers!";
        string PluginVersion = "1.0.0.0";

        System.Windows.Forms.UserControl PluginHomeInterface = new Home();

        string PluginIDM.Plugin_Discriminator
        {
            get { return PluginDiscriminator; }
        }

        string PluginIDM.Plugin_Name
        {
            get { return PluginName; }
        }

        string PluginIDM.Plugin_Description
        {
            get { return PluginDescription; }
        }

        string PluginIDM.Plugin_Version
        {
            get { return PluginVersion; }
        }

        System.Windows.Forms.UserControl PluginIDM.Plugin_HomeInterface
        {
            get { return PluginHomeInterface; }
        }
    }
}