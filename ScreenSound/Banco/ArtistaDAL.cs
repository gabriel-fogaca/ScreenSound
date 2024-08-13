using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound;

internal class ArtistaDAL : DAL<Artista>
{
    public ArtistaDAL(ScreenSoundContext context): base(context){}
    public Artista? RecuperarPeloNome(string nome){
        return context.Artistas.FirstOrDefault(x => x.Nome.Equals(nome));
    }
}
