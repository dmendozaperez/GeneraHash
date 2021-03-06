﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvajal.FEPE.PreSC.Core;
using System.IO;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Modulo_Hash
{
    public class Basico
    {
        #region<primer exportacion para los cambios>

        #endregion<>

        #region <REGION VARIABLES DE CONFIGURACION>
        private static string _ruta_in_boleta { set; get; }
        private static string _ruta_in_factura { set; get; }
        private static string _ruta_in_credito { set; get; }
        private static string _ruta_in_debito { set; get; }

        //configuracion por defecto de carvajal
        private static string _ruta_carvajal_xml { set; get; }
        private static string _ruta_carvajal_mapa { set; get; }
        private static string _ruta_carvajal_esquemas { set; get; }
        private static string _ruta_carvajal_certificado { set; get; }

          #region<REGION DE ENVIO XML AL SERVIDOR>
            public static void  _envia_xml(ref string _error)
            {
                _ruta_carvajal_xml = "D:\\INTERFA\\CARVAJAL\\XML";
                try
                {
                    string _ruta_carvajal_xml_copy = "D:\\INTERFA\\CARVAJAL\\XML\\copy\\";
                    string[] _archivos_xml = Directory.GetFiles(@_ruta_carvajal_xml, "*.xml");
                    if (!Directory.Exists(@_ruta_carvajal_xml_copy))
                    {
                        Directory.CreateDirectory(@_ruta_carvajal_xml_copy);
                    }

                    if (_archivos_xml.Length > 0)
                    {
                        for (Int32 a = 0; a < _archivos_xml.Length; ++a)
                        {
                            string _archivo = _archivos_xml[a].ToString();
                            string _nombrearchivo_xml = System.IO.Path.GetFileNameWithoutExtension(@_archivo);
                            byte[] _archivo_bytes = File.ReadAllBytes(@_archivo);

                            string _rutaenvio = ConfigurationManager.AppSettings["Proceso"].ToString();

                            if (_rutaenvio == "P")
                            {
                                ServiceBata.ws_bataSoapClient _valor = new ServiceBata.ws_bataSoapClient();
                                string _error_service = _valor.ws_envio_xml(_archivo_bytes, _nombrearchivo_xml);

                                if (_error_service == "1")
                                {
                                    string _archivo_copy = _ruta_carvajal_xml_copy + _nombrearchivo_xml + ".xml";
                                    File.Copy(@_archivo, @_archivo_copy, true);
                                    File.Delete(@_archivo);
                                }
                                else
                                {
                                    TextWriter tw = new StreamWriter(@"D:\INTERFA\CARVAJAL\XML\error.txt", true);
                                    tw.WriteLine("ERROR DE WEB SERVICE" + _error_service);
                                    tw.Flush();
                                    tw.Close();
                                    tw.Dispose();
                                    break;
                                }
                            }
                            else
                            {
                                ServiceBata.ws_bataSoapClient _valor = new ServiceBata.ws_bataSoapClient();
                                string _error_service = _valor.ws_envio_xml_desarrollo(_archivo_bytes, _nombrearchivo_xml);

                                if (_error_service == "1")
                                {
                                    string _archivo_copy = _ruta_carvajal_xml_copy + _nombrearchivo_xml + ".xml";
                                    File.Copy(@_archivo, @_archivo_copy, true);
                                    File.Delete(@_archivo);
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                    }
                }
                catch(Exception exc)
                {
                    _error = "CATCH DE ERROR" + exc.Message;
                    TextWriter tw = new StreamWriter(@"D:\INTERFA\CARVAJAL\XML\error.txt", true);
                    tw.WriteLine(_error);
                    tw.Flush();
                    tw.Close();
                    tw.Dispose();
                }
            }
                
                #endregion

    #endregion
        #region<METODOS PARA GENERAR EL CODIGO HASH>

        public static void _ejecuta_proceso(ref string _error)
        {
            _ruta_in_boleta = "D:\\INTERFA\\CARVAJAL\\IN\\Boletas";
            _ruta_in_factura = "D:\\INTERFA\\CARVAJAL\\IN\\Facturas";
            _ruta_in_credito = "D:\\INTERFA\\CARVAJAL\\IN\\creditos";
            _ruta_in_debito = "D:\\INTERFA\\CARVAJAL\\IN\\debitos";

            _ruta_carvajal_xml = "D:\\INTERFA\\CARVAJAL\\XML";
            _ruta_carvajal_mapa = "D:\\INTERFA\\CARVAJAL\\bata_proceso\\Mapas";
            _ruta_carvajal_esquemas = "D:\\INTERFA\\CARVAJAL\\bata_proceso\\Esquemas";
            _ruta_carvajal_certificado = "D:\\INTERFA\\CARVAJAL\\bata_proceso\\Certificado";
           
            string _carpeta_in = "";
            
            try
            {

                if (!Directory.Exists(@_ruta_in_boleta))
                {
                    Directory.CreateDirectory(@_ruta_in_boleta);
                }
                if (!Directory.Exists(@_ruta_in_factura))
                {
                    Directory.CreateDirectory(@_ruta_in_factura);
                }
                if (!Directory.Exists(@_ruta_in_credito))
                {
                    Directory.CreateDirectory(@_ruta_in_credito);
                }
                if (!Directory.Exists(@_ruta_in_debito))
                {
                    Directory.CreateDirectory(@_ruta_in_debito);
                }

                //***************************
                //configuracion por defecto de app config

                if (!Directory.Exists(@_ruta_carvajal_xml))
                {
                    Directory.CreateDirectory(@_ruta_carvajal_xml);
                }
                if (!Directory.Exists(@_ruta_carvajal_mapa))
                {
                    Directory.CreateDirectory(@_ruta_carvajal_mapa);
                }
                if (!Directory.Exists(@_ruta_carvajal_esquemas))
                {
                    Directory.CreateDirectory(@_ruta_carvajal_esquemas);
                }
                if (!Directory.Exists(@_ruta_carvajal_certificado))
                {
                    Directory.CreateDirectory(@_ruta_carvajal_certificado);
                }

                //ahora recorrer las carpetas in y verificas cuales son los archivo para la generacion de hash
                //verificar archivo
                string[] _rutas_in = { _ruta_in_boleta, _ruta_in_factura, _ruta_in_credito, _ruta_in_debito };

                //***********************************
                for (Int32 i = 0; i < _rutas_in.Length; ++i)
                {
                    string _tipo_doc = "";

                    switch (i)
                    {
                        case 0:
                            _tipo_doc = "BO";
                            break;
                        case 1:
                            _tipo_doc = "FA";
                            break;
                        case 2:
                            _tipo_doc = "NC";
                            break;
                        case 3:
                            _tipo_doc = "ND";
                            break;

                    }

                    _carpeta_in = _rutas_in[i].ToString();
                    string[] _archivos_txt = Directory.GetFiles(@_carpeta_in, "*.txt");

                    if (_archivos_txt.Length > 0)
                    {
                        for (Int32 a = 0; a < _archivos_txt.Length; ++a)
                        {

                            string ruta_archivo_hash = "";
                            string ruta_archivo_externo = "";
                            Int32 _ingreso = 0;
                            string codigo_hash = _retornar_codigo_hash(ref _error, ref ruta_archivo_hash, ref ruta_archivo_externo, ref _ingreso, _archivos_txt[a].ToString(), _tipo_doc, _rutas_in[i].ToString());
                            if (_ingreso == 0) return;
                            if (System.IO.File.Exists(@ruta_archivo_hash))
                            {
                                System.IO.File.Delete(@ruta_archivo_hash);
                            }

                            if (_error.Length == 0 && codigo_hash.Length > 0)
                            {
                                TextWriter tw = new StreamWriter(@ruta_archivo_hash, true);
                                tw.WriteLine("0," + codigo_hash);
                                tw.Flush();
                                tw.Close();
                                tw.Dispose();

                                //borrar archivo generado por externo
                                if (System.IO.File.Exists(@ruta_archivo_externo))
                                {
                                    System.IO.File.Delete(@ruta_archivo_externo);
                                }

                            }
                            else
                            {
                                TextWriter tw = new StreamWriter(@ruta_archivo_hash, true);
                                tw.WriteLine("1," + _error);
                                tw.Flush();
                                tw.Close();
                                tw.Dispose();

                                //en este paso vamos a usar el wf , para enviar el error al servidor con el archivo
                                string _nombrearchivo_txt = System.IO.Path.GetFileNameWithoutExtension(@ruta_archivo_externo);
                                string _tienda = _nombrearchivo_txt.Substring(1, 3);
                                byte[] _archivo_bytes_txt = File.ReadAllBytes(@ruta_archivo_externo);
                                ServiceBata.ws_bataSoapClient _error_genera_hash = new ServiceBata.ws_bataSoapClient();

                                string _error_service_txt = _error_genera_hash.ws_control_error(_archivo_bytes_txt, _tienda, _nombrearchivo_txt, _error);

                                if (_error_service_txt == "1")
                                {
                                    File.Delete(@ruta_archivo_externo);
                                }


                            }

                            

                        }

                    }                  
                }
                //**********************************

                //CambiaServidor("http://148.102.50.44/web_site_electronica/ws_bata.asmx");
                //CambiaServidor("http://10.10.10.208/web_site_electronica/ws_bata.asmx");

                //**********en este caso vamos a copiar los xml al servidor
              
                //*******************************

                //string ruta_archivo_hash = "";
                //string ruta_archivo_externo = "";
                //Int32 _ingreso = 0;
                //string codigo_hash = _retornar_codigo_hash(ref _error, ref ruta_archivo_hash, ref ruta_archivo_externo, ref _ingreso);
                //if (_ingreso == 0) return;
                //if (System.IO.File.Exists(@ruta_archivo_hash))
                //{
                //    System.IO.File.Delete(@ruta_archivo_hash);
                //}

                //if (_error.Length==0 &&  codigo_hash.Length>0)
                //{
                //    TextWriter tw = new StreamWriter(@ruta_archivo_hash, true);
                //    tw.WriteLine("0," + codigo_hash);
                //    tw.Flush();
                //    tw.Close();
                //    tw.Dispose();

                //    //borrar archivo generado por externo
                //    if (System.IO.File.Exists(@ruta_archivo_externo))
                //    {
                //        System.IO.File.Delete(@ruta_archivo_externo);
                //    }


                //}
                //else
                //{
                //    TextWriter tw = new StreamWriter(@ruta_archivo_hash, true);
                //    tw.WriteLine("1," + _error);
                //    tw.Flush();
                //    tw.Close();
                //    tw.Dispose();
                //}

            }
            catch(Exception exc)
            {
                _error ="CATCH DE ERROR" +  exc.Message;
                TextWriter tw = new StreamWriter(@"D:\INTERFA\CARVAJAL\XML\error.txt", true);
                tw.WriteLine(_error);
                tw.Flush();
                tw.Close();
                tw.Dispose();
            }
        }
        public static string _retornar_codigo_hash(ref string _error, ref string _ruta_archivo, ref string ruta_archivo_externo, ref Int32 _ingreso, string _archivo, string _tipo_doc, string _carpeta_in)
        {
            _ruta_in_boleta = "D:\\INTERFA\\CARVAJAL\\IN\\Boletas";
            _ruta_in_factura = "D:\\INTERFA\\CARVAJAL\\IN\\Facturas";
            _ruta_in_credito = "D:\\INTERFA\\CARVAJAL\\IN\\creditos";
            _ruta_in_debito = "D:\\INTERFA\\CARVAJAL\\IN\\debitos";

            _ruta_carvajal_xml = "D:\\INTERFA\\CARVAJAL\\XML";
            _ruta_carvajal_mapa = "D:\\INTERFA\\CARVAJAL\\bata_proceso\\Mapas";
            _ruta_carvajal_esquemas="D:\\INTERFA\\CARVAJAL\\bata_proceso\\Esquemas";
            _ruta_carvajal_certificado = "D:\\INTERFA\\CARVAJAL\\bata_proceso\\Certificado";

            string _valida_error = "";
            string _codigo_hash_return = "";
            //string _carpeta_in = "";
            string _nombrearchivo_txt = "";
            //string _archivo = "";
            Int32 _valida = 0;
            try
            {

                //verificar que las carpetas existan
                //estas carpetas son configuracion propia para bata
                //if (!Directory.Exists(@_ruta_in_boleta))
                //{
                //    Directory.CreateDirectory(@_ruta_in_boleta);
                //}
                //if (!Directory.Exists(@_ruta_in_factura))
                //{
                //    Directory.CreateDirectory(@_ruta_in_factura);
                //}
                //if (!Directory.Exists(@_ruta_in_credito))
                //{
                //    Directory.CreateDirectory(@_ruta_in_credito);
                //}
                //if (!Directory.Exists(@_ruta_in_debito))
                //{
                //    Directory.CreateDirectory(@_ruta_in_debito);
                //}

                ////***************************
                ////configuracion por defecto de app config

                //if (!Directory.Exists(@_ruta_carvajal_xml))
                //{
                //    Directory.CreateDirectory(@_ruta_carvajal_xml);
                //}
                //if (!Directory.Exists(@_ruta_carvajal_mapa))
                //{
                //    Directory.CreateDirectory(@_ruta_carvajal_mapa);
                //}
                //if (!Directory.Exists(@_ruta_carvajal_esquemas))
                //{
                //    Directory.CreateDirectory(@_ruta_carvajal_esquemas);
                //}
                //if (!Directory.Exists(@_ruta_carvajal_certificado))
                //{
                //    Directory.CreateDirectory(@_ruta_carvajal_certificado);
                //}

                //ahora recorrer las carpetas in y verificas cuales son los archivo para la generacion de hash
               //verificar archivo
                //string[] _rutas_in = { _ruta_in_boleta, _ruta_in_factura, _ruta_in_credito, _ruta_in_debito };
                
                //for (Int32 i=0;i<_rutas_in.Length;++i)
                //{
                    //string _tipo_doc = "";

                    //switch (i)
                    //{
                    //    case 0:
                    //        _tipo_doc = "BO";
                    //        break;
                    //    case 1:
                    //        _tipo_doc = "FA";
                    //        break;
                    //    case 2:
                    //        _tipo_doc = "NC";
                    //        break;
                    //    case 3:
                    //        _tipo_doc = "ND";
                    //        break;
                        
                    //}

                    // _carpeta_in=_rutas_in[i].ToString();
                    //string[] _archivos_txt = Directory.GetFiles(@_carpeta_in, "*.txt");

                    //if (_archivos_txt.Length>0)
                    //{
                        //for (Int32 a=0 ;a<_archivos_txt.Length;++a)
                        //{
                            //_archivo=_archivos_txt[a].ToString();

                           


                            //CAPTURAR DESDE LA RUTA EL ARCHIVO DEL FORMTO
                            StreamReader sr = new StreamReader(@_archivo, Encoding.Default);
                            string _formato_doc = sr.ReadToEnd();
                            sr.Close();

                          

                            //CERRAR LA INSTNACIA
                            _nombrearchivo_txt = System.IO.Path.GetFileNameWithoutExtension(@_archivo);

                            //instanciar la dll externa
                            string _codigo_hash = "";
                            _codigo_hash_return = "";
                            GeneratorCdp generator_cdp = new GeneratorCdp();

                            switch (_tipo_doc)
                            {
                                case "BO":
                                    _ingreso = 1;
                                    _codigo_hash = generator_cdp.GetHashForInvoiceCdp(_formato_doc);
                                    break;
                                case "FA":
                                    _ingreso = 1;
                                    _codigo_hash = generator_cdp.GetHashForInvoiceCdp(_formato_doc);
                                    break;
                                case "NC":
                                    _ingreso = 1;
                                    _codigo_hash = generator_cdp.GetHashForNoteCdp(_formato_doc);
                                    break;
                                case "ND":
                                    _ingreso = 1;
                                    _codigo_hash = generator_cdp.GetHashForNoteCdp(_formato_doc);
                                    break;
                            }


                            if (_codigo_hash.Length>0)
                            {

                                _codigo_hash_return = _codigo_hash;
                                _valida = 1;
                                //break;
                            }

                        //}

                    //}
                    //if (_valida > 0) break;
                //}

               
            }
            catch(Exception exc)
            {
                _valida_error = exc.Message;
            }

            ruta_archivo_externo = _carpeta_in;
            string _hash = _carpeta_in + "\\hash";
            //verificar que la carpeta hash exista
            if (_ingreso == 1)
            {
                if (!Directory.Exists(@_hash))
                {
                    Directory.CreateDirectory(@_hash);
                }
            }
            string _ruta_archivo_txt = _hash + "\\" + _nombrearchivo_txt + ".txt";
            _ruta_archivo = _ruta_archivo_txt;
            _error = _valida_error;
            ruta_archivo_externo = _archivo;
            //File.Create(@_ruta_archivo_txt);

            return _codigo_hash_return;
        }
        #endregion

        #region <MODIFICACION DEL APP.CONFIG WEB SERVICE>
        public static void CambiaServidor(string urlFinal)
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

        #region<generacion e impresion de Codigo QR>

        private static string impresora_tda = "Ticket";

        /// <summary>
        /// genera codigo QR en bytes
        /// </summary>
        /// <param name="str"></param>
        /// <param name="_error"></param>
        private static byte[] generaQR(string str)
        {
            byte[] QR = null;
            try
            {
                GeneratorCdp genqr = new GeneratorCdp();

                QR = genqr.GetImageQrCodeFromString(str);

            }
            catch
            {
                QR = null;                
            }
            return QR;
        }
        public static void ejecuta_impresion_qr(ref string _error)
        {
            string _ruta_in_boleta_qr = "D:\\INTERFA\\CARVAJAL\\IN\\Boletas\\QR";
            string _ruta_in_factura_qr = "D:\\INTERFA\\CARVAJAL\\IN\\Facturas\\QR";
            string _ruta_in_credito_qr = "D:\\INTERFA\\CARVAJAL\\IN\\creditos\\QR";
            string _ruta_in_debito_qr = "D:\\INTERFA\\CARVAJAL\\IN\\debitos\\QR";            
            string _carpeta_in = "";
            try
            {
                if (!Directory.Exists(@_ruta_in_boleta_qr))
                {
                    Directory.CreateDirectory(@_ruta_in_boleta_qr);
                }
                if (!Directory.Exists(@_ruta_in_factura_qr))
                {
                    Directory.CreateDirectory(@_ruta_in_factura_qr);
                }
                if (!Directory.Exists(@_ruta_in_credito_qr))
                {
                    Directory.CreateDirectory(@_ruta_in_credito_qr);
                }
                if (!Directory.Exists(@_ruta_in_debito_qr))
                {
                    Directory.CreateDirectory(@_ruta_in_debito_qr);
                }

                string[] _rutas_in = { _ruta_in_boleta_qr, _ruta_in_factura_qr, _ruta_in_credito_qr, _ruta_in_debito_qr };

                //***********************************
                for (Int32 i = 0; i < _rutas_in.Length; ++i)
                {
                    string _tipo_doc = "";

                    switch (i)
                    {
                        case 0:
                            _tipo_doc = "BO";
                            break;
                        case 1:
                            _tipo_doc = "FA";
                            break;
                        case 2:
                            _tipo_doc = "NC";
                            break;
                        case 3:
                            _tipo_doc = "ND";
                            break;

                    }

                    _carpeta_in = _rutas_in[i].ToString();
                    string[] _archivos_txt = Directory.GetFiles(@_carpeta_in, "*.txt");

                    if (_archivos_txt.Length > 0)
                    {
                        for (Int32 a = 0; a < _archivos_txt.Length; ++a)
                        {

                            string folder = _rutas_in[i].ToString();string file = _archivos_txt[a].ToString();

                            _error = genimpr(folder, file);

                            //_error = "erroreds";

                            if (_error.Length == 0 )
                            {
                                if (File.Exists(file))
                                {
                                    File.Delete(file);
                                }
                            }
                            else
                            {

                                string error_qr = folder + "\\error";

                                if (!Directory.Exists(error_qr))
                                {
                                    Directory.CreateDirectory(@error_qr);
                                }

                                string _nombrearchivo_qr = Path.GetFileNameWithoutExtension(@file);
                                string ruta_archivo_error = @error_qr + "//" + _nombrearchivo_qr + ".txt";

                                TextWriter tw = new StreamWriter(@ruta_archivo_error, true);
                                tw.WriteLine("1," + _error);
                                tw.Flush();
                                tw.Close();
                                tw.Dispose();
                            }
                            //}
                            //else
                            //{
                            //    TextWriter tw = new StreamWriter(@ruta_archivo_hash, true);
                            //    tw.WriteLine("1," + _error);
                            //    tw.Flush();
                            //    tw.Close();
                            //    tw.Dispose();

                            //}


                        }

                    }
                }


            }
            catch (Exception exc)
            {

                _error=exc.Message;
            }
        }

        private static string genimpr(string folder,string file)
        {
            string _error = "";
            try
            {

                Boolean tkregalo = false;

                CrearTicket tk = new CrearTicket();

                StreamReader sr = new StreamReader(@file, Encoding.Default);
                string _formato_doc = sr.ReadToEnd();
                sr.Close();

                /*verificar la cantidad de str array*/

                string[] str = Regex.Split(_formato_doc, "<td>");

                Int32 n_impre = 0;

                Byte[] qr =null;
                Image im = null;
                Bitmap bmp;

                if (str.Length>1)
                {
                    string cadenaQR = str[1].ToString().Trim();
                    qr = generaQR(cadenaQR);
                    im = byteArrayToImage(qr);
                    bmp = new Bitmap(im, new Size(100, 100));
                    tk.HeaderImage = bmp;

                    impresora_tda = str[3].Trim();
                }

                foreach(string cadena in str)
                {
                    string cad = "";
                    switch (n_impre)
                    {
                        /*si es varlor 0 entonces imprime el contenido*/
                        case 0:
                            cad = ReemplazarCaracteresEspeciales(cadena.TrimEnd());
                            cad = cad + "\n";
                            cad = cad + "\n";

                            RawPrinterHelper.SendStringToPrinter(impresora_tda, cad);
                            
                            break;
                        /*impresion de la data del qr*/
                        case 1:
                            //cad = cadena.Trim();
                            //Byte[] qr = generaQR(cad);
                            //Image im = byteArrayToImage(qr);
                            //Bitmap bmp = new Bitmap(im, new Size(100, 100));
                            //tk.HeaderImage = bmp;
                            tk.PrintQR(impresora_tda);
                            break;
                        /*si es que se abre gaveta*/
                        case 2:
                            cad = ReemplazarCaracteresEspeciales(cadena.Trim());
                            
                            if (cad=="1")
                            {
                                abrircajon();
                            }

                            break;
                        /*ticket de regalo*/
                        case 4:
                            cad = cadena;

                            if (cadena.Trim().Length>0)
                            {
                                tkregalo = true;
                                RawPrinterHelper.SendStringToPrinter(impresora_tda, cad);
                            }
                            break;
                    }

                   

                    n_impre += 1;
                }

                if (tkregalo)
                {
                    RawPrinterHelper.SendStringToPrinter(impresora_tda, "\x1B" + "d" + "\x07");
                    RawPrinterHelper.SendStringToPrinter(impresora_tda, "\x1B" + "m");
                }

                //if (str.Length>0)
                //{
                //    if (str.Count()==4)
                //    {
                //        string valida_str = str[3].ToString().Trim();

                //        if (valida_str.Length>0)
                //        {
                //            /*cortar papel*/
                //            RawPrinterHelper.SendStringToPrinter(impresora_tda, "\x1B" + "d" + "\x07");
                //            RawPrinterHelper.SendStringToPrinter(impresora_tda, "\x1B" + "m");
                //        }
                        
                //    }
                //}


            }
            catch (Exception exc)
            {

                _error = exc.Message;
            }
            return _error;
        }
        private static Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        private static void abrircajon()
        {
            try
            {
                RawPrinterHelper.SendStringToPrinter(impresora_tda, "\x1B" + "p" + "\x00" + "\x0F" + "\x96");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static string[] caracteres =
        {
        "§","°",
        " ","á",
        "‚","é",
        "¡","í",
        "¢","ó",
        "£","ú",
        "µ","Á",
        " ","É",
        "Ö","Í",
        "à","Ó",
        "é","Ú",
        "¥","Ñ",
        "¤","ñ",       
    };
        private static string ReemplazarCaracteresEspeciales(string origen)
        {
            string destino = "";
            List<string> listCaracteres = new List<string>();
            for (int i = 0; i < origen.Length; i++)
            {
                listCaracteres.Add(origen[i].ToString());
            }

            for (int i = 0; i < listCaracteres.Count; i++)
            {
                for (int j = 0; j < caracteres.Length; j = j + 2)
                {
                    if (listCaracteres[i] == caracteres[j])
                    {
                        listCaracteres[i] = listCaracteres[i].Replace(listCaracteres[i], caracteres[j + 1]);
                        j = caracteres.Length + 1;
                    }
                }
            }

            for (int i = 0; i < listCaracteres.Count; i++)
            {
                destino = destino + listCaracteres[i];
            }

            return destino;
        }
        #endregion

    }
}
