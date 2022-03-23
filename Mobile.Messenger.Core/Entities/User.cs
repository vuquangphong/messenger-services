using Mobile.Messenger.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class User
    {
        #region Constructor
        public User()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? UserId { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? FullName { get; set; }

        public Gender? Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public UserStatus? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate  { get; set; }

        #endregion
    }
}
