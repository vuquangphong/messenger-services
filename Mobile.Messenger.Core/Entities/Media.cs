using Mobile.Messenger.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Entities
{
    public class Media
    {
        #region Constructor
        public Media()
        {

        }
        #endregion

        #region Properties

        // Primary Key
        public Guid? MediaId { get; set; }

        // Foreign Key
        public Guid? MessageId { get; set; }

        public string? PathName { get; set; }

        public string? MediaName { get; set; }

        public MediaType? Type { get; set; }

        #endregion
    }
}
