using EverisStore.Domain.Entities;

namespace EverisStore.Domain.Models
{
    public class Perfil : Entity
    {
        public string Descricao { get; set; }
        public string Regra { get; set; }
    }
}