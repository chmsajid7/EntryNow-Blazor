using EntryNow.Web.Models;
using System.Threading.Tasks;

namespace EntryNow.Web.Services.Interface
{
    public interface IAccountService
    {
        Token Token { get; }
        Task Initialize();
        Task Logout();
    }
}
