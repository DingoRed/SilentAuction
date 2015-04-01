using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Utilities
{
    public class WindowSettings
    {
        /// <summary>
        /// Sets the Forms window size and location
        /// </summary>
        /// <param name="theForm">The Form to set the location for</param>
        /// <param name="propertyName">The name of the property stored in the Settings file</param>
        public static void SetupInitialWindow(Form theForm, string propertyName)
        {
            if (Settings.Default.Properties.Cast<SettingsProperty>().All(prop => prop.Name != propertyName))
                return;
            
            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default[propertyName].ToString();
                Point il = new Point(0, 0);
                Size sz = theForm.Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                    theForm.Size = sz;
                    theForm.Location = il;
                }
            }
        }

        /// <summary>
        /// Saves the Forms window size and location
        /// </summary>
        /// <param name="theForm">The Form to save the location for</param>
        /// <param name="propertyName">The name of the property stored in the Settings file</param>
        public static void SaveWindowSettings(Form theForm, string propertyName)
        {
            if (Settings.Default.Properties.Cast<SettingsProperty>().All(prop => prop.Name != propertyName))
                return;

            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                Point location = theForm.Location;
                Size size = theForm.Size;
                if (theForm.WindowState != FormWindowState.Normal)
                {
                    location = theForm.RestoreBounds.Location;
                    size = theForm.RestoreBounds.Size;
                }
                string initLocation = string.Join(",", location.X, location.Y, size.Width, size.Height);
                Settings.Default[propertyName] = initLocation;
                Settings.Default.Save();
            }
        }
    }
}