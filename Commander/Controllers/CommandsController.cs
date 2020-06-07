using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Data;
using Commander.Models;
using Commander.Dtos;
using AutoMapper;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repositorty, IMapper mapper)
            {
                _repository = repositorty;
                _mapper = mapper;
            }

        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems= _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }


        //Get api/commands/5
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem= _repository.GetCommandById(id);
            if (commandItem != null)
            {
            return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreatDto)
        {
            // return ;
        }

    }
}