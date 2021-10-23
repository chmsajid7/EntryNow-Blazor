using BlazorPagination;
using EntryNow.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntryNow.Web.Services.Interface
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task<bool> Login(Login model);
        Task Logout();
        Task Register(AddUser model);
        Task<IList<User>> GetAll();
        Task<IList<User>> GetAllEntries();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }

}
