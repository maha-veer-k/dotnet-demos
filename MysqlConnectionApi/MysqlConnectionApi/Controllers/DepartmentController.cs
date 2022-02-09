using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

namespace MysqlConnectionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        [HttpGet]
        public IActionResult Get()
        {
            string query = @"
                            select DeptId, DeptName from
                            Department
                        ";
            DataTable table = new DataTable();

            string SqlConn = _configuration.GetConnectionString("DefaultString");
            MySqlDataReader myReader;
            using(MySqlConnection conn = new MySqlConnection(SqlConn))
            {
                
                conn.Open();
                using(MySqlCommand myCommand = new MySqlCommand(query, conn))
                {
                    myReader = myCommand.ExecuteReader();   
                    table.Load(myReader);

                    myReader.Close();
                    conn.Close();
                }
            }
            return Ok(table);
        }
    }
}
