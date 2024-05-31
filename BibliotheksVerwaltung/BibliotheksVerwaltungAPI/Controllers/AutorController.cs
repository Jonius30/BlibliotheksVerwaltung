using AutoMapper;
using BibliotheksVerwaltungLib.Entities;
using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace BibliotheksVerwaltungAPI.Controllers
{
    [ApiController]
    [Route("/autor")]
    public class AutorController : ControllerBase
    {
        private readonly IMapper _Mapper;
        public AutorController(IMapper mapper)
        {
            _Mapper= mapper;
        }

        [HttpGet]
        public async Task<AutorListResponse> List()
        {
            List<Autor> autoren = new List<Autor>();
            MySqlConnection connection = new MySqlConnection("connectionstring");
            string commandText = "SELECT Id, Titel, Vorname, Nachname FROM Autor";
            MySqlCommand command = new MySqlCommand(commandText, connection);
            await connection.OpenAsync();
            MySqlDataReader reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string titel = reader.GetString("Titel");
                string vorname = reader.GetString("Vorname");
                string nachname = reader.GetString("Nachname");
                autoren.Add(new Autor(id, titel, vorname, nachname));

            }
            await command.DisposeAsync();
            await connection.CloseAsync();
            AutorListResponse response = new AutorListResponse();
            response.Autoren = _Mapper.Map<List<AutorDto>>(autoren);
            return response;
        }

        [HttpGet("{AutorId}")]
        public AutorByIdResponse GetByID([FromRoute] AutorByIdRequest request)
        {
            AutorByIdResponse response = new();
            Autor autor = new Autor(null, "Max", "Mustermann");
            response.Autor = _Mapper.Map<AutorDto>(autor);
            return response;
        }

        [HttpPost]
        public async Task<AutorCreateResponse> Create(AutorCreateRequest request)
        {
            MySqlConnection connection = new MySqlConnection("connectionstring");
            string commandText = $"INSERT INTO autor (titel, vorname, nachname) VALUES (@titel, @vorname, @nachname)";
            MySqlCommand command = new MySqlCommand(commandText, connection);
            command.Parameters.AddWithValue("@titel", request.Titel);
            command.Parameters.AddWithValue("@vorname", request.Vorname);
            command.Parameters.AddWithValue("@nachname", request.Nachname);
            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
            await command.DisposeAsync();
            AutorCreateResponse response = new AutorCreateResponse();
            MySqlCommand commandCheck = new MySqlCommand("SELECT Id, Titel, Vorname, Nachname FROM Autor ORDER BY Id DESC LIMIT 1");
            MySqlDataReader reader = await commandCheck.ExecuteReaderAsync();
           
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string titel = reader.GetString("Titel");
                string vorname = reader.GetString("Vorname");
                string nachname = reader.GetString("Nachname");
                Autor autor = new Autor(id, titel, vorname, nachname);
                response.Autor = _Mapper.Map<AutorDto>(autor);
            }
            await connection.CloseAsync();
            return response;
            
        }

        [HttpPut]
        public AutorUpdateResponse Update([FromBody] AutorUpdateRequest request)
        {
            return new AutorUpdateResponse()
            {
                Autor = _Mapper.Map<AutorDto>(new Autor(request.Titel, request.Vorname, request.Nachname))
            };
        }

        [HttpDelete("{autorId}")]
        public void Delete([FromRoute] int autorId)
        {
            
        }
    }
}
