using EmptyASPNETCore.Models;

namespace EmptyASPNETCore.Data
{
    public class Database
    {
        private readonly BirthdayDbContext _ctx;

        public Database(BirthdayDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Seed()
        {
            await _ctx.Birthdays.AddRangeAsync(new List<Birthday>(){
                new Birthday(new DateTime(1900, 1, 1), "Kalle"),
                new Birthday(new DateTime(2022, 12, 22), "Jens"),
                new Birthday(new DateTime(2000, 03, 10), "Kristina"),
                new Birthday(new DateTime(1987, 03, 9), "Roger"),
                new Birthday(new DateTime(2010, 12, 30), "Jessica")
            });
            await _ctx.SaveChangesAsync();
        }

        public async Task Recreate()
        {
            await _ctx.Database.EnsureDeletedAsync();
            await _ctx.Database.EnsureCreatedAsync();
        }

        public async Task RecreateAndSeed()
        {
            await Recreate();
            await Seed();
        }

        public async Task CreateIfNotExists()
        {
            await _ctx.Database.EnsureCreatedAsync();
        }

        public async Task CreateAndSeedIfNotExists()
        {
            bool didCreateDatabase = await _ctx.Database.EnsureCreatedAsync();

            if (didCreateDatabase)
                await Seed();
        }
    }
}
