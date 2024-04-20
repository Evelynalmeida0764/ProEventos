using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]" )]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento() {
            Eventoid = 1,
            Tema = "Angular 11 e dotnet 6",
            Local = "Belo Horizonte",
            Lote = "1° lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
        },
        new Evento() {
            Eventoid = 2,
            Tema = "Angular E suas novidades",
            Local = "São paulo",
            Lote = "2° lote",
            QtdPessoas = 200,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.png"
        }   
    
    };    
    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpPost]
    public string Post(){
        return "exemplo de post";
    }
    [HttpPut("{id}")]
    public string Put(int id){
        return $"Exemplo de Put com id = {id}";
    }
}
