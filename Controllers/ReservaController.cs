using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller {
        [HttpPost]
        public void Post([FromBody] Reserva reserva) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<Reserva> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.Reservas.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Reservas.FirstOrDefault(r => r.CodigoReserva == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Reserva reserva)
        {
            using (var _context = new HotelApiContext())
            {
                TimeSpan timeDifference = reserva.DtEntrada - DateTime.Today;

                if (timeDifference.TotalHours < 24)
                {
                    return Unauthorized("Mudanças na reserva não podem ser feitas com menos de 24 horas de antecedencia");
                }
                var item = _context.Reservas.FirstOrDefault(r => r.CodigoReserva == id);
                if(item == null)
                {
                    return NotFound(); 
                }
                _context.Entry(item).CurrentValues.SetValues(reserva);
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Reservas.FirstOrDefault(r => r.CodigoReserva == id);
                if(item == null)
                {
                    return NotFound();; 
                }
                TimeSpan timeDifference = item.DtEntrada - DateTime.Today;
                if (timeDifference.TotalHours < 24)
                {
                    NotaFiscal notaFiscal = new NotaFiscal
                    {
                        TipoPagamento = "Cancelamento de Reserva",
                        Preco = item.Quarto!.PrecoQuarto
                    };
                    _context.NotasFiscais.Add(notaFiscal);
                }
                _context.Reservas.Remove(item);
                _context.SaveChanges();
                return Ok();
            }
        }
    }