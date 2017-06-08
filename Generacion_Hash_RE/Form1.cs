using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generacion_Hash_RE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modulo_Hash.Basico.CambiaServidor("http://148.102.50.44/web_site_electronica/ws_bata.asmx");
            string _error = "";

            Modulo_Hash_RET.Basico._envia_xml(ref _error);

            Modulo_Hash_RET.Basico._ejecuta_proceso(ref _error);
        }
    }
}
