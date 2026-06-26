# Exercicio - Comportamento por dia da semana
Este projeto é uma aplicação Console em C# que utiliza programação orientada a objetos para delegar ações baseadas no dia da semana. O sistema identifica automaticamente o dia atual e também permite consultas manuais, eliminando o uso de estruturas condicionais extensas (como `if/else` ou `switch/case`).

## Instruções de Uso
O projeto foi configurado para receber o dia da semana via argumentos de linha de comando para a execução manual, além de rodar automaticamente para o dia atual.

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.
2. Clone este repositório e abra o terminal na pasta raiz do projeto.
3. Para executar o programa (o dia atual será detectado automaticamente), utilize o comando passando o dia desejado como argumento:

**Para testar um dia válido:**
```bash
dotnet run "quarta-feira"
```

**Para testar uma entrada inválida ou inexistente**
```bash
dotnet run feriado
```

## Estrutura das Estratégias 
Para o projeto utilizamos o padrão Strategy, com uma estrutura de dicionário.
- Interface (`IEstrategiaDiaSemana`) : Define o contrato padrão com os métodos `Executar` e `ObterPrioridade`
- Estrategias Concretas (`EstrategiaSegunda`, `EstrategiaTerça`, ...) : Classes que implementam a interface, contém a lógica, mensagens e prioridades especíifcas de cada dia.
- `EstrategiaNull`: Representa a ausência de comportamento.
- `GerenciadorSemanal` : Funciona como o context da estratégia. Mapeia os nomes dos dias para suas classes em memória.

## Questões de Reflexão:

1. **Como evitar verificações repetidas de valores nulos no código principal?**
Garantir que o método responsável por fornecer a estratégia nunca retorne nulo. Adotando o padrão NullObject o sistema retorna uma instância válida com um comportamento neutro, permitindo que o código principal chame o metodo de execução com segurança.

2. **Qual padrão de projeto pode ser utilizado para representar a ausência de uma estratégia de forma segura?**
O padrão de projeto adequado é o Null Object.

3. **Explique brevemente como esse padrão seria incorporado à solução**
O padrão Null Object foi incorporado através da criação da classe `EstrategiaNull`, que implementa a interface `IEstrategiaDiaSemana`. No `GerenciadorSemanal`, se o método `ObterEstrategia(string dia)` não encontrar a chave informada pelo usuário no dicionário, ele retorna a instância de `EstrategiaNull`. Ao ser executada pelo programa principal, essa classe retorna mensagens seguras (como "Prioridade: NENHUMA" e "Dia não reconhecido"), prevenindo falhas críticas de execução como `NullReferenceException` sem quebrar o fluxo natural da aplicação.

## Exemplos de Execução

**Exemplo 1: Entrada Válida (Quarta-feira)**
```text
Usuário: Thaís
Dia consultado: quarta-feira
Prioridade: MÉDIA
Mensagem: Dia de revisão: verifique o andamento da atividade 'Implementar relatório'.
```

**Exemplo 2: Entrada Inválida (Sem estrategia associada)**
```text
Usuário: Thaís
Dia consultado: feriado
Prioridade: NENHUMA
Mensagem: Dia não reconhecido ou sem atividade agendada. Nenhuma ação necessária. Dias da semana possíveis: segunda-feira, terça-feira, quarta-feira, quinta-feira, sexta-feira, sábado, domingo.
```
