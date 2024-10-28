using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Green_Villa
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Control control)
        {
            // set normal color scheme for all 
            
            
            if (control is Form form)
            {
                form.BackColor = Color.White;
                form.ForeColor = Color.Black;
            }

            
            // apply the theme for buttons
            if (control is Button button)
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Size = new Size(100, 40);


                button.BackgroundImage = Properties.Resources.green2;

                // set images for buttons
                if(button.Name == "btnBack" || button.Name == "btnCancel")
                {
                    button.BackgroundImage = Properties.Resources.blue2;
                }

                button.BackgroundImageLayout = ImageLayout.Stretch;
                

            }
        
            // apply theme for evry component inside the form (child)
            foreach (Control child in control.Controls)
            {
                ApplyTheme(child);
            }
        }
    }
}
