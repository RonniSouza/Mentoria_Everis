using EverisStore.Domain.Entities;

namespace EverisStore.Domain.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        public Categoria(){}

        public Categoria(string nome, int codigo)
        {
            Nome= nome;
            Codigo = codigo;
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}