using System;
using CommandSolucao.devices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.Commands
{
    internal class LigarArCondicionado : Command
    {
        private ArCondicionado arCondicionado;

        public LigarArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
        }

        public void desfazer()
        {
            this.arCondicionado.desligar();
            this.arCondicionado.toString();
        }

        public void executar()
        {
            this.arCondicionado.ligar();
            this.arCondicionado.toString();
        }
    }
}
