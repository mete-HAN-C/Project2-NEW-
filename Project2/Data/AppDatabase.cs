using SQLite;
using Project2.Models;

namespace Project2.Data;

public class AppDatabase
{
    private readonly SQLiteAsyncConnection _db;
    private bool _initialized;

    public AppDatabase(string dbPath)
    {
        _db = new SQLiteAsyncConnection(dbPath);
    }

    private async Task InitAsync()
    {
        if (_initialized) return;
        await _db.CreateTableAsync<Person>();
        _initialized = true;
    }

    public async Task<List<Person>> GetPersonsAsync()
    {
        await InitAsync();
        return await _db.Table<Person>().ToListAsync();
    }

    public async Task<Person?> GetByEmailAsync(string email)
    {
        await InitAsync();
        return await _db.Table<Person>().Where(x => x.Email == email).FirstOrDefaultAsync();
    }

    public async Task<int> AddPersonAsync(Person p)
    {
        await InitAsync();
        return await _db.InsertAsync(p);
    }

    public async Task<int> UpdatePersonAsync(Person p)
    {
        await InitAsync();
        return await _db.UpdateAsync(p);
    }

    public async Task<int> DeletePersonAsync(Person p)
    {
        await InitAsync();
        return await _db.DeleteAsync(p);
    }
}
