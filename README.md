
![Device Management](https://i.imgur.com/Ek6opZb.png) Device Management

![Plugin for Device Management](https://i.imgur.com/RzO30kD.png) Plugin for Device Management
 ___

This documentation is under development, soon it will be more detailed to help you in plugin development.

# Starting

To get started, download this repository, don't leave any files behind.

## Requeriments

 - Visual Studio 2019;
 - .NET Framework 4.8.

# Importing the Project

 - Open the "*Visual Studio 2019*";
 - Select the option "*Open a project or a solution*";
 - Navigate to the "*Starter Plugin*" project folder and select the "*Starter Plugin.csproj*" file.

## Setting Up the Files

 - In the right side menu, open the "*Solution Manager*";
 - Right-click on "*References*" and select the option "*Add Reference...*";
 - In the tab that opened, click on the "*Browse...*" button located in the bottom right;
 - Navigate to the project folder "*Starter Plugin*" and then "*Resourcers*";
 - Select the file "*PluginDM.dll*" and click "*Add*";
 - Make sure the checkbox is checked and click "*OK*".

## Generating AssemblyInfo

- Select the project and click with the right mouse button;
- Click on "*Properties*";
- In "*Application*", select "*Assembly Information…*";
- Uncheck the checkbox "*Make assembly visible using COM*" and click "*OK*";
- Now, in the same location, check the checkbox "*Make assembly visible using COM*" and click "*OK*".

# Implementing Interface Members (PluginCDM.cs)

## PluginDiscriminator

It is a unique value that will be used to identify the plugin.

## PluginName

It's the name of the plugin.

## PluginDescription

The description is a summary of the plugin's function.

## PluginVersion

It is the plugin version, it should be used as follows "*1.2.3.4*":
1. Main Version;
2. Secondary Version;
3. Version Number;
4. Revision.

## PluginHomeInterface

It is the plugin main interface.

# End

Now you can develop the plugin.
