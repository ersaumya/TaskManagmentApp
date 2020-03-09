using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagment.Application.Tasks.Commands;
using TaskManagment.Application.Tasks.Dto;
using TaskManagment.Application.Tasks.Queries;

namespace TaskManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //In this controller, we only need to send the request in MediatR and then MediatR will look for what handler need to be executed for the request.
    public class TasksController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTaskCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllTasksQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<TaskDto>> Get(int id)
        {
            return await Mediator.Send(new GetTaskByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateTaskCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteTaskCommand { Id = id });
        }
    }
}