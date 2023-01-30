using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMemberServis
    {
        public List<Member> GetAll();
        public void Add(Member entity);
        public void Update(Member entity);
        public void Delete(Member entity);

       
    }
}
