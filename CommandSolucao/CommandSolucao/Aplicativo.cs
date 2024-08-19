using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSolucao.Commands;

namespace CommandSolucao
{
    public class Aplicativo
    {
        private List<Command> comandos = new List<Command>();

        public int setComando(Command comando)
        {
            this.comandos.Add(comando);
            return comandos.Count-1;
        }

        public void aoPrecionarBotao(int id)
        {
            this.comandos[id].executar();
        }

        public void duploCliqueBotao(int id)
        {
            this.comandos[id].desfazer();
        }

        public Command getCommando (int id)
        {
            return this.comandos[id];
        }
    }
}
