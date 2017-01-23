using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetIdentityFromScratch
{
    public interface IMessageService
    {
        Task Send(string email, string subject, string message);
    }
}
