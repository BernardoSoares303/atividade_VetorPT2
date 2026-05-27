public class Program
{
    public static void Main()
    {
        int[] vetor = new int[12];

    }

    public void preenchervetor(int[] vetor)
    {
        Random r = new Random();

        for(int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(5,50);
        }
    }
}

