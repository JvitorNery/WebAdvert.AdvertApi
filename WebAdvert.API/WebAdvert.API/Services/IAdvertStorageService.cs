using AdvertApi.Models;
using System.Threading.Tasks;

namespace WebAdvert.API.Services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);

        Task Confirm(ConfirmAdvertModel model);
    }
}
