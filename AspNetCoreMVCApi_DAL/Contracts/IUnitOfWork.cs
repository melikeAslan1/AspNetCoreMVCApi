using AspNetCoreMVCApi_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCCoreApi_DAL.Contracts
{
    public interface IUnitOfWork
    {
       IAssignmentRepo AssignmentRepo { get; }

       


    }
}
