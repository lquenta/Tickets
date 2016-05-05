﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TNT.WebSintesis_externo;
using System.Globalization;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace TNT.helpers
{
    public static class RC4
    {
        public static string allegedrc4(string codigo, string llavellegada)
        {
            int[] State = new int[256 + 1];
            string Mensaje = String.Empty;
            string llave = String.Empty;
            string MsgCif = String.Empty;
            int X = 0;
            int Y = 0;
            int Index1 = 0;
            int Index2 = 0;
            int NMen = 0;
            int i = 0;
            short op1 = 0;
            int aux = 0;
            int op2 = 0;
            string nrohex = String.Empty;


            X = 0;
            Y = 0;
            Index1 = 0;
            Index2 = 0;
            Mensaje = codigo;
            llave = llavellegada;
            for (i = 0; i <= 255.0; i += 1)
            {
                State[i] = i;
            }
            for (i = 0; i <= 255.0; i += 1)
            {
                op1 = (short)(llave.Substring(Index1 + 1 - 1, 1)[0]);
                Index2 = (op1 + State[i] + Index2) % 256;
                aux = State[i];
                State[i] = State[Index2];
                State[Index2] = aux;
                Index1 = (Index1 + 1) % llave.Length;
            }
            for (i = 0; i <= Mensaje.Length - 1; i += 1)
            {
                X = (X + 1) % 256;
                Y = (State[X] + Y) % 256;
                aux = State[X];
                State[X] = State[Y];
                State[Y] = aux;
                op1 = (short)(Mensaje.Substring(i + 1 - 1, 1)[0]);
                op2 = State[(State[X] + State[Y]) % 256];
                NMen = op1 ^ op2;
                nrohex = NMen.ToString("X");
                if (nrohex.Length == 1)
                {
                    nrohex = "0" + nrohex;
                }
                MsgCif = MsgCif + nrohex;
            }
            MsgCif = MsgCif.Substring(MsgCif.Length - (MsgCif.Length));
            return MsgCif;
        }

        public static string Encrypt(string key, string data)
        {

            Encoding unicode = Encoding.UTF8;

            return Convert.ToBase64String(Encrypt(unicode.GetBytes(key), unicode.GetBytes(data)));
        }

        public static string Decrypt(string key, string data)
        {
            Encoding unicode = Encoding.ASCII;

            return unicode.GetString(Encrypt(unicode.GetBytes(key), Convert.FromBase64String(data)));
        }

        public static byte[] Encrypt(byte[] key, byte[] data)
        {
            return EncryptOutput(key, data).ToArray();
        }

        public static byte[] Decrypt(byte[] key, byte[] data)
        {
            return EncryptOutput(key, data).ToArray();
        }

        private static byte[] EncryptInitalize(byte[] key)
        {
            byte[] s = Enumerable.Range(0, 256)
              .Select(i => (byte)i)
              .ToArray();

            for (int i = 0, j = 0; i < 256; i++)
            {
                j = (j + key[i % key.Length] + s[i]) & 255;

                Swap(s, i, j);
            }

            return s;
        }

        private static IEnumerable<byte> EncryptOutput(byte[] key, IEnumerable<byte> data)
        {
            byte[] s = EncryptInitalize(key);

            int i = 0;
            int j = 0;

            return data.Select((b) =>
            {
                i = (i + 1) & 255;
                j = (j + s[i]) & 255;

                Swap(s, i, j);

                return (byte)(b ^ s[(s[i] + s[j]) & 255]);
            });
        }

        private static void Swap(byte[] s, int i, int j)
        {
            byte c = s[i];

            s[i] = s[j];
            s[j] = c;
        }
    }
    public static class Verhoeff
    {
        // The multiplication table
        static int[,] d = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 
            {1, 2, 3, 4, 0, 6, 7, 8, 9, 5}, 
            {2, 3, 4, 0, 1, 7, 8, 9, 5, 6}, 
            {3, 4, 0, 1, 2, 8, 9, 5, 6, 7}, 
            {4, 0, 1, 2, 3, 9, 5, 6, 7, 8}, 
            {5, 9, 8, 7, 6, 0, 4, 3, 2, 1}, 
            {6, 5, 9, 8, 7, 1, 0, 4, 3, 2}, 
            {7, 6, 5, 9, 8, 2, 1, 0, 4, 3}, 
            {8, 7, 6, 5, 9, 3, 2, 1, 0, 4}, 
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };

        // The permutation table
        static int[,] p = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 
            {1, 5, 7, 6, 2, 8, 3, 0, 9, 4}, 
            {5, 8, 0, 3, 7, 9, 6, 1, 4, 2}, 
            {8, 9, 1, 6, 0, 4, 3, 5, 2, 7}, 
            {9, 4, 5, 3, 1, 2, 6, 8, 7, 0}, 
            {4, 2, 8, 6, 5, 7, 3, 9, 0, 1}, 
            {2, 7, 9, 3, 8, 0, 6, 4, 1, 5}, 
            {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };

        // The inverse table
        static int[] inv = { 0, 4, 3, 2, 1, 5, 6, 7, 8, 9 };


        /// <summary>
        /// Validates that an entered number is Verhoeff compliant.
        /// NB: Make sure the check digit is the last one!
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if Verhoeff compliant, otherwise false</returns>
        public static bool validateVerhoeff(string num)
        {
            int c = 0;
            int[] myArray = StringToReversedIntArray(num);

            for (int i = 0; i < myArray.Length; i++)
            {
                c = d[c, p[(i % 8), myArray[i]]];
            }

            return c == 0;

        }

        /// <summary>
        /// For a given number generates a Verhoeff digit
        /// Append this check digit to num
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Verhoeff check digit as string</returns>
        public static string generateVerhoeff(string num)
        {
            int c = 0;
            int[] myArray = StringToReversedIntArray(num);

            for (int i = 0; i < myArray.Length; i++)
            {
                c = d[c, p[((i + 1) % 8), myArray[i]]];
            }

            return inv[c].ToString();
        }

        public static string generateVerhoeff_iterative(string num, int iterations)
        {
            if (iterations == 1)
            {
                return generateVerhoeff(num);
            }
            else
            {
                string verhoeff = generateVerhoeff(num);
                verhoeff = verhoeff + generateVerhoeff_iterative(num + verhoeff, iterations - 1);

                return verhoeff;
            }
        }


        /// <summary>
        /// Converts a string to a reversed integer array.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Reversed integer array</returns>
        private static int[] StringToReversedIntArray(string num)
        {
            int[] myArray = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                myArray[i] = int.Parse(num.Substring(i, 1));
            }

            Array.Reverse(myArray);

            return myArray;

        }
    }
    public class DecimalModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext,
            ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);
            ModelState modelState = new ModelState { Value = valueResult };
            object actualValue = null;
            try
            {
                actualValue = Convert.ToDecimal(valueResult.AttemptedValue,
                    CultureInfo.CurrentCulture);
            }
            catch (FormatException e)
            {
                modelState.Errors.Add(e);
            }

            bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
            return actualValue;
        }
    }

    public class Helpers
    {
        public static string Generar_codigo_recaudacion(string iniciales)
        {
            int length = 5;
            Random random = new Random();
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            var chars = "0123456789";
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            result = "TNT" + fecha + iniciales + result;
            return result;
        }
        public static string Generar_codigo_ticket(int length, Random random)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            //result = CryptoClass.Encrypt(result, System.Configuration.ConfigurationManager.AppSettings["passphrase"]);
            return result;
        }
        public static string Generar_pass_temporal(int length, Random random)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            //result = CryptoClass.Encrypt(result, System.Configuration.ConfigurationManager.AppSettings["passphrase"]);
            return result;
        }
        public static string ConvertToBase64(int numero)
        {
            string[] diccionario = new string[64] {
                "0", "1", "2", "3", "4", "5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K" ,"L","M","N","O","P","Q","R","S","T","U","V" ,"W","X","Y","Z","a","b","c","d","e","f","g" ,"h","i","j","k","l","m","n","o","p","q","r" ,"s","t","u","v","w","x","y","z","+","/"
              };
            int cociente = 1; int resto; string palabra = "";
            while (cociente > 0)
            {
                cociente = numero / 64;
                resto = numero % 64;
                palabra = diccionario[resto] + palabra;
                numero = cociente;

            }
            return (palabra);
        }
        public static Byte[] PdfSharpConvert(String html)
        {
            Byte[] res = null;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }
            return res;
        }
        public static bool EnviarMail(string email_from, string from, string email_to, string to, string subject, string contenido, byte[] attach)
        {
            bool enviado = false;
            try
            {
                MailMessage mailMsg = new MailMessage();

                // To
                mailMsg.To.Add(new MailAddress(email_to, to));

                // From
                mailMsg.From = new MailAddress(email_from, from);

                // Subject and multipart/alternative Body
                mailMsg.Subject = subject;
                //string text = "text body";
                string html = contenido;
                //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
                mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));
                if (attach != null)
                {
                    string filename = "tickets.pdf";
                    Attachment attach_item = new Attachment(new System.IO.MemoryStream(attach), filename);
                    mailMsg.Attachments.Add(attach_item);
                }
                // Init SmtpClient and send
                SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("lquenta", "aspire4520");
                smtpClient.Credentials = credentials;
                smtpClient.Send(mailMsg);
                enviado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return enviado;
        }

        public static string Obtener_codigo_control(string numeroAutorizacion, string numeroFactura, string nitCliente, string fechaTransaccion, string montoTransaccion, string llaveTransaccion)
        {
            string codigoControl = "";
            montoTransaccion = Math.Round(Convert.ToDecimal(montoTransaccion), 0).ToString();
            //1erPaso añadir verhoeff 2 diitos a cada uno
            numeroFactura = numeroFactura + Verhoeff.generateVerhoeff_iterative(numeroFactura, 2);
            //numeroFactura = numeroFactura + Verhoeff.generateVerhoeff(numeroFactura);
            nitCliente = nitCliente + Verhoeff.generateVerhoeff_iterative(nitCliente, 2);
            fechaTransaccion = fechaTransaccion + Verhoeff.generateVerhoeff_iterative(fechaTransaccion, 2);
            montoTransaccion = montoTransaccion + Verhoeff.generateVerhoeff_iterative(montoTransaccion, 2);
            //2. efectuar la sumatoria
            long sumatoria = long.Parse(numeroFactura) + long.Parse(nitCliente) + long.Parse(fechaTransaccion) + long.Parse(montoTransaccion);

            //2. generar 5 digitos verhoeff
            string num5Verhoeff = Verhoeff.generateVerhoeff_iterative(sumatoria.ToString(), 5);
            //3. del numero verhoeff concatenar digitos de la llave de transaccion
            int longitudD1 = Convert.ToInt32(num5Verhoeff.Substring(0, 1)) + 1;
            int longitudD2 = Convert.ToInt32(num5Verhoeff.Substring(1, 1)) + 1;
            int longitudD3 = Convert.ToInt32(num5Verhoeff.Substring(2, 1)) + 1;
            int longitudD4 = Convert.ToInt32(num5Verhoeff.Substring(3, 1)) + 1;
            int longitudD5 = Convert.ToInt32(num5Verhoeff.Substring(4, 1)) + 1;
            numeroAutorizacion = numeroAutorizacion + llaveTransaccion.Substring(0, longitudD1);
            numeroFactura = numeroFactura + llaveTransaccion.Substring(longitudD1, longitudD2);
            nitCliente = nitCliente + llaveTransaccion.Substring(longitudD1 + longitudD2, longitudD3);
            fechaTransaccion = fechaTransaccion + llaveTransaccion.Substring(longitudD1 + longitudD2 + longitudD3, longitudD4);
            montoTransaccion = montoTransaccion + llaveTransaccion.Substring(longitudD1 + longitudD2 + longitudD3 + longitudD4, longitudD5);
            string concatenarV1 = numeroAutorizacion + numeroFactura + nitCliente + fechaTransaccion + montoTransaccion;
            string llaveConcatenadaV1 = llaveTransaccion + num5Verhoeff;
            //4. aplicar AllegedRC4 con la cadena y la llave
            string allegedRC4V1 = RC4.allegedrc4(concatenarV1, llaveConcatenadaV1);
            //string allegedRC4V1 = RC4.Encrypt(llaveConcatenadaV1,concatenarV1);
            //5. sumatoria en ascii y sumatoria de dividendos
            byte[] ASCIIValues = System.Text.Encoding.ASCII.GetBytes(allegedRC4V1);
            int sumatoriaASCII = 0;
            foreach (byte b in ASCIIValues)
            {
                sumatoriaASCII += Convert.ToInt32(b);

            }
            int sumatoria1 = 0;
            int sumatoria2 = 0;
            int sumatoria3 = 0;
            int sumatoria4 = 0;
            int sumatoria5 = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i - 1; j < ASCIIValues.Length; j += 5)
                {
                    switch (i)
                    {
                        case 1:
                            sumatoria1 += ASCIIValues[j];
                            break;
                        case 2:
                            sumatoria2 += ASCIIValues[j];
                            break;
                        case 3:
                            sumatoria3 += ASCIIValues[j];
                            break;
                        case 4:
                            sumatoria4 += ASCIIValues[j];
                            break;
                        case 5:
                            sumatoria5 += ASCIIValues[j];
                            break;
                        default:
                            break;
                    }

                }
            }
            sumatoria1 = (sumatoriaASCII * sumatoria1) / longitudD1;
            sumatoria2 = (sumatoriaASCII * sumatoria2) / longitudD2;
            sumatoria3 = (sumatoriaASCII * sumatoria3) / longitudD3;
            sumatoria4 = (sumatoriaASCII * sumatoria4) / longitudD4;
            sumatoria5 = (sumatoriaASCII * sumatoria5) / longitudD5;
            int sumatoriaFinal = sumatoria1 + sumatoria2 + sumatoria3 + sumatoria4 + sumatoria5;
            //6. convertir sumatoria en base64
            string base64 = ConvertToBase64(sumatoriaFinal);
            //7. convertir a alleged rc4 llave de cifrado con digitos verhoeff usando como clave el base64 obtenido
            string llaveCifrado = llaveTransaccion + num5Verhoeff;
            codigoControl = RC4.allegedrc4(base64, llaveCifrado);
            return codigoControl;

        }
        public static bool Envio_sintesis_compra_simple(string codigo_recaudacion, string email_cliente, string nombre_cliente, string nit_cliente, string nombre_evento, string nombre_empresa, string nit_empresa, double montoTicket, double comision)
        {
            ComelecSoapClient cli = new ComelecSoapClient();
            DatosPlanilla datosPlanilla = new DatosPlanilla();
            DPlanilla[] dPlanilla = new DPlanilla[2];
            RespPlanilla respPlanilla = new RespPlanilla();
            DateTime now_date = new DateTime();


            datosPlanilla.codigoCliente = "1";
            datosPlanilla.codigoEmpresa = 321;
            datosPlanilla.codigoProducto = "1";
            datosPlanilla.codigoRecaudacion = codigo_recaudacion;
            datosPlanilla.correoElectronico = email_cliente;
            datosPlanilla.descripcionRecaudacion = "COMPRA TICKETS"; //SACAR DE CONFIG
            datosPlanilla.fecha = Int32.Parse(now_date.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture));
            datosPlanilla.hora = Int32.Parse(now_date.ToString("hhmmss", System.Globalization.CultureInfo.InvariantCulture));
            datosPlanilla.fechaVencimiento = 0;
            datosPlanilla.horaVencimiento = 0;
            datosPlanilla.moneda = "BS";
            datosPlanilla.nombre = nombre_cliente;
            datosPlanilla.nit_CI_cliente = nit_cliente;
            datosPlanilla.transaccion = "A";

            dPlanilla[0] = new DPlanilla();
            dPlanilla[0].numeroPago = 1;
            dPlanilla[0].descripcion = nombre_evento;
            dPlanilla[0].nombreFactura = nombre_empresa;
            dPlanilla[0].nitFactura = nit_empresa;
            dPlanilla[0].montoPago = montoTicket;
            dPlanilla[0].montoCreditoFiscal = 0;

            dPlanilla[1] = new DPlanilla();
            dPlanilla[1].numeroPago = 1;
            dPlanilla[1].descripcion = "Comision"; // TODO : SACAR DE CONFIG
            dPlanilla[1].nombreFactura = "YGDRASSIL"; //TODO : SACAR DE CONFIG
            dPlanilla[1].nitFactura = "111111119"; // SACAR DE CONFIG
            dPlanilla[1].montoPago = comision;
            dPlanilla[1].montoCreditoFiscal = comision;

            datosPlanilla.planillas = dPlanilla;
            try
            {
                respPlanilla = cli.cmeRegistroPlan(datosPlanilla, "wsiggdrasil");
            }
            catch (Exception ex)
            {
                return false;
            }

            if (respPlanilla.codError == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}