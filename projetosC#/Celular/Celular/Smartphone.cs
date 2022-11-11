namespace Celular
{
    public abstract class Smartphone
    {
        private string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        protected Smartphone(string modelo, string imei, int memoria)
        {
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}