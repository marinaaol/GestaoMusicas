namespace GestaoMusicas
{
    internal class Musica
    {
        //------ CAMPOS ------
            public string titulo = "";
            public string artista = "";
            public int duracaoSegundos;
            public int ano;

        // Lista de classificações
            public List<int> classificacoes;

        //Array de string dos gêneros musicais    
            public string[] generos;
            

        //------ CONSTRUTORES ------
        public Musica()
                {
                    classificacoes = new List<int>();
                    generos = new string[3];
                }
        public Musica (string titulo, string artista, int duracaoSegundos)
                {
                    this.titulo = titulo;
                    this.artista = artista;
                    this.duracaoSegundos = duracaoSegundos;
                    classificacoes = new List<int>();
                    generos = new string[3];
                }
        public Musica (string titulo, string artista, int duracaoSegundos, int ano)
                {
                    this.titulo = titulo;
                    this.artista = artista;
                    this.duracaoSegundos = duracaoSegundos;
                    this.ano = ano;
                    classificacoes = new List<int>();
                    generos = new string[3];
                }             
        //------ MÉTODOS ------
        
        public void MostrarFicha()
        {
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Música     : " + titulo);
            Console.WriteLine("Artista    : " + artista);
            Console.WriteLine("Duração    : " + duracaoSegundos);
            Console.WriteLine("Ano        : " + ano);
        }

        public string ObterDuracaoFormatada()
        {
            int minutos = duracaoSegundos / 60;
            int segundos = duracaoSegundos % 60;
            return $"{minutos}m {segundos}s";
        }

        public void AdicionarClassificacao(int nota)
            {
                if (nota < 1 || nota > 5)
                {
                    Console.WriteLine($"Aviso: A nota {nota} é inválida! Deve ser entre 1 e 5.");
                    return;
                }
                    classificacoes.Add(nota);
            }
        
        public void MostrarClassificacoes()
            {
                if (classificacoes.Count == 0)
                {
                    Console.WriteLine("A lista Classificações está vazia");
                    return; //sai do método para não continuar
                }
                //Caso a lista não esteja vazia, percorre com foreach e imprime cada nota 
                foreach(int nota in classificacoes)
                {
                    Console.WriteLine(nota);
                } 
            }

        public double CalcularMedia()
            {
                if (classificacoes.Count == 0)
                {
                    return 0;
                }
                
                int soma = 0;
                
                for (int i = 0; i < classificacoes.Count; i++)
                {
                    soma += classificacoes[i]; //é usado para somar cada nota, de acordo com a sequência i 
                }

                double media = (double) soma / classificacoes.Count;
                return media;
            }

        public void MostrarGeneros()
        {
            Console.WriteLine("Gêneros musicais:  ");
            bool temPreenchido = false;

            //o ciclo "for" percorre o array do início ao fim usando .Length
            for(int i = 0; i < generos.Length; i++)
            {
                //verificar se a posição do array não está vazia (null)
                if(generos[i] != null)
                {
                    Console.WriteLine($"- {generos[i]}");
                    temPreenchido = true;
                }
            }
            if(!temPreenchido)
            {
                Console.WriteLine("Nenhum gênero preenchido de momento.");
            }
        }

    public override string ToString()
        {
            //usar o método ObterDuracaoFormatada() que já foi criado para mostrar a duração (3m45s)
            return ($"Título: {titulo} | Artista: {artista} | Duração {ObterDuracaoFormatada()} | Ano: {ano}");
        }
    }
}
