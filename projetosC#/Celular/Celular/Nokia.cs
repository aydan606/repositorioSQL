namespace Celular
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Deseja instalar esse aplicativo? {nomeApp} S/N");
            string? aux = Console.ReadLine();
        }
    }
}