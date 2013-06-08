using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace PGENL0006
{
    public class CDI_L_MensajeSocket
    {
        public void CDI_P_Enviar(TcpClient cliente, String Dato)
        {
            try
            {
                NetworkStream netstream = cliente.GetStream();
                StreamWriter escribir = new StreamWriter(netstream);
                escribir.WriteLine(Dato);
                escribir.Flush();
            }
            catch (Exception) { }
        }
        public String CDI_F_Recibir(TcpClient cliente)
        {
            try
            {
                NetworkStream netstream = cliente.GetStream();
                StreamReader leer = new StreamReader(netstream);

                return leer.ReadLine();
            }
            catch (Exception) { return ""; }
        }
    }
}
