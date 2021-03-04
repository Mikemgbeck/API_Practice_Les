using System.Collections.Generic;
using AutoMapper;
using Commander.Data.CommandRepo;
using Commander.DTOs.CommandDTOs;
using Commander.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommandRepository _commandRepository;
        public CommandsController(
            ICommandRepository commandRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _commandRepository = commandRepository;
        }

        // GET api/commands
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            // bool success;
            // success = Request.Cookies.ContainsKey("X-Commander-Token");
            var commands = _commandRepository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commands));
        }

        // GET api/commands/{id}
        // we give this method a name so we can use it elsewhere (in the create section to return the new object upon successful creation of items)
        [HttpGet("{id}", Name = "GetCommandById")]
        [Authorize]
        public ActionResult<CommandReadDTO> GetCommandById(int id)
        {
            var command = _commandRepository.GetCommandById(id);
            if (command != null)
            {
                return Ok(_mapper.Map<CommandReadDTO>(command));
            }

            return NotFound();
        }

        // POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDTO> CreateCommand(CommandCreateDTO commandCreateDTO)
        {
            var newCommand = _mapper.Map<Command>(commandCreateDTO);

            _commandRepository.CreateCommand(newCommand);
            _commandRepository.SaveChanges();

            var newCommandReadDto = _mapper.Map<CommandReadDTO>(newCommand);

            return CreatedAtRoute(nameof(GetCommandById), new { id = newCommandReadDto.Id }, newCommandReadDto);
        }

        // PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDTO commandUpdateDTO)
        {
            // var editedCommand = _commandRepository.GetCommandById(id);

            // if (editedCommand != null)
            // {
            //     _mapper.Map(commandUpdateDTO, editedCommand);

            //     _commandRepository.SaveChanges();

            //     // Les says to include this but since we're not implementing it it didn't make sense for me to add it
            //     //_commandRepository.UpdateCommand(editedCommand);

            //     return NoContent();
            // }

            // return NotFound();
            var lookForCommand = _commandRepository.GetCommandById(id);

            if (lookForCommand != null)
            {
                var commandToUpdate = _mapper.Map<Command>(commandUpdateDTO);
                _commandRepository.UpdateCommand(id, commandToUpdate);
                _commandRepository.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        // PATCH api/commands/{id}
        // [HttpPatch("{id}")]
        // public ActionResult PatchCommand(int id, JsonPatchDocument<CommandUpdateDTO> patchDocument)
        // {
        //     var patchedCommand = _commandRepository.GetCommandById(id);
        //     if (patchedCommand != null)
        //     {
        //         var commandToPatch = _mapper.Map<CommandUpdateDTO>(patchedCommand);
        //         patchDocument.ApplyTo(commandToPatch, ModelState);
        //         if (!TryValidateModel(commandToPatch))
        //         {
        //             return ValidationProblem(ModelState);
        //         }

        //         _mapper.Map(commandToPatch, patchedCommand);

        //         // Les says to include this but since we're not implementing it it didn't make sense for me to add it
        //         //_commandRepository.UpdateCommand(editedCommand);

        //         _commandRepository.SaveChanges();

        //         return NoContent();
        //     }

        //     return NotFound();
        // }

        // DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandToDelete = _commandRepository.GetCommandById(id);

            if (commandToDelete != null)
            {
                _commandRepository.DeleteCommand(commandToDelete);
                _commandRepository.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }
    }
}