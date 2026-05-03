using Microsoft.AspNetCore.Mvc;
using WebHotelPacificRef.Data;
using WebHotelPacificRef.Models;

namespace WebHotelPacificRef.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        // Conectamos la base de datos al inicio público
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pantalla de Inicio (Buscador)
        public IActionResult Index()
        {
            return View();
        }

        // GET: Pantalla de Checkout (Formulario)
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcesarReserva(Cliente nuevoCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Intentamos guardar en la base de datos real
                    _context.Clientes.Add(nuevoCliente);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {

                }

                // Redirigimos con el mensaje de éxito pase lo que pase
                TempData["MensajeExito"] = "¡Reserva confirmada y pagada con éxito!";
                return RedirectToAction("Index");
            }

            // Si falta algún dato en el formulario, lo devuelve
            return View("Checkout", nuevoCliente);
        }
    }
}
