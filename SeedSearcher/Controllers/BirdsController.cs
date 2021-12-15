using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeedSearcher.Data;
using SeedSearcher.Models;
using SeedSearcher.ML_Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http.Headers;

namespace SeedSearcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : ControllerBase
    {
        private readonly SeedSearcherContext _context;
        private IWebHostEnvironment _hostingEnvironment;

        public BirdsController(SeedSearcherContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostEnvironment;
        }

        // GET: api/Birds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bird>>> GetBirds()
        {
            return await _context.Bird.ToListAsync();
        }

        // GET: api/Birds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bird>> GetBird(int id)
        {
            var bird = await _context.Bird.FindAsync(id);

            if (bird == null)
            {
                return NotFound();
            }

            return bird;
        }

        //[HttpPost, DisableRequestSizeLimit]
        //public ObjectResult ImageUpload()
        //{

        //}

       
    }
}
