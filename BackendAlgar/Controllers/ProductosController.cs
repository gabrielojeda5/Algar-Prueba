using BackendAlgar.Business;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendAlgar.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        // GET: api/<Productos>
        [HttpGet]
        public List<ProductoDto> Get()
        {
            this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            List<ProductoDto> productos = new List<ProductoDto>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-8BC3J56\\SQLEXPRESS;Initial Catalog=VacoDB;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from producto", connection);
                System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new ProductoDto(reader["id"], reader["nombreproducto"], reader["iddepartamento"], reader["monto"], reader["id_color"]));
                       
                    }
                }

                connection.Close();
            }

            return productos;
        }

        // GET api/<Productos>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Productos>
        [HttpPost]
        public string Post([FromBody] string nombreproducto, string monto, string id_color)
        {
            this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return "OK";

        }

        // PUT api/<Productos>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Productos>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
