using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Data;
using Commander.Models;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repositorty)
            {
                _repository = repositorty;
            }

        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems= _repository.GetAllCommands();
            return Ok(commandItems);
        }


        //Get api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem= _repository.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}