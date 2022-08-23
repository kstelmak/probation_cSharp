using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class BaseEntity
    {
        public Guid Id;
        public string Comment;

        public BaseEntity(Guid id, string comment)
        {
            Id = id;
            Comment = comment;
        }
    }
}
