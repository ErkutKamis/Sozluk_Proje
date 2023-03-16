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
    public class ContentManager : IContentService
    {
        readonly IContent _Content;

        public ContentManager(IContent content)
        {
            _Content = content;
        }

        public void ContentAdd(Content content)
        {
            _Content.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            return _Content.List();
        }

        public List<Content> GetListById(int id)
        {
            return _Content.List(x => x.HeadingId == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _Content.List(x => x.WriterId == id);
        }
    }
}
