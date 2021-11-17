using EntryNow.Web.Models;
using EntryNow.Web.Services;
using System.Threading.Tasks;

namespace EntryNow.Web.Helpers
{
    public class PageNumberHelper
    {
        private ILocalStorageService localStorageService;
        private string entriesPageNoStorageKey = "entriesPageNumber";
        public PageNumber pageNumber { get; private set; }

        public PageNumberHelper(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }
        public async Task SaveEntriesPageNo(int pageNumber)
        {
            this.pageNumber = new PageNumber()
            {
                pageNumber = pageNumber
            };
            await localStorageService.SetItem(entriesPageNoStorageKey, this.pageNumber);
        }

        public async Task<int> GetEntriesPageNo()
        {
            this.pageNumber = await localStorageService.GetItem<PageNumber>(entriesPageNoStorageKey);
            if (this.pageNumber == null)
            {
                return 1;
            }
            await localStorageService.RemoveItem(entriesPageNoStorageKey);
            return this.pageNumber.pageNumber;
        }
    }
}
