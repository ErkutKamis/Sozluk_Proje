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
    public class WriterManager : IWriterService
    {
        readonly IWriter _writer;

        public WriterManager(IWriter writer)
        {
            _writer = writer;
        }

        public Writer GetById(int id)
        {
            return _writer.Get(x => x.Id == id);
        }

        public List<Writer> GetList()
        {
            return _writer.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writer.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writer.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writer.Update(writer);
        }
    }
}
