namespace DesafioPOO.Models
{
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Smartphone(string numero, string modelo, string marca)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
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
} // Adicione esta chave de fechamento no final do arquivo
