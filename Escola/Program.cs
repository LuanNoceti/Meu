namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema da Escola Neon Genesis!");
            Console.WriteLine("Digite 1 se quiser cadastrar uma nova matéria ou 2 se deseja avaliar um aluno.");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 1)
            {
                Matéria mat1 = new Matéria();
                mat1.CriarMateria();
            }
            else if (valor == 2) 
            {
                Avaliação ava1 = new Avaliação();
                ava1.
            }
        }
    }
}
