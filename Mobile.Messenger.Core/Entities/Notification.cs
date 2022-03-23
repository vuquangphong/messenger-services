using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class Notification
    {
        #region Constructor
        public Notification()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? NotificationId { get; set; }

        public string? Content { get; set; }

        public bool? IsRead { get; set; }

        // Foreign Key
        public Guid? SenderId { get; set; }

        // Foreign Key
        public Guid? ConversationId { get; set; }

        public DateTime? CreatedDate { get; set; }

        #endregion
    }
}
