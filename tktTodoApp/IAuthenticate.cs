using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;

namespace tktTodoApp
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateUser();
    }
}
