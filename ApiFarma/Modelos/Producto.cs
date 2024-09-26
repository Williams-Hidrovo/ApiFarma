using System.ComponentModel.DataAnnotations;

namespace ApiFarma.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        //relacion con Categoria
        public int IdCategoria {get;set;}


    }
}
