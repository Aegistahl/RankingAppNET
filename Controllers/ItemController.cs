using Microsoft.AspNetCore.Mvc;
using RankingAppNET6.Models;
using RankingAppNET6.Data;
using Microsoft.EntityFrameworkCore;

namespace RankingAppNET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
	{

        private readonly DataContext _context;

        public ItemController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<ItemModel>>> AddItem(ItemModel item)
        {
            _context.ItemModels.Add(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.ItemModels.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemModel>>> GetAllItems()
        {
            return Ok(await _context.ItemModels.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetItem(int id)
        {
            var item = await _context.ItemModels.FindAsync(id);
            if(item == null)
            {
                return BadRequest("Movie not found.");
            }
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ItemModel>>> Delete(int id)
        {

            var item = await _context.ItemModels.FindAsync(id);
            if (item == null)
                return BadRequest("Movie not found.");
            

            _context.ItemModels.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.ItemModels.ToListAsync());


        }



    }

}


