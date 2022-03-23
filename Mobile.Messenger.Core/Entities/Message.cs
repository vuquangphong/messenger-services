using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class Message
    {
        #region Constructor 
        public Message()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? MessageId { get; set; }

        // Foreign Key
        public Guid? ConversationId { get; set; }

        // Foreign Key
        public Guid? SenderId { get; set; }

        public string? Content { get; set; }

        public DateTime? CreatedDate { get; set; }

        #endregion
    }
}
