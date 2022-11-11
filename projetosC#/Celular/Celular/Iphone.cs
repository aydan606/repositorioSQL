namespace Celular
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Confirma a instalação desse aplicativo? {nomeApp} S/N");
            string? aux = Console.ReadLine();
        }
    }
}