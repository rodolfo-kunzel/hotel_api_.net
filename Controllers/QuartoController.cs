using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class QuartoController : Controller {
        [HttpPost]
        public void Post([FromBody] Quarto quarto) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.Quartos.Add(quarto);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<Quarto> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.Quartos.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Quartos.FirstOrDefault(q => q.Numero == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Quarto quarto)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Quartos.FirstOrDefault(q => q.Numero == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(quarto);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Quartos.FirstOrDefault(q => q.Numero == id);
                if(item == null)
                {
                    return; 
                }
                _context.Quartos.Remove(item);
                _context.SaveChanges();
            }
        }
    }