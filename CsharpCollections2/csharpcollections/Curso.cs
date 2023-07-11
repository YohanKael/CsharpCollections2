using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections2.csharpcollections
{
    class Curso
    {
        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }

        public int TempoTotal
        {
            get
            {
                // LINQ = language integrated query
                // Consulta Integrada à linguagem


                //int total = 0;
                //            foreach (var aula in aulas)
                //            {
                //	total += aula.tempo;
                //            }
                //            return total;
                return aulas.Sum(aula => aula.tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso:{nome} , Tempo:{TempoTotal}, Aulas:{string.Join(",", aulas)} ";
        }
    }

}
