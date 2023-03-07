internal class Program
{
    private static void Main(string[] args)
    {
        int valor, quociente;
        int resto;
        int[] vetor = new int[8];

        Console.WriteLine("Digite o valor que será convertido: ");
        valor = int.Parse(Console.ReadLine());


        for (int i = 0; i <=7; i++)
        {
            resto = valor % 2;
            quociente = valor / 2;
            valor = quociente;
            vetor[i] = resto;
        }
        for (int i = 7; i >= 0; i--)
        {
            Console.Write(vetor[i]);
        }
    }
}