using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class ServicoLavanderiaController : Controller {
        [HttpPost]
        public void Post([FromBody] ServicoLavanderia servico) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.ServicosLavanderia.Add(servico);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<ServicoLavanderia> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.ServicosLavanderia.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.ServicosLavanderia.FirstOrDefault(s => s.IdServico == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ServicoLavanderia servico)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.ServicosLavanderia.FirstOrDefault(s => s.IdServico == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(servico);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.ServicosLavanderia.FirstOrDefault(s => s.IdServico == id);
                if(item == null)
                {
                    return; 
                }
                _context.ServicosLavanderia.Remove(item);
                _context.SaveChanges();
            }
        }
    }