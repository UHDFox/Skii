using SkiiResort.Application.Tariffication.Models;

namespace SkiiResort.Application.Tariffication;

public interface ITarifficationService
{
    Task<IReadOnlyCollection<GetTarifficationModel>> GetAllAsync(int offset, int limit);

    Task<GetTarifficationModel> GetByIdAsync(Guid id);

    Task<Guid> AddAsync(AddTarifficationModel model);

    Task<UpdateTarifficationModel> UpdateAsync(UpdateTarifficationModel model);

    Task<bool> DeleteAsync(Guid id);
}
