using BackendAlgar.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace BackendAlgar.Controllers
{
    [Route("api/colores")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        // GET: api/<Productos>
        [HttpGet]
        public List<ColorDto> Get()
        {
            List<ColorDto> productos = new List<ColorDto>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-8BC3J56\\SQLEXPRESS;Initial Catalog=VacoDB;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from color", connection);
                System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new ColorDto(reader["id"], reader["nombre"], reader["hexa"]));

                    }
                }

                connection.Close();
            }

            return productos;
        }
    }
}
