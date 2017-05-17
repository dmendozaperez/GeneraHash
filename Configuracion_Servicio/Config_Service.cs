using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.ServiceModel.Configuration;
namespace Configuracion_Servicio
{
    public partial class Config_Service : Form
    {
        public Config_Service()
        {
            InitializeComponent();
        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            //cambiando destino xml
            string _destino=(chkproduccion.Checked)?"P":"D";
            CambiaDestino(_destino);

            //verificando url
            string _url = (rdblocal.Checked) ? txtlocal.Text : txtremoto.Text;
            CambiaServidor(_url);

            activando_servicio_win();
            MessageBox.Show("El servicio se activo correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch
            {

            }
            Cursor.Current = Cursors.Default;
            this.Close();
        }
        private   string Right(string param, int length)
        {
            //start at the index based on the lenght of the sting minus
            //the specified lenght and assign it a variable
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }
        private  string Left(string param, int length)
        {
            //we start at 0 since we want to get the characters starting from the
            //left and with the specified lenght and assign it to a variable
            string result = param.Substring(0, length);
            //return the result of the operation
            return result;
        } 
        private void activando_servicio_win()
        {
            try
            {
                ServiceController[] service;
                service = (ServiceController[])ServiceController.GetServices();
                for (Int32 s = 0; s < service.Length; ++s)
                {
                    string nameservicio = service[s].ServiceName;
                    if (nameservicio == "Service Hash (Bata)")
                    {
                        //en este caso vamos activar el firewall para la tranferencia de ftp al server
                        //agregarfirewall(2);

                        string status = service[s].Status.ToString();
                        string DisplayName = service[s].DisplayName.ToString();
                        string ServiceType = service[s].ServiceType.ToString();
                        string MachineName = service[s].MachineName.ToString();

                        ServiceController servicio;
                        ServiceControllerStatus servStatus;
                        servicio = (ServiceController)service[s];
                        servicio.Refresh();
                        servStatus = servicio.Status;
                        if (Left(servStatus.ToString(), 1) != "R")
                        {
                            servicio.Start();
                            servicio.Refresh();
                            Console.Write("El servicio se activo Correctamente");
                            return;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        #region <MODIFICACION DEL APP.CONFIG WEB SERVICE>

        private void CambiaDestino(string destino)
        {
            try
            {

                System.Configuration.Configuration wConfig = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(new System.Configuration.ExeConfigurationFileMap { ExeConfigFilename = @"D:\INTERFA\CARVAJAL\bata_proceso\Genera_Hash_Xml.exe.config" }, System.Configuration.ConfigurationUserLevel.None);
                wConfig.AppSettings.Settings.Remove("Proceso");
                wConfig.AppSettings.Settings.Add("Proceso",destino);                
                wConfig.Save(System.Configuration.ConfigurationSaveMode.Modified);

                //ServiceModelSectionGroup wServiceSection = ServiceModelSectionGroup.GetSectionGroup(wConfig);

                //ClientSection wClientSection = wServiceSection.Client;
                //wClientSection.Endpoints[0].Address = new Uri(urlFinal);
                //wConfig.Save();
            }
            catch
            {

            }

            // System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            //ServiceModelSectionGroup smsg = ServiceModelSectionGroup.GetSectionGroup(config);
            //foreach (ChannelEndpointElement cee in smsg.Client.Endpoints)
            //{
            //    cee.Address = new Uri(urlFinal);
            //}
            //MessageBox.Show("El Servidor de Datos Ha Cambiado tiene que Cerrar el Sistema para que los cambios surtan efecto."); config.Save();
        }

        private  void CambiaServidor(string urlFinal)
        {
            try
            {

                System.Configuration.Configuration wConfig = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(new System.Configuration.ExeConfigurationFileMap { ExeConfigFilename = @"D:\INTERFA\CARVAJAL\bata_proceso\Genera_Hash_Xml.exe.config" }, System.Configuration.ConfigurationUserLevel.None);
                ServiceModelSectionGroup wServiceSection = ServiceModelSectionGroup.GetSectionGroup(wConfig);

                ClientSection wClientSection = wServiceSection.Client;
                wClientSection.Endpoints[0].Address = new Uri(urlFinal);
                wConfig.Save();
            }
            catch
            {

            }

            // System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            //ServiceModelSectionGroup smsg = ServiceModelSectionGroup.GetSectionGroup(config);
            //foreach (ChannelEndpointElement cee in smsg.Client.Endpoints)
            //{
            //    cee.Address = new Uri(urlFinal);
            //}
            //MessageBox.Show("El Servidor de Datos Ha Cambiado tiene que Cerrar el Sistema para que los cambios surtan efecto."); config.Save();
        }
        #endregion

        private void Config_Service_Load(object sender, EventArgs e)
        {
            rdbremoto.Checked = true;
            chkremoto.Checked = false;
            chklocal.Enabled = false;
            txtlocal.Enabled = false;
            txtremoto.Enabled = false;
            chkproduccion.Checked = true;
        }

        private void chkremoto_CheckedChanged(object sender, EventArgs e)
        {
            txtremoto.Enabled = (chkremoto.Checked) ? true : false;
        }

        private void chklocal_CheckedChanged(object sender, EventArgs e)
        {
            txtlocal.Enabled = (chklocal.Checked) ? true : false;
        }

        private void rdbremoto_CheckedChanged(object sender, EventArgs e)
        {
            chkremoto.Enabled = true;
            chkremoto.Checked = false;

            chklocal.Enabled = false;
            chklocal.Checked = false;
        }

        private void rdblocal_CheckedChanged(object sender, EventArgs e)
        {
            chkremoto.Enabled = false;
            chkremoto.Checked = false;

            chklocal.Enabled = true;
            chklocal.Checked = false;
        }

    }
}
