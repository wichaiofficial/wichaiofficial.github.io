using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;


namespace WX.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Rating> Get()
        {
            return RatingManager.Load();
        }

        [HttpGet("{id}")]
        public Rating Get(int id)
        {
            return RatingManager.LoadbyId(id);
        }

        [HttpPost("{rollback?}")]
        public IActionResult Post([FromBody] Rating rating, bool rollback = false)
        {
            try
            {
                RatingManager.Insert(rating, rollback);
                return Ok(rating.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPut("{id}/{rollback?}")]
        public IActionResult Put([FromBody] Rating rating, bool rollback = false)
        {
            try
            {
                int result = RatingManager.Update(rating, rollback);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}/{rollback?}")]
        public IActionResult Delete(int id, bool rollback = false)
        {
            try
            {
                int result = RatingManager.Delete(id, rollback);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
