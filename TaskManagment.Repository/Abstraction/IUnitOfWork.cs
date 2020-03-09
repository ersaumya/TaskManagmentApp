using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagment.Repository.Abstraction
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }
    }
}
