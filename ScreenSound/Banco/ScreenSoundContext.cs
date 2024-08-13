using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound;

internal class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas {get; set;}
    public DbSet<Musica> Musicas {get; set;}
    private string connectionString = "data Source=localhost;initial catalog=ScreenSound;integrated security=false;persist security info=true;user id=sa;password=@Abc1234;Encrypt=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}
