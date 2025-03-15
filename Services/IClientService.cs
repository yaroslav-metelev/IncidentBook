using IncidentBook.Models;

namespace IncidentBook.Services
{
    public interface IClientService
    {
        Task<List<ClientItem>> GetAllClients();
        Task<ClientItem?> GetClientItem(int id);
    }
}