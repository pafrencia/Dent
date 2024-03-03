using Dent.Pages;
namespace Dent.Models
{
    public class ServicioAutenticacion
    {
        // Método para validar las credenciales del usuario
        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {

            return nombreUsuario == "Pablo" && contraseña == "123";
        }
    }
}
