﻿namespace Eco_Power.Services;

using Eco_Power.Models;
using Eco_Power.Data;

public class ClientService : IClientService
{
    private readonly YourDbContext _context; 

    public ClientService(YourDbContext context)
    {
        _context = context;
    }

    public async Task RegisterUser(string email, string password, string name)
    {
        var client = new Client { Email = email, Password = password, Name = name }; 
        _context.Clients.Add(client); 
        await _context.SaveChangesAsync(); 
    }

    public async Task UpdateClientAsync(Client client)
    {
        _context.Clients.Update(client);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteClientAsync(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
