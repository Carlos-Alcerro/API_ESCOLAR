using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SERVER_ESCOLAR.Models;

namespace SERVER_ESCOLAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosContext _context;

        public UsuariosController(UsuariosContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult>CrearUsuario(Usuario usuario)
        {

            var passworHash = new PasswordHasher<Usuario>();
            usuario.Contrasena = passworHash.HashPassword(usuario, usuario.Contrasena);
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return Ok();

        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginUsuario(string correo, string contrasena)
        {
              var user = await _context.Usuarios.FirstOrDefaultAsync(u=>u.Correo==correo);
            if(user == null)
            {
                return Unauthorized();
            }

            var passwordHasher = new PasswordHasher<Usuario>();
            var result = passwordHasher.VerifyHashedPassword(user, user.Contrasena, contrasena);        
            if(result == PasswordVerificationResult.Failed)
            {
                return Unauthorized();
            }

            var usuarioNuevo = new Usuario
            {
                Id = user.Id,
                Correo = user.Correo,
                Nombres = user.Nombres,
                Apellidos= user.Apellidos,
                Direccion = user.Direccion,
                Ciudad = user.Ciudad,
                Rol = user.Rol 
           };

            return Ok( usuarioNuevo );
         }

        [HttpPut]
        [Route("actualizar")]
        public async Task<IActionResult>ActualizarUsuario(int id, Usuario usuario)
        {
            var passworHash = new PasswordHasher<Usuario>();
            var usuarioExiste = await _context.Usuarios.FindAsync(id);
            if(usuarioExiste == null)
            {
                return NotFound();
            }
            usuarioExiste.Nombres = usuario.Nombres;
            usuarioExiste.Apellidos = usuario.Apellidos;
            usuarioExiste.Correo = usuario.Correo;

            if (!string.IsNullOrEmpty(usuario.Contrasena))
            {
                var passwordHasher = new PasswordHasher<Usuario>();
                usuarioExiste.Contrasena = passwordHasher.HashPassword(usuarioExiste, usuario.Contrasena);
            }
            usuarioExiste.Direccion = usuario.Direccion;
            usuarioExiste.Ciudad = usuario.Ciudad;
            usuarioExiste.Rol = usuario.Rol;


            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Usuario>>> MostrarUsuarios()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            if (usuarios == null)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }

        [HttpGet]
        [Route("usuario")]
        public async Task<ActionResult<IEnumerable<Usuario>>> MostrarUsuario(int id) {
            var usuario = await _context.Usuarios.FindAsync(id);
            if(usuario == null)
            {
                return NotFound();
            }

            var nuevoUsuario = new Usuario
            {
                Apellidos = usuario.Apellidos,
                Nombres = usuario.Nombres,
                Direccion = usuario.Direccion,
                Correo = usuario.Correo,
                Rol = usuario.Rol,
                Ciudad = usuario.Ciudad,
            };

            return Ok(nuevoUsuario);

        }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult>EliminarUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if(usuario == null)
            {
                return NotFound();
            }

  
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                return Ok();
            
            
        }
    }
}
