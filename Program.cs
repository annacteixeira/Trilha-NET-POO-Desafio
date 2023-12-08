using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokiaPhone = new Nokia("123456789", "NokiaX", "Nokia");
            Iphone iphone = new Iphone("987654321", "iPhone 12", "Apple");

            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
