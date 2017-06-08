using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using Modulo_Hash_RET;
namespace Genera_Hash_Xml_RET
{
    public partial class Service_Hash : ServiceBase
    {
        Timer tmservicio = null;

        /*envio xml*/
        Timer tmservicio_xml = null;
        private Int32 _valida_service_xml = 0;
        /*envio xml*/
        private Int32 _valida_service = 0;
        public Service_Hash()
        {
            //5000=5 segundos
            InitializeComponent();
            tmservicio = new Timer(1000);
            tmservicio.Elapsed += new ElapsedEventHandler(tmpServicio_Elapsed);

            /*envio xml proceso*/
            tmservicio_xml = new Timer(1000);
            tmservicio_xml.Elapsed += new ElapsedEventHandler(tmservicio_xml_Elapsed);

        }

        void tmservicio_xml_Elapsed(object sender, ElapsedEventArgs e)
        {
            //string varchivov = "c://valida_hash.txt";
            Int32 _valor = 0;
            try
            {

                //if (!(System.IO.File.Exists(varchivov)))
                if (_valida_service_xml == 0)
                {

                    _valor = 1;
                    _valida_service_xml = 1;
                    //TextWriter tw = new StreamWriter(varchivov, true);
                    //tw.WriteLine(DateTime.Now.ToString() + "====>>>ejecutando procesos");
                    //tw.Close();
                    string _error = "";
                    Basico._envia_xml(ref _error);
                    //if (System.IO.File.Exists(varchivov))
                    //{
                    _valida_service_xml = 0;
                    //System.IO.File.Delete(varchivov);
                    //}
                }
                //****************************************************************************
            }
            catch
            {
                //if (System.IO.File.Exists(varchivov))
                //{
                _valida_service_xml = 0;
                //System.IO.File.Delete(varchivov);
                //}                
            }

            if (_valor == 1)
            {
                //if (System.IO.File.Exists(varchivov))
                //{
                _valida_service_xml = 0;
                //System.IO.File.Delete(varchivov);
                //}   
            }

        }

        void tmpServicio_Elapsed(object sender, ElapsedEventArgs e)
        {            
            //string varchivov = "c://valida_hash.txt";
            Int32 _valor = 0;
            try
            {

                //if (!(System.IO.File.Exists(varchivov)))
                if (_valida_service==0)
                {

                    _valor = 1;
                    _valida_service = 1;
                    //TextWriter tw = new StreamWriter(varchivov, true);
                    //tw.WriteLine(DateTime.Now.ToString() + "====>>>ejecutando procesos");
                    //tw.Close();
                    string _error = "";
                    Basico._ejecuta_proceso(ref _error);                   
                    //if (System.IO.File.Exists(varchivov))
                    //{
                        _valida_service = 0;
                        //System.IO.File.Delete(varchivov);
                    //}
                }
                //****************************************************************************
            }
            catch 
            {
                //if (System.IO.File.Exists(varchivov))
                //{
                    _valida_service = 0;
                    //System.IO.File.Delete(varchivov);
                //}                
            }

            if (_valor==1)
            {
                //if (System.IO.File.Exists(varchivov))
                //{
                    _valida_service = 0;
                    //System.IO.File.Delete(varchivov);
                //}   
            }

        }
        protected override void OnStart(string[] args)
        {
            tmservicio.Start();
            tmservicio_xml.Start();
        }

        protected override void OnStop()
        {
            tmservicio.Stop();
            tmservicio_xml.Stop();
        }
    }
}
