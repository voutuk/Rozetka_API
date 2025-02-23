using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Advert;
using BusinessLogic.Models.AdvertModels;

namespace BusinessLogic.Interfaces
{
    public interface IAdvertService
    {
         Task<IEnumerable<AdvertDto>> GetAllAsync();
         Task<AdvertDto> CreateAsync(AdvertCreationModel advertCreationModel);
         Task<AdvertDto> GetByIdAsync(int id);
    }
}