using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.almacen
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool Condicion { get; set; }

    }
}
