using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Utilities
{
    public class WindowLocation
    {
        public void SetupInitialWindow(Size size, Point location, string formInitialLocation)
        {
            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default[formInitialLocation].ToString();
                Point il = new Point(0, 0);
                Size sz = size;
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
                    size = sz;
                    location = il;
                }
            }
        }

        public void SaveWindowSettings(Size size, Point location, FormWindowState windowState, 
            Rectangle restoreBounds, string formInitialLocation)
        {
            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                Point lctn = location;
                Size sz = size;
                if (windowState != FormWindowState.Normal)
                {
                    lctn = restoreBounds.Location;
                    sz = restoreBounds.Size;
                }
                string initLocation = string.Join(",", lctn.X, lctn.Y, sz.Width, sz.Height);
                Settings.Default[formInitialLocation] = initLocation;
                Settings.Default.Save();
            }
        }
    }
}
