using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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


        public ChatController(ChatDbContext db)
        { 
            _db = db; 
        }

        //Get All method
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
                //return new ObjectResult(todos);
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
            //return new ObjectResult(todo);
            return Ok(messages);
        }

        //Post Method
        [HttpPost]
        public IActionResult Create([FromBody] Messages messages)
        {
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

        [HttpDelete]
        [Route("MyDelete")] // Custom route
        public IActionResult MyDelete(long Id)
        {
            var messages = _db.Messages.Where(t => t.Id == Id).FirstOrDefault();
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
