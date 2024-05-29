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
        private readonly Models.AppContextDB _context;

        public UsuariosController(Models.AppContextDB context)
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
                IdUsuario = user.IdUsuario,
                Correo = user.Correo,
                Nombres = user.Nombres,
                Apellidos= user.Apellidos,
                Direccion = user.Direccion,
                IdRol= user.IdRol,
                IdSequencia=user.IdSequencia,
                UsuarioBloqueado=user.UsuarioBloqueado,
                FechaNacimiento=user.FechaNacimiento,
                UsuarioId=user.UsuarioId,
                Dni=user.Dni,
                Sexo=user.Sexo,
                Telefono=user.Telefono
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
            usuarioExiste.Dni = usuario.Dni;
            usuarioExiste.Telefono = usuario.Telefono;
            usuarioExiste.FechaNacimiento = usuario.FechaNacimiento;
            usuarioExiste.Sexo = usuario.Sexo;
            usuarioExiste.UsuarioBloqueado = usuario.UsuarioBloqueado;
            usuarioExiste.UsuarioId = usuario.UsuarioId;
            usuarioExiste.IdRol = usuario.IdRol;
            usuarioExiste.IdSequencia = usuario.IdSequencia;


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
                IdUsuario = usuario.IdUsuario,
                Correo = usuario.Correo,
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Direccion = usuario.Direccion,
                IdRol = usuario.IdRol,
                IdSequencia = usuario.IdSequencia,
                UsuarioBloqueado = usuario.UsuarioBloqueado,
                FechaNacimiento = usuario.FechaNacimiento,
                UsuarioId = usuario.UsuarioId,
                Dni = usuario.Dni,
                Sexo = usuario.Sexo,
                Telefono = usuario.Telefono
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
