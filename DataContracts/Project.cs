using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class Project : BaseEntity
    {
        public string Name;
        public DateTime ExpirationDate;
        public int MaxHours;
        public Guid LeaderUserId;

        public Project(Guid id, string comment, string name, DateTime expirationDate, int maxHours, Guid leaderUserId) : base(id, comment)
        {
            Name = name;
            ExpirationDate = expirationDate;
            MaxHours = maxHours;
            LeaderUserId = leaderUserId;
        }
    }
}
