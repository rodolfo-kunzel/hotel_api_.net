using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller {
        [HttpPost]
        public void Post([FromBody] Cliente cliente) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<Cliente> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.Clientes.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Cliente cliente)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(cliente);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
                if(item == null)
                {
                    return; 
                }
                _context.Clientes.Remove(item);
                _context.SaveChanges();
            }
        }
    }