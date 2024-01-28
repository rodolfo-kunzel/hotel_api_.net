using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class FilialController : Controller {
        [HttpPost]
        public void Post([FromBody] Filial filial) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.Filiais.Add(filial);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<Filial> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.Filiais.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Filiais.FirstOrDefault(f => f.IdFilial == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Filial filial)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Clientes.FirstOrDefault(f => f.IdCliente == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(filial);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Filiais.FirstOrDefault(f => f.IdFilial == id);
                if(item == null)
                {
                    return; 
                }
                _context.Filiais.Remove(item);
                _context.SaveChanges();
            }
        }
    }