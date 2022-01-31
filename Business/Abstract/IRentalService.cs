using Core.Entities.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IDataResult<List<Rentals>> GetAll();
        IResult Add(Rentals rentals);
        IResult Delete(Rentals rentals);
        IResult Update(Rentals rentals);

    }
}
