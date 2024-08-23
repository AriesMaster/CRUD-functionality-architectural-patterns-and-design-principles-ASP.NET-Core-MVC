using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(Guid id);
        Task AddClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(Guid id);
        Task<bool> ClientExistsAsync(Guid id);  // Add this method
    }
}
