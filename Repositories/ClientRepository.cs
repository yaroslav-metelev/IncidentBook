using IncidentBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IncidentBook.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private IncidentContext _context;

        public ClientRepository(IncidentContext context)
        {
            _context = context;
        }

        public async Task<List<ClientItem>> GetAllClients()
        {
            return await _context.ClientItems.ToListAsync();
        }

        public async Task<ClientItem?> GetClientItem(int id)
        {
            var clientItem = await _context.ClientItems.FindAsync(id);
            return clientItem;
        }
    }
}
