﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReunionDiaApi.Models;
using ReunionDiaApi.DTOs;

namespace ReunionDiaApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LineasController : ControllerBase
    {


        private readonly DbNeoContext _context;

        public LineasController(DbNeoContext _DbNeo)
        {
            _context = _DbNeo;
        }
        public static List<Centro> centro = new List<Centro> { };
        public static List<Linea> linea = new List<Linea> { };
        public static List<Empresa> empresa = new List<Empresa> { };
        public static List<Pai> pais = new List<Pai> { };
        public static List<Division> div = new List<Division> { };
        public static List<Ksf> ksfs = new List<Ksf>();
        public static List<RespoReu> resporeu = new List<RespoReu>();
        public static List<ReunionDium> reunionditabla = new List<ReunionDium>();
        public static List<Division> divisions = new List<Division>();
        public static List<AsistenReu> asistenreus = new List<AsistenReu>();
        public static List<CargoReu> cargoreus = new List<CargoReu>();
        public static List<StatsAsisDto> StatsAsis = new List<StatsAsisDto>();
        public static List<EquipoEam> equipos = new List<EquipoEam>();



        [HttpGet("{cent}")]
        public async Task<ActionResult<List<Linea>>> GetBdDiv(string cent)
        {
            if (cent == "All")
            {
                centro = await _context.Centros
               .Include(x => x.Divisions)
               .ThenInclude(post => post.Lineas)
               .ToListAsync();
            }

            else
            {
                centro = await _context.Centros
               .Include(x => x.Divisions)
               .ThenInclude(post => post.Lineas)
               .Where(x => x.Cnom == cent)
               .ToListAsync();
            }


            return Ok(centro);
        }

        [HttpGet("Equipos/{cent}")]
        public async Task<ActionResult<List<EquipoEam>>> EquiposEAM(string cent)
        {
            if (cent == "All")
            {
                equipos = await _context.EquipoEams
               .Include(x => x.IdLineaNavigation)
             .ToListAsync();
            }
            else
            {
                equipos = await _context.EquipoEams
                .Include(x => x.IdLineaNavigation)
                .ThenInclude(y =>y.IdDivisionNavigation)
                .Where(x=>x.IdLineaNavigation.IdDivisionNavigation.IdCentroNavigation.Cnom== cent)
              .ToListAsync();
            }
               
            return Ok(equipos);
        }

        [HttpGet("Division/{centro}/{div}")]
        public async Task<ActionResult<List<Division>>> GetDivLin(string centro, string div)
        {

            divisions = await _context.Divisions
                .Include(x => x.IdCentroNavigation)
                .ToListAsync();

            return Ok(linea);
        }

        [HttpGet("Asistencia/{div}")]
        public async Task<ActionResult<List<AsistenReu>>> GetAsistencia(string div)
        {

            cargoreus = await _context.CargoReus
                .Where(a => a.Cearea == div & a.Cresta==true)

                .ToListAsync();

            return Ok(cargoreus);
        }




        [HttpGet("Ksf")]
        public async Task<ActionResult<List<Linea>>> GetKsf()
        {

            ksfs = await _context.Ksfs
                .Where(a => a.KsfEsta == true)
                .ToListAsync();

            return Ok(ksfs);
        }



        [HttpGet("Responsables")]
        public async Task<ActionResult<List<Linea>>> GetRespon()
        {


            resporeu = await _context.RespoReus
                .Where(a => a.Rresta == true)
                .ToListAsync();

            return Ok(resporeu);
        }

        //Obtener asistencia
        [HttpGet("StatsAsis/{cent}/{f1}/{f2}")]
        public async Task<ActionResult<List<StatsAsisDto>>> GetStatsAsis(string cent, string f1, string f2)
        {

            string[] fecha1 = f1.Split('-');
            string[] fecha2 = f2.Split('-');

            //año, mes dia
            DateTime date1 = new DateTime(int.Parse(fecha1[2]), int.Parse(fecha1[1]), int.Parse(fecha1[0]));
            DateTime date2 = new DateTime(int.Parse(fecha2[2]), int.Parse(fecha2[1]), int.Parse(fecha2[0]));



            if (cent == "All")
            {
                var result = await _context.AsistenReus
               .Include(x => x.AridCargoRNavigation)
               .Where(x => x.Arfecha >= date1 & x.Arfecha <= date2)
               .GroupBy(x => x.AridCargoRNavigation.Crnombre)
               .Select(a => new
               {
                   a.Key,
                   Asistencias = a.Sum(b => b.ArAsistente)
               })
               .ToListAsync();

                return Ok(result);
            }

            else
            {
                var result = await _context.AsistenReus
               .Include(x => x.AridCargoRNavigation)
               .Where(x => (x.Arfecha >= date1 & x.Arfecha <= date2) && x.Ararea == cent)
               .GroupBy(x => x.AridCargoRNavigation.Crnombre)
               .Select(a => new
               {
                   Cargo = a.Key,
                   Asistencias = a.Sum(b => b.ArAsistente)
               })
               .ToListAsync();

                return Ok(result);
            }


            return Ok();
        }

        [HttpPost("Asistencia")]
        public async Task<ActionResult<string>> SaveAsistencia(List<AsistenReu> list)
        {
            DateTime d=DateTime.Now;

            try
            {
                var result = await _context.AsistenReus
                .Include(x => x.AridCargoRNavigation)
                .Where(x => x.Arfecha == d && x.Ararea == list[0].Ararea)
                .FirstOrDefaultAsync();
                if (result == null)
                {

                    for (var i = 0; i < list.Count; i++)
                    {
                        AsistenReu insertar = new AsistenReu();
                        insertar.Ararea = list[i].Ararea;
                        insertar.Arfecha = list[i].Arfecha;
                        insertar.AridCargoR = list[i].AridCargoR;
                        insertar.ArAsistente = list[i].ArAsistente;
                        insertar.ArSuplente = list[i].ArAsistente;
                        insertar.Ararea = list[i].Ararea;

                        _context.AsistenReus.Add(insertar);
                        await _context.SaveChangesAsync();

                    }
                    return Ok("Registro Exitoso");
                }
                else
                {
                    return BadRequest("Ya se registro asistencia");
                }

            }
            catch
            {
                return BadRequest("Error, intente nuevamente");
            }

        }



        //[HttpPost("Auth")]
        //public ActionResult<string> Loging(UserLoginDto request)
        //{
        //    string token = @"eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQWRtaW4iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2dpdmVubmFtZSI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc3VybmFtZSI6IlBydWViYSIsImV4cCI6MTY2OTEzMDYxNX0.Akph2dgCZkX7dzBPpb5ujxFjezWiUCzkv80GyGaQ0SdhIV_c03Cybjsay5__rw69wT4mksFdkoJ87PeoAico8g";
        //    return token;
        //}

    }
}
