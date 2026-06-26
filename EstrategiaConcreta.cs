namespace Comport_Dia_Sem
{
    public class EstrategiaSegunda : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de focar: organize suas prioridades para a tarefa '{info}'.";
        public string ObterPrioridade() => "ALTA";
    }

    public class EstrategiaTerca : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de produção: avance nas tarefas pendentes, foque em '{info}'.";
        public string ObterPrioridade() => "ALTA";
    }

    public class EstrategiaQuarta : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de revisão: verifique o andamento da atividade '{info}'.";
        public string ObterPrioridade() => "MÉDIA";
    }

    public class EstrategiaQuinta : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de trabalho em equipe: colabore com alguém da equipe em '{info}'.";
        public string ObterPrioridade() => "MÉDIA";
    }

    public class EstrategiaSexta : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de fechamento: registre o que foi concluído sobre '{info}'.";
        public string ObterPrioridade() => "MÉDIA";
    }

    public class EstrategiaSabado : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de descanso ou estudo livre. Meta/Estudo da vez: '{info}'.";
        public string ObterPrioridade() => "BAIXA";
    }

    public class EstrategiaDomingo : IEstrategiaDiaSemana
    {
        public string Executar(string info) => $"Dia de preparação: planeje a próxima semana focado em '{info}'.";
        public string ObterPrioridade() => "BAIXA";
    }
}