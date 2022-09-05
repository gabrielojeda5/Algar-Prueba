namespace BackendAlgar.Business
{
    public class ColorDto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string hexa        { get; set; }

        public ColorDto(object id, object nombre, object hexa)
        {
            this.id = (int) id;
            this.nombre = (string) nombre;
            this.hexa = (string)hexa;
        }
    }
}
