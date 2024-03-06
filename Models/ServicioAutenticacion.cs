using Dent.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Dent.Models
{


    public class ServicioAutenticacion
    {
        // Método para validar las credenciales del usuario

        [Inject]
        private DbDentistaContext DbContext { get; set; }



        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {

            var entidad = new Login();
 
            entidad = DbContext.Logins.SingleOrDefault(e => e.Usuario == nombreUsuario);


                    if (entidad != null)
                {
                    // Obtener la clave primaria
             //       var clavePrimaria = DbContext.Entry(entidad).Property("Id").CurrentValue;
                    return true;
                    
                }
                else
                
                    return false;
                }
                    

                
            }


        }




    

