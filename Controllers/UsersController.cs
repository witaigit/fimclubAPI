using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using FilmClub.Services.Data;
using FilmClub.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace FilmClub.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly FilmClubContext Context;

        public UsersController(FilmClubContext context) {
            this.Context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.Context.Users.ToListAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this.Context.Users.FindAsync(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            await this.Context.Users.AddAsync(user);
            await this.Context.SaveChangesAsync();
            return Created(this.HttpContext.Request.Path, user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
