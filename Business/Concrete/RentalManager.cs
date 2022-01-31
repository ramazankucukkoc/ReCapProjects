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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rentals)
        {
            if (rentals.ReturnDate == null)
            {
                _rentalDal.Add(rentals);
                return new ErrorResult(Messages.CarNoReturnDate);
            }
            _rentalDal.Add(rentals);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Rentals rentals)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rentals rentals)
        {
            throw new NotImplementedException();
        }
    }
}
