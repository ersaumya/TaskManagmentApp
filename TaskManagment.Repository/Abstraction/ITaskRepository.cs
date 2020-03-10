using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Application.Abstraction
{
    public interface ITaskRepository:IGenericRepository<Core.Entities.Task>
    {
    }
}
