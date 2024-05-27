using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRol { get; set; }


        [MaxLength(50, ErrorMessage = "El campo DescripcionRol debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescripcionRol debe tener menos de 5 caracteres")]
        public string DescripcionRol{ get; set; } = null!;

        public ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
    }
}
