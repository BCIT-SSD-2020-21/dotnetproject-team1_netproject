using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Parlez.Data;
using Parlez.Models;

namespace Parlez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatDbContext _db;

        //public Messages UserId { get; }
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ChatController(ChatDbContext db, 
                              UserManager<IdentityUser> userManager, 
                              SignInManager<IdentityUser> signInManager )
        { 
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            
        }

        //Get All Method to display chat
        [HttpGet]
        public IActionResult GetAllMessage()
        {
            try
            {
                var messages = _db.Messages.ToList();
                if (!messages.Any())
                {
                    return NoContent();
                }
                return Ok(messages);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpGet("{id}", Name = "GetOne")]
        public IActionResult GetById(int id)
        {
            var messages = _db.Messages.Where(m => m.Id == id).FirstOrDefault();

            return Ok(messages);
        }

        //Post Method to submit chat
        [HttpPost]
        public IActionResult Create([FromBody] Messages messages)
        {
            if(_signInManager.IsSignedIn(User))
                messages.UserId = _userManager.GetUserId(User);
            
            if(messages.MessageText != null || messages.MessageText != "")
            {
                try
                {
                    _db.Messages.Add(messages); //adds message to messages db
                    _db.SaveChanges(); //commits the change
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
                return Ok(messages);
            }
            return BadRequest();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        [Route("MyDelete")]
        public IActionResult MyDelete(long Id)
        {
            var messages = _db.Messages.Where(t => t.Id == Id && t.UserId == _userManager.GetUserId(User)).FirstOrDefault();
            if (messages == null)
            {
                return NotFound();
            }
            _db.Messages.Remove(messages);
            _db.SaveChanges();
            return new ObjectResult(messages);
        }
    }
}
