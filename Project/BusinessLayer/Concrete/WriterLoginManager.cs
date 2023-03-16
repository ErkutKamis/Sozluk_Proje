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
    public  class WriterLoginManager : IWriterLoginService
    {
        IWriter _writer;

        public WriterLoginManager(IWriter writer)
        {
            _writer = writer;
        }

        public Writer GetWriter(string username, string password)
        {
            return _writer.Get(x => x.WriterMail == username && x.WriterPassword == password);
        }
    }
}
