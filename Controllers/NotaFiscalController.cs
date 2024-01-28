using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class NotaFiscalController : Controller {
        [HttpPost]
        public void Post([FromBody] NotaFiscal notaFiscal) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.NotasFiscais.Add(notaFiscal);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<NotaFiscal> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.NotasFiscais.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.NotasFiscais.FirstOrDefault(n => n.CodigoNota == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] NotaFiscal notaFiscal)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.NotasFiscais.FirstOrDefault(n => n.CodigoNota == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(notaFiscal);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.NotasFiscais.FirstOrDefault(n => n.CodigoNota == id);
                if(item == null)
                {
                    return; 
                }
                _context.NotasFiscais.Remove(item);
                _context.SaveChanges();
            }
        }
    }