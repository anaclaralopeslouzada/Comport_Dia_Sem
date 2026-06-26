namespace ExercicioStrategy
{
    public interface IEstrategiaDiaSemana
    {
        string Executar(string informacaoAdicional);
        string ObterPrioridade();
    }
}