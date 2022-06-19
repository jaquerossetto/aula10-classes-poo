namespace Aula08
{
    public class Filmes
    {
   
    public string[] listaDeFilmes = { "Clube dos Cinco", 
                                      "A Hora do Pesadelo", 
                                      "Karatê Kid", 
                                      "Rocky IV", 
                                      "Conan, o Bárbaro", 
                                      "Highlander" };

    
    public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
    {
        return string.Join("; ", listaDeFilmes);
    }


    public int quantidadeTotalDeFilmes()
    {
        return listaDeFilmes.Length;
    }


    public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
    {
        return listaDeFilmes[indiceDoFilme];
    }


    public string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
    {
        return listaDeFilmes.Append(nomeDoFilme).ToArray();
    }

    public string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNome)
    {
        listaDeFilmes[indiceDoFilme] = novoNome;
        return listaDeFilmes;
    }

    
    public string listarTodosOsFilmesComSeuIndiceNaLista()
    {
        string lista = string.Empty;

        for (var index = 0; index < listaDeFilmes.Length; index++)
        {
            lista += index + " - " + listaDeFilmes[index] + Environment.NewLine;
        }

        return lista;
    }

        public void Resultados()
        {
            Console.WriteLine("------ Resultados da Atividade ------");           
            Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");
            Console.WriteLine($"2. Retorna a quantidade de filmes da lista {quantidadeTotalDeFilmes()}");
            Console.WriteLine($"3. Buscar um filme pelo indice {buscarNomeDoFilmePeloIndice(0)}");
            Console.WriteLine($"4. Adiciona um filme pelo nome {string.Join("; ", adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"))}");
            Console.WriteLine($"5. Atualizar um filme pelo seu índice {string.Join("; ", atualizarUmFilmePeloSeuIndice(3, "Rocky III"))}");
            Console.WriteLine($"6. Listar todos os filmes com seu indice/posicao na lista. {listarTodosOsFilmesComSeuIndiceNaLista()}");
        }
     }


    internal class Program
    {
        static void Main(string[] args)
        {
            Filmes film = new();
            film.Resultados();
        }
    }
}


