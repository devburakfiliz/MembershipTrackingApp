using Core.Ultilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMemberServis
    {
        IDataResult<List<Member>> GetAll();
        IResult Add(Member entity);
        IResult Update(Member entity);
        IResult Delete(Member entity);

       
    }
}
