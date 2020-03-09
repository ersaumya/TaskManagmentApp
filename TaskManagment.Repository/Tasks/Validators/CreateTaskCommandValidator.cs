using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Application.Tasks.Commands;

namespace TaskManagment.Application.Tasks.Validators
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        //we can use the CreateTaskCommand to create a Task, but it does not have any validation on it.So,we create CreateTaskCommandValidator using fluent validation.
        //The CreateTaskCommandValidator will inherit the AbstractValidator. We pass the class that needs to be validated inside the <> in AbstractValidator. 
        //Then we set the validation rules inside the constructor.
        public CreateTaskCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Description).NotEmpty();
            RuleFor(t => t.Status).NotNull();
            RuleFor(t => t.DueDate).NotNull();
        }
    }
}
