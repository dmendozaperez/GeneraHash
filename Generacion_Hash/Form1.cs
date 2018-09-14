using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generacion_Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         

           //Modulo_Hash.Basico.CambiaServidor("http://148.102.50.44/web_site_electronica/ws_bata.asmx");
            string _error = "";

            //            Modulo_Hash_RET.Basico._envia_xml(ref _error);

            Modulo_Hash.Basico._ejecuta_proceso(ref _error);

            //Modulo_Hash.Basico.ejecuta_impresion_qr(ref _error);

            MessageBox.Show("ok");
        }
    }
}
