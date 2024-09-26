namespace ApiFarma.Modelos
{
    public class Venta
    {
        public int Id { get; set; }
        
        public int Cantidad { get; set; }

        public DateTime Fecha{get;set;}

        //relacion con producto
        public int IdProducto { get; set; }

        //relacion con cliente
        public int IdCliente { get; set; }



    }
}
