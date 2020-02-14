using System.ComponentModel.DataAnnotations;

namespace EntityRepository
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
    }
}
