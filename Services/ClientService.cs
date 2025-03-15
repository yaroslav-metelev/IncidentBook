﻿using IncidentBook.Models;
using IncidentBook.Repositories;
using Microsoft.EntityFrameworkCore;

namespace IncidentBook.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientReposiory;

        public ClientService(IClientRepository clientReposiory)
        {
            _clientReposiory = clientReposiory;
        }

        public async Task<List<ClientItem>> GetAllClients()
        {
            return await _clientReposiory.GetAllClients();
        }

        public async Task<ClientItem?> GetClientItem(int id)
        {
            // Тут может быть более сложная логика, обращение к нескольким репозиториям и т. д.
            return await _clientReposiory.GetClientItem(id);
        }
    }
}
