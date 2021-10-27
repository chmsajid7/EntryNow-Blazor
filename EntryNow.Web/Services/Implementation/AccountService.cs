using EntryNow.Web.Models;
using EntryNow.Web.Services.Interface;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntryNow.Web.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly NavigationManager navigationManager;
        private string userKey = "user";

        public Token Token { get; private set; }
        public AccountService(ILocalStorageService localStorageService,
            NavigationManager navigationManager)
        {
            this.localStorageService = localStorageService;
            this.navigationManager = navigationManager;
        }   
        public async Task Initialize()
        {
            Token = await localStorageService.GetItem<Token>(userKey);
        }
        public async Task Logout()
        {
            Token = null;
            await localStorageService.RemoveItem(userKey);
        }
    }
}
