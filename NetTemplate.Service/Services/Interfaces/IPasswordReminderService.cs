using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTemplate.BLL.Services.Interfaces
{
    public interface IPasswordReminderService
    {
        Task SendRemindersAsync();
    }
}
