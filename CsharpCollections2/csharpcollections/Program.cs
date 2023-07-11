namespace CsharpCollections2.csharpcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            // adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Trabalhando com Lista", 19));
            Imprimir(csharpColecoes.Aulas);

            // Ordenar a lista de aulas

            // csharpColecoes.Aulas.Sort();

            //copiar a lista para outra lista

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //ordenar a copia

            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            // Totalizar o tempo do curso

            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

            //Imprimir detalhes do curso??



            //var aulaIntro = new Aula("Introdução as Coleções", 20);
            //var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            //var aulaSets = new Aula("Trabalhando com conjuntos", 16);

            //List<Aula> aulas = new List<Aula>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);
            ////aulas.Add("Conclusão");

            //Imprimir(aulas);

            //aulas.Sort();
            //Imprimir(aulas);

            //aulas.Sort((este, outro) => este.tempo.CompareTo(outro.tempo));
            //Imprimir(aulas);

        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

}