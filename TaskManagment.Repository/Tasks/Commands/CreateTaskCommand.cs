using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Core.Enums;

namespace TaskManagment.Application.Tasks.Commands
{
    //CreateTaskCommand is actually a request that will be handled by MediatR and int in IReqest<int> is the expected result of this request.
    //The properties in CreateTaskCommand are the payloads that are needed for this request. In this case we need the Name, descipription, Status and DueDate to create the Task.
    public class CreateTaskCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}
