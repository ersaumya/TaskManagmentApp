using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Application.Tasks.Commands;
using TaskManagment.Application.Tasks.Dto;
using TaskManagment.Core.Entities;

namespace TaskManagment.Application.Tasks.MappingProfiles
{
    //We use AutoMapper here to automatically map the properties of the CreateTaskCommand to Task.
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<CreateTaskCommand, Task>();
            CreateMap<UpdateTaskCommand, Task>();
            CreateMap<Task, TaskDto>();
        }
    }
}
