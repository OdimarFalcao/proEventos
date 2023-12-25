﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
         private readonly DataContext _context;

        public EventoController(DataContext context){
                this._context = context;

            }

            [HttpGet]
        public IEnumerable<Evento> Get(){
            return _context.Eventos;
            }

            [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id){               
             return _context.Eventos.Where(evento => evento.EventoId==id );
            }
}
}