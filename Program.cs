using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("1199998888", "Ninguem Usa +", "123456", 128);

        Smartphone iphone = new Iphone("1199998888", "16 Pro", "12345", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");
        Console.WriteLine();

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine();
    }
}