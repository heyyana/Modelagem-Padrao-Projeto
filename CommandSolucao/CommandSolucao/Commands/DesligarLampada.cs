using CommandSolucao.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.Commands
{
    internal class DesligarLampada : Command
    {
        private Lampada lampada;

        public DesligarLampada(Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void desfazer()
        {
            this.lampada.ligar();
            this.lampada.toString();
        }

        public void executar()
        {
            this.lampada.desligar();
            this.lampada.toString();
        }
    }
}
