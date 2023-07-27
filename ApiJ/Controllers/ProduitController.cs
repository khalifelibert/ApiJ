using ApiJ.Models;
using ApiJ.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiJ.Controllers
{
    [Route("api/[controller]")] // /api/produit
    [ApiController]
    public class ProduitController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<JusNaturel>> GetAll() => JusNaturelService.GetAll();


        [HttpGet("{id}")]
        public ActionResult<JusNaturel> Get(int id)
        { 
            var jusNaturel = JusNaturelService.Get(id);
            if (jusNaturel == null)
            
                return NotFound();

           return jusNaturel;
        }

        [HttpPost]

        public IActionResult Create(JusNaturel jusNaturel)
        {
            JusNaturelService.Add(jusNaturel);
            return CreatedAtAction(nameof(Get), new { id = jusNaturel.Id }, jusNaturel);
        }
        /*

        [HttpPut("{id}")]

        public IActionResult Update()
        {

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
        }
        */
        /*
        public ActionResult PostPr()
        {

            string[] pr = { };

            if (string.IsNullOrEmpty(pr[0]) ) return NotFound();
            return NoContent();
        }
        */



        [HttpDelete("{id}")]
        public ActionResult Deletepr(string id)
        {
            bool del = false;

            if(del)
                return BadRequest(string.Empty);
            return NoContent();
        }
    }
}
