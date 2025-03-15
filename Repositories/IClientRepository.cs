using IncidentBook.Models;

namespace IncidentBook.Repositories
{
    public interface IClientRepository
    {
        Task<List<ClientItem>> GetAllClients();
        Task<ClientItem?> GetClientItem(int id);
    }
}