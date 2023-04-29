using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaMVC.Models;

namespace Helpers_MVC.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public EquiposController(equiposDbContext equiposDbContext) {
            _equiposDbContext= equiposDbContext;
        }

        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposDbContext.marcas
                             select m).ToList();

            ViewData["listaDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");
            
            var lstTipoEquipos = (from tp in _equiposDbContext.tipo_equipo
                                  select tp).ToList();

            ViewData["lstTipoEquipos"] = new SelectList(lstTipoEquipos, "id_tipo_equipo", "descripcion");
           
            var lstEstado = (from est in _equiposDbContext.estados_equipo
                             select est).ToList();

            ViewData["lstEstado"] = new SelectList(lstEstado, "id_estados_equipo", "descripcion");

            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new { 
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();
            ViewData["listadoDeEquipos"] = listadoDeEquipos;
            return View();

        } 
        public IActionResult CrearEquipos(Equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
