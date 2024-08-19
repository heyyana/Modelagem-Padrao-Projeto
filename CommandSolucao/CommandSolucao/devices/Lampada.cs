using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.devices
{
    public class Lampada
    {
        public String identificacao {  get; set; }
        public Boolean estado { get; set; }

        public Lampada(String identificacao, bool estado)
        {
            this.identificacao = identificacao;
            this.estado = estado;
        }

        public void ligar()
        {
            this.estado = true;
        }

        public void desligar()
        {
            this.estado = false; 
        }

        public String getIdentificacao()
        {
            return this.identificacao;
        }

        public Boolean getEstado()
        {
            return this.estado;
        }

        public void toString()
        {
            String texto = $"O dispositivo {this.identificacao} esta {(this.estado ? "ligado" : "desligado")}";
            Console.WriteLine( texto );
        }
    }
}
