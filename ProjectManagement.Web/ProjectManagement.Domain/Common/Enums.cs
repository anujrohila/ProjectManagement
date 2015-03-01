using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Domain
{
    public static class ApplicationEnum
    {
        public enum OrderStatus
        {
            All = 0,
            Pending = 1,
            Approved = 2,
            InProgress = 3,
            Completed = 4
        }

        public enum LoginPageStatus
        {
            OK = 0,
            UnconfirmedAccount = 1,
            AccountLocked= 2,
            NoUsers = 3,
            PasswordIncorrect = 4,
            NumberofAttempts = 5,
        }
    }

}
