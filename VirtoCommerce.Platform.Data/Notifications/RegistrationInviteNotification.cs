using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Notifications;

namespace VirtoCommerce.Platform.Data.Notifications
{
    public class RegistrationInviteNotification : EmailNotification
    {
        public RegistrationInviteNotification(IEmailNotificationSendingGateway gateway)
            : base(gateway)
        {
        }

        [NotificationParameter("Invite URL")]
        public string Url { get; set; }
    }
}
