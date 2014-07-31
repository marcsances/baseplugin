using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace fPlayer_2
{
    public class basePlugin : IPlugin
    {
        public string name = "basePlugin";
        public Control getGUI()
        {
            return new pluginUI();
        }
    }
}
