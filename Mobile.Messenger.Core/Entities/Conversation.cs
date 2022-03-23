using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class Conversation
    {
        #region Constructor
        public Conversation()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? ConversationId { get; set; }
        public string? Title { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        #endregion
    }
}
