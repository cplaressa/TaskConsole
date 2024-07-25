using Newtonsoft.Json;

namespace ListaDeTarefas
{
    public class Service
    {
        private List<TarefasDiarias> tarefas = new();
        public void InserirTarefa(TarefasDiarias tarefa)
        {
            tarefas.Add(tarefa);
            SalvarTarefas();
        }

        public List<TarefasDiarias> PegarTarefas()
        {
            LerTarefas();
            return tarefas.OrderBy(x => x.DataDaTarefa).ToList();
        }

        private void SalvarTarefas()
        {
            File.WriteAllText("./file.json", JsonConvert.SerializeObject(tarefas));
        }

        private void LerTarefas()
        {
            var file = File.ReadAllText("./file.json");
            tarefas = JsonConvert.DeserializeObject<List<TarefasDiarias>>(file) ?? new();
        }
    }
}