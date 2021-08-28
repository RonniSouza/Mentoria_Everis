namespace EverisStore.Domain.Entities
{
    public class Produtos : Base
    {
        
        public string Name { get; private set; }
        public string Marca { get; private set; }
        public string Descricao { get; private set; }
        protected Produtos(){}

        public Produtos(string name, string marca, string descricao)
        {
            Name = name;
            Marca = marca;
            Descricao = descricao;
        }

        public void ChangeName(string name){
            Name = name;
            Validate();
        }

        public void ChangeMarca(string marca)
        {
            Marca = marca;
            Validate();
        }

        public void ChangeDescricao(string descricao)
        {
            Descricao = descricao;
            Validate();
        }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}