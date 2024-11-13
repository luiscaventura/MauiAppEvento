namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public double Custo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public double NumeroParticipantes { get; set; }

        // Propriedades calculadas
        public int DuracaoDias
        {
            get => DataTermino.Subtract(DataInicio).Days + 1;
        }
       
        
        public double CustoTotal

        {
            get => NumeroParticipantes * Custo;
        }

            
    }
}
