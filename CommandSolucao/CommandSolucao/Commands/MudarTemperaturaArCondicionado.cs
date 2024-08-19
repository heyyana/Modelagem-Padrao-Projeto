using CommandSolucao.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSolucao.Commands
{
    public class MudarTemperaturaArCondicionado : Command
    {
        private ArCondicionado arCondicionado;
        private int temperatura;
        private int temperaturaAnterior;

        public MudarTemperaturaArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
            this.temperatura = arCondicionado.getTemperatura();
        }

        public void setTemperatura(int temperatura)
        {
            this.temperaturaAnterior = this.temperatura;
            this.temperatura = temperatura;
        }

        public void desfazer()
        {
            this.arCondicionado.setTemperatura(this.temperaturaAnterior);
            this.arCondicionado.toString();
        }

        public void executar()
        {
            this.arCondicionado.setTemperatura(this.temperatura);
            this.arCondicionado.toString();
        }
    }
}