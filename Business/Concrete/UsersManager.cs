using Business.Abstract;
using Business.Constants;
using Core.Entities.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users users)
        {
            if (users.FirstName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.UsersNameInvalid);
            }
            _usersDal.Add(users);
            return new SuccessResult("Kullanıcı Eklendi");
        }

        public IResult Delete(Users users)
        {
            if (users.FirstName.Length<2)
            {
                return new ErrorResult(Messages.UsersNameInvalid);
            }
            _usersDal.Delete(users);
            return new SuccessResult("Kullanıcı Silindi");
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll());
        }

        public IResult Update(Users users)
        {
            if (users.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UsersNameInvalid);
            }
            _usersDal.Update(users);
            return new SuccessResult("Kullanıcı Güncellendi");
        }
    }
}
