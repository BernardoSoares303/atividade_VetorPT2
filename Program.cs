public class Program
{
    public static void Main()
    {
        int[] vetor = new int[12];
        preenchervetor(vetor);

        Console.WriteLine("Estoque Antes das Vendas:");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i]+" ");
        }

        for(int i = 0; i < vetor.Length; i++){
            Vender6(ref vetor[i]);
        }   

        Console.WriteLine();
        Console.WriteLine("Estoque Depois das Vendas:");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine($"Total final do estoque: {TotalEstoque(vetor)}");
    }

    public static void preenchervetor(int[] vetor)
    {
        Random r = new Random();

        for(int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(5,50);    
        }
    }

    public static void Vender6(ref int Produto)
    {
        Produto = Produto - 6;
        if(Produto < 0)
            Produto = 0;
    }

    public static int TotalEstoque(int [] vetor)
    {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++)
            soma += vetor[i];
        return soma;   
    }
}

