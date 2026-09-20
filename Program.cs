namespace GestaoMusicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto criado com o construtor vazio
            Musica m1 = new Musica();

            //Objeto criado com o construtor de 3 parâmetros
            Musica m2 = new Musica("Drão","Gilberto Gil", 197 );

            // Objeto criado com o construtor de 4 parâmetros
            Musica m3 = new Musica("My girl", "The Temptations", 165, 1964);

            m1.MostrarFicha();
            m2.MostrarFicha();
            m3.MostrarFicha();

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            m2.AdicionarClassificacao(5);
            m2.AdicionarClassificacao(2);
            m2.AdicionarClassificacao(0);
            m2.AdicionarClassificacao(12);

            Console.WriteLine("///////////////////////");
            Console.WriteLine("Total de avaliações: " + m2.classificacoes.Count);

            m2.MostrarClassificacoes();
            m1.MostrarClassificacoes();

            m2.generos[0] = "MPB";
            m2.generos[1] = "Soul";
          
            m2.MostrarGeneros();
            m1.MostrarGeneros();

            double media = m2.CalcularMedia();
            Console.WriteLine("///////////////////////");
            Console.WriteLine($"Média da música {m2.titulo}: {media:F2}");

            List<Musica> playlist = new List<Musica>();
            playlist.Add(m1);
            playlist.Add(m2);
            playlist.Add(m3);

            Console.WriteLine("======== PLAYLIST =======");
            int duracaoTotal = 0;

            foreach(Musica m in playlist)
            {
                Console.WriteLine(m);
                duracaoTotal = duracaoTotal + m.duracaoSegundos;
            }
            int minutosTotal = duracaoTotal / 60;
            int segundosTotal = duracaoTotal % 60;
            Console.WriteLine($"Músicas:   {playlist.Count}");
            Console.WriteLine($"Duração total:  {minutosTotal}m {segundosTotal}s");
            Console.WriteLine("///////////////////////");
        }
    }
}