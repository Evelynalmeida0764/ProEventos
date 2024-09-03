using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;
using SQLitePCL;
using System;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]" )]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;

    public EventoController(DataContext context)//injeção de dependencia?
    {
        _context = context;
        //DataContext e Injeção de Dependência: O construtor EventoController recebe uma instância de DataContext como parâmetro. Isso é chamado de injeção de dependência e é uma prática comum no ASP.NET Core para fornecer dependências a classes. O ASP.NET Core é responsável por criar uma instância de DataContext e passá-la para o construtor quando um EventoController é instanciado. Q?
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos; //por que todos?
    }
    //o que um controlador 
    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(
            e => e.Eventoid == id);
    }

    // public IEnumerable<Evento> GetById(int id)
    // {
    //     return _context.Eventos.Where(evento => evento.Eventoid == id);
    // }

    [HttpPost]
    public string Post(){
        return "exemplo de post";
    }
    [HttpPut("{id}")]
    public string Put(int id){
        return $"Exemplo de Put com id = {id}";
    }
}
