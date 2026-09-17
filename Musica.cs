using System.Security.Cryptography.X509Certificates;

namespace GestaoMusicas
{
    internal class Musica
    {
        //------ CAMPOS ------
            public string titulo;
            public string artista;
            public int duracaoSegundos;
            public int ano;

        //------ CONSTRUTORES ------
        public Musica()
                {
                    
                }
        public Musica (string titulo, string artista, int duracaoSegundos)
                {
                    this.titulo = titulo;
                    this.artista = artista;
                    this.duracaoSegundos = duracaoSegundos;
                }
        public Musica (string titulo, string artista, int duracaoSegundos, int ano)
                {
                    this.titulo = titulo;
                    this.artista = artista;
                    this.duracaoSegundos = duracaoSegundos;
                    this.ano = ano;
                }             
       
    }
}