using System;
using System.Collections.Generic;

namespace Comport_Dia_Sem
{
    public class GerenciadorSemanal
    {
        private readonly Dictionary<string, IEstrategiaDiaSemana> _estrategias;
        private readonly Dictionary<DayOfWeek, string> _diasPorExtenso;

        public GerenciadorSemanal()
        {
            _estrategias = new Dictionary<string, IEstrategiaDiaSemana>
            {
                { "segunda-feira", new EstrategiaSegunda() },
                { "terça-feira", new EstrategiaTerca() },
                { "quarta-feira", new EstrategiaQuarta() },
                { "quinta-feira", new EstrategiaQuinta() },
                { "sexta-feira", new EstrategiaSexta() },
                { "sábado", new EstrategiaSabado() },
                { "domingo", new EstrategiaDomingo() }
            };

            _diasPorExtenso = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Monday, "segunda-feira" },
                { DayOfWeek.Tuesday, "terça-feira" },
                { DayOfWeek.Wednesday, "quarta-feira" },
                { DayOfWeek.Thursday, "quinta-feira" },
                { DayOfWeek.Friday, "sexta-feira" },
                { DayOfWeek.Saturday, "sábado" },
                { DayOfWeek.Sunday, "domingo" }
            };
        }

        public string ObterDiaAtual()
        {
            return _diasPorExtenso[DateTime.Now.DayOfWeek];
        }

        public IEstrategiaDiaSemana ObterEstrategia(string dia)
        {
            if (string.IsNullOrWhiteSpace(dia)) return new EstrategiaNull();
            
            string diaFormatado = dia.Trim().ToLower();
            
            // Se encontrar o dia, retorna a estratégia dele. Se não, retorna o objeto nulo
            return _estrategias.TryGetValue(diaFormatado, out var estrategia) 
                ? estrategia 
                : new EstrategiaNull();
        }
    }
}