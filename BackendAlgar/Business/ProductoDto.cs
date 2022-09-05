namespace BackendAlgar.Business
{
    public class ProductoDto
    {
     

        public ProductoDto(object v1, object v2, object v3, object v4, object v5)
        {
            this.id = (long)v1;
            this.nombreproducto = (string)v2;
            this.iddepartamento = (long)v3;
            this.monto = (decimal)v4;
            this.id_color = (int)v5;
        }

        public long id { get; set; }
        public string nombreproducto { get; set; }
        public long iddepartamento { get; set; }
        public decimal monto { get; set; }
        public long id_color{ get; set; }  
    }
}
