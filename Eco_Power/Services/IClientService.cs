namespace Eco_Power.Services;

using Eco_Power.Models;

public interface IClientService
{
    Task RegisterUser(string email, string password, string name);
    Task UpdateClientAsync(Client client);
    Task DeleteClientAsync(int id); 
}
