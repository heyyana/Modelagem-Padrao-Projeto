using CommandSolucao;
using CommandSolucao.devices;
using CommandSolucao.Commands;

Lampada lampadaSala = new Lampada("Lampada sala", false);
Lampada lampadaQuarto = new Lampada("Lampada quarto", false);
ArCondicionado ar = new ArCondicionado("Ar Condicionado", false, 26);

Aplicativo meuApp = new Aplicativo();

Command ligarLampadaSala = new LigarLampada(lampadaSala);
Command desligarLampadaSala = new DesligarLampada(lampadaSala);

Command ligarLampadaQuarto = new LigarLampada(lampadaQuarto);
Command desligarLampadaQuarto = new DesligarLampada(lampadaQuarto);

Command ligarAr = new LigarArCondicionado(ar);
Command desligarAr = new DesligarArCondicionado(ar);
Command mudarTemperatura = new MudarTemperaturaArCondicionado(ar);

int idLigarLampadaSala = meuApp.setComando(ligarLampadaSala);
int idDesligarLampadaSala = meuApp.setComando(desligarLampadaQuarto);

int idLigarLampadaQuarto = meuApp.setComando(ligarLampadaQuarto);
int idDesligarLampadaQuarto = meuApp.setComando(desligarLampadaQuarto);

int idLigarAr = meuApp.setComando(ligarAr);
int idDesligarAr = meuApp.setComando(desligarAr);
int idMudarTemperatura = meuApp.setComando(mudarTemperatura);

meuApp.aoPrecionarBotao(idLigarLampadaSala);
meuApp.aoPrecionarBotao(idDesligarLampadaSala);

meuApp.aoPrecionarBotao(idLigarLampadaQuarto);
meuApp.aoPrecionarBotao(idDesligarLampadaQuarto);

meuApp.aoPrecionarBotao(idLigarAr);
((MudarTemperaturaArCondicionado)meuApp.getCommando(idMudarTemperatura)).setTemperatura(25);
meuApp.aoPrecionarBotao(idMudarTemperatura);
meuApp.aoPrecionarBotao(idDesligarAr);

meuApp.duploCliqueBotao(idDesligarAr);
meuApp.duploCliqueBotao(idMudarTemperatura);
meuApp.duploCliqueBotao(idLigarAr);
meuApp.duploCliqueBotao(idDesligarLampadaQuarto);

