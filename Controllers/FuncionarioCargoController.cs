using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioCargoController : Controller {
        [HttpPost]
        public void Post([FromBody] FuncionarioCargo cargo) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.FuncionariosCargos.Add(cargo);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<FuncionarioCargo> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.FuncionariosCargos.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.FuncionariosCargos.FirstOrDefault(f => f.IdCargo == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] FuncionarioCargo cargo)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.FuncionariosCargos.FirstOrDefault(f => f.IdCargo == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(cargo);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.FuncionariosCargos.FirstOrDefault(f => f.IdCargo == id);
                if(item == null)
                {
                    return; 
                }
                _context.FuncionariosCargos.Remove(item);
                _context.SaveChanges();
            }
        }
    }