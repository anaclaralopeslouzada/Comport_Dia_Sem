using System;

namespace Comport_Dia_Sem
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorSemanal gerenciador = new GerenciadorSemanal();
            string usuario = "Ana";
            string infoAdicional = "Implementar relatório";

            Console.WriteLine("execução entrada autimatica");
            string diaAtual = gerenciador.ObterDiaAtual();
            IEstrategiaDiaSemana estrategiaAtual = gerenciador.ObterEstrategia(diaAtual);
            Console.WriteLine($"Usuário: {usuario}");
            Console.WriteLine($"Dia detectado hoje: {diaAtual}");
            Console.WriteLine($"Prioridade: {estrategiaAtual.ObterPrioridade()}");
            Console.WriteLine($"Mensagem: {estrategiaAtual.Executar(infoAdicional)}");

            Console.WriteLine("\nexecução manual");
            if (args.Length > 0)
            {
                
                string diaConsultado = args[0];
                IEstrategiaDiaSemana estrategiaManual = gerenciador.ObterEstrategia(diaConsultado);
                
                Console.WriteLine($"Usuário: {usuario}");
                Console.WriteLine($"Dia consultado: {diaConsultado}");
                Console.WriteLine($"Prioridade: {estrategiaManual.ObterPrioridade()}");
                Console.WriteLine($"Mensagem: {estrategiaManual.Executar(infoAdicional)}\n");
            }
            else
            {
                Console.WriteLine("Nenhum dia foi passado como argumento.");
                Console.WriteLine("Dica: Para testar a execução manual, passe o dia no comando.");
                Console.WriteLine("Exemplo: dotnet run \"quarta-feira\" ou dotnet run feriado\n");
            }
        }
    }
}