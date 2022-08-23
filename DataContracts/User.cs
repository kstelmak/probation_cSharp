using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public enum Roles
    {
        User, Admin
    }
    public class User: BaseEntity
    {
        public string Username;
        private string Password;
        public string FullName;
        public bool IsActive;
        public Roles AccessRole;

        public User(Guid id, string comment, string username, string password, string fullName, bool isActive, Roles role) : base(id, comment)
        {
            
            Username = username;
            Password = password;
            FullName = fullName;
            IsActive = isActive;
            AccessRole = role;
        }
    }
}
