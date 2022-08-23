using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class TimeTrackEntry : BaseEntity
    {
        public Guid UserId;
        public Guid ProjectId;
        public int Value;
        public DateTime Date;

        public TimeTrackEntry(Guid id, string comment, Guid userId, Guid projectId, int value, DateTime date) : base(id, comment)
        {
            UserId = userId;
            ProjectId = projectId;
            Value = value;
            Date = date;
        }
    }
}
