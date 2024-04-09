namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo Instalado no {nomeApp} em Iphone {Modelo}");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando do Iphone");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligaçao No Iphone");
        }
    }
}