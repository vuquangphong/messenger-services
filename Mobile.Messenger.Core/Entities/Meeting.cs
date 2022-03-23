using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class Meeting
    {
        #region Constructor
        public Meeting()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? MeetingId { get; set; }

        // Foreign Key
        public Guid? ConversationId { get; set; }
        
        // Foreign Key
        public Guid? HostId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? IsActive { get; set; }

        #endregion
    }
}
