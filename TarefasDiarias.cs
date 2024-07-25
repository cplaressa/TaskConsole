namespace ListaDeTarefas
{
    public class TarefasDiarias
    {
        public string? NomeTarefa { get; set; }
        public DateTime? DataDaTarefa { get; set; }

        public void PerguntarNomeTarefa()
        {
            Console.WriteLine("Digite o nome da tarefa");
            NomeTarefa = Console.ReadLine();
        }

        public void PerguntarDataDaTarefa()
        {
            Console.WriteLine("Digite a data da tarefa");
            var data = Console.ReadLine();

            Console.WriteLine("Digite o horario da tarefa");
            var time = Console.ReadLine();

            if (data != null && time != null)
            {
                var dataSplit = data.Split('-');
                var tempo = time.Split(':');
                var dia = int.Parse(dataSplit[0]);
                var mes = int.Parse(dataSplit[1]);
                var ano = int.Parse(dataSplit[2]);
                var hora = int.Parse(tempo[0]);
                var minuto = int.Parse(tempo[1]);
                DataDaTarefa = new DateTime(ano, mes, dia,hora,minuto,0);
            }
        }

        public void ImprimirNaTela()
        {
            Console.WriteLine("data: " + DataDaTarefa  + " nome: " +  NomeTarefa);
        }
    }
}