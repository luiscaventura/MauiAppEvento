namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public double CustoParticipante { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }

        // Propriedades calculadas
        public int DuracaoDias
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
       
        
        public double CustoTotal

        {
            get => NumeroParticipantes * CustoParticipante;
        }

            
    }
}
