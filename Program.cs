using ListaDeTarefas;

var service = new Service();

for (var i = 1; i > 0; i++)
{
    Console.Clear();
    var tarefasDiarias = service.PegarTarefas();
    foreach (var tarefaDiaria in tarefasDiarias)
    {
        tarefaDiaria.ImprimirNaTela();

    }
    Console.WriteLine("-----------------------------");

    var tarefa = new TarefasDiarias();
    tarefa.PerguntarNomeTarefa();
    tarefa.PerguntarDataDaTarefa();

    service.InserirTarefa(tarefa);
}

