using Microsoft.AspNetCore.Mvc;

namespace hotel_api;

    [Route("api/[controller]")]
    [ApiController]
    public class ConsumoRestauranteFrigobarController : Controller {
        [HttpPost]
        public void Post([FromBody] ConsumoRestauranteFrigobar consumo) 
        {
            using (var _context = new HotelApiContext())
            {
                _context.Consumos.Add(consumo);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public List<ConsumoRestauranteFrigobar> Get()
        {
            using (var _context = new HotelApiContext())
            {
                return _context.Consumos.ToList();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Consumos.FirstOrDefault(c => c.IdConsumo == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ConsumoRestauranteFrigobar consumo)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Consumos.FirstOrDefault(c => c.IdConsumo == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(consumo);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelApiContext())
            {
                var item = _context.Consumos.FirstOrDefault(c => c.IdConsumo == id);
                if(item == null)
                {
                    return; 
                }
                _context.Consumos.Remove(item);
                _context.SaveChanges();
            }
        }
    }
