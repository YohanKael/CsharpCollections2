using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections2.csharpcollections
{
    class Aula : IComparable
    {
        public string titulo;
        public int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo1 { get => titulo; set => titulo = value; }
        public int Tempo1 { get => tempo; set => tempo = value; }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return titulo.CompareTo(that.titulo);

        }

        public override string ToString()
        {
            return $"[Título: {titulo}, Tempo: {tempo} minutos]";
        }
    }
}
