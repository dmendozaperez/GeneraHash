using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Genera_Hash_Xml_RET
{
    [RunInstaller(true)]
    public partial class Install_Hash : System.Configuration.Install.Installer
    {
        public Install_Hash()
        {
            InitializeComponent();
        }
    }
}
