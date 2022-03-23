using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class UserConversation
    {
        #region Constructor
        public UserConversation()
        {

        }
        #endregion

        #region Properties

        // Primary & Foreign Key
        public Guid? ConversationId { get; set; }
        public Guid? UserId { get; set; }

        public bool? IsRead { get; set; }
        #endregion
    }
}
