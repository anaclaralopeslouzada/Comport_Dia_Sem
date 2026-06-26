namespace Comport_Dia_Sem
{
    public class EstrategiaNull : IEstrategiaDiaSemana
    {
        public string Executar(string info) => "Dia não reconhecido ou sem atividade agendada. Nenhuma ação necessária.";
        public string ObterPrioridade() => "NENHUMA";
    }
}
