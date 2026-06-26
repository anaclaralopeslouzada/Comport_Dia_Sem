namespace Comport_Dia_Sem
{
    public interface IEstrategiaDiaSemana
    {
        string Executar(string informacaoAdicional);
        string ObterPrioridade();
    }
}