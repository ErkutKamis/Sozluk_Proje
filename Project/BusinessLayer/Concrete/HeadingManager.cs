using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        readonly IHeading _Heading;

        public HeadingManager(IHeading heading)
        {
            _Heading = heading;
        }

        public Heading GetById(int id)
        {
            return _Heading.Get(x => x.Id == id);
        }

        public List<Heading> GetList()
        {
            return _Heading.List();
        }

        public List<Heading> GetListByWriter(int id)
        {
            return _Heading.List(x => x.WriterId == id);
        }

        public void HeadingAdd(Heading heading)
        {
            _Heading.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            
            _Heading.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _Heading.Update(heading);
        }
    }
}
