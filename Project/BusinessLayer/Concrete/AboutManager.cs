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
    public class AboutManager : IAboutService
    {
        readonly IAbout _about;

        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void AboutAdd(About about)
        {
            _about.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _about.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _about.Update(about);
        }

        public About GetById(int id)
        {
            return _about.Get(x => x.Id == id);
        }

        public List<About> GetList()
        {
            return _about.List();
        }
    }
}
