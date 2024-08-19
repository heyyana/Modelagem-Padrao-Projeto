using CommandSolucao.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.Commands
{
    internal class DesligarArCondicionado : Command
    {
        private ArCondicionado arCondicionado;

        public DesligarArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
        }

        public void desfazer()
        {
            this.arCondicionado.ligar();
            this.arCondicionado.toString();
        }

        public void executar()
        {
            this.arCondicionado.desligar();
            this.arCondicionado.toString();
        }
    }
}
