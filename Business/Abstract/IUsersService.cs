using Core.Entities.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IResult Add(Users users);
        IResult Delete(Users users);
        IResult Update(Users users);
    }
}
