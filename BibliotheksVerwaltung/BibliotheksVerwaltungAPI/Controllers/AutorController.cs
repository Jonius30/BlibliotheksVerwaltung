using AutoMapper;
using BibliotheksVerwaltungLib.Entities;
using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using Microsoft.AspNetCore.Mvc;

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
        public AutorListResponse List()
        {
            List<Autor> list = new()
            {
               new Autor(null, "Peter", "Lustig"),
               new Autor("Dr", "Günther", "Mustermann")
            };
            return new()
            {
                Autoren = _Mapper.Map<List<AutorDto>>(list)
            };
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
        public AutorCreateResponse Create(AutorCreateRequest request)
        {
            return new AutorCreateResponse()
            {
                Autor = _Mapper.Map<AutorDto>(new Autor(request.Titel, request.Vorname, request.Nachname))
            };
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