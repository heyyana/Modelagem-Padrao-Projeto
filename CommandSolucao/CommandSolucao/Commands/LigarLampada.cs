using CommandSolucao.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.Commands
{
    internal class LigarLampada : Command
    {
        private Lampada lampada;

        public LigarLampada(Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void desfazer()
        {
            this.lampada.desligar();
            this.lampada.toString();
        }

        public void executar()
        {
            this.lampada.ligar();
            this.lampada.toString();
        }
    }
}
