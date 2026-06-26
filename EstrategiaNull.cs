namespace Comport_Dia_Sem
{
    public class EstrategiaNull : IEstrategiaDiaSemana
    {
        public string Executar(string info) => "Dia não reconhecido ou sem atividade agendada. Nenhuma ação necessária.\nDias da semana possíveis: segunda-feira, terça-feira, quarta-feira, quinta-feira, sexta-feira, sábado, domingo.";
        public string ObterPrioridade() => "NENHUMA";
    }
}
