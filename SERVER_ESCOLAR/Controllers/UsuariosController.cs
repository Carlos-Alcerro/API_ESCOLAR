using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SERVER_ESCOLAR.Models;

namespace SERVER_ESCOLAR.Controllers
{

    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int? IdRol { get; set; }
        public string Rol { get; set; } 
        public int UsuarioBloqueado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
    }


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
        public async Task<IActionResult>CrearUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int idRolPorDefecto = 1;

            if(usuario.IdRol==null)
            {
                usuario.IdRol = idRolPorDefecto;
            }

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
              var user = await _context.Usuarios.Include(u=>u.Rol).FirstOrDefaultAsync(u=>u.Correo==correo);
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

            var usuarioNuevo = new UsuarioDto
            {
                IdUsuario = user.IdUsuario,
                Correo = user.Correo,
                Nombres = user.Nombres,
                Apellidos = user.Apellidos,
                Direccion = user.Direccion,
                IdRol = user.IdRol,
                Rol = user.Rol.DescripcionRol,
                UsuarioBloqueado = user.UsuarioBloqueado,
                FechaNacimiento = user.FechaNacimiento,
                Dni = user.Dni,
                Sexo = user.Sexo,
                Telefono = user.Telefono
            };

            return Ok( usuarioNuevo );
         }

        [HttpPut]
        [Route("actualizar")]
        public async Task<IActionResult> ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            var usuarioExiste = await _context.Usuarios.FindAsync(id);
            if (usuarioExiste == null)
            {
                return NotFound();
            }

            usuarioExiste.Nombres = usuario.Nombres ?? usuarioExiste.Nombres;
            usuarioExiste.Apellidos = usuario.Apellidos ?? usuarioExiste.Apellidos;
            usuarioExiste.Correo = usuario.Correo ?? usuarioExiste.Correo;
            usuarioExiste.Direccion = usuario.Direccion ?? usuarioExiste.Direccion;
            usuarioExiste.Dni = usuario.Dni ?? usuarioExiste.Dni;
            usuarioExiste.Telefono = usuario.Telefono ?? usuarioExiste.Telefono;
            usuarioExiste.FechaNacimiento = usuario.FechaNacimiento != default ? usuario.FechaNacimiento : usuarioExiste.FechaNacimiento;
            usuarioExiste.Sexo = usuario.Sexo ?? usuarioExiste.Sexo;
            usuarioExiste.UsuarioBloqueado = usuario.UsuarioBloqueado != default ? usuario.UsuarioBloqueado : usuarioExiste.UsuarioBloqueado;
            usuarioExiste.IdRol = usuario.IdRol != default ? usuario.IdRol : usuarioExiste.IdRol;

            if (!string.IsNullOrEmpty(usuario.Contrasena))
            {
                var passwordHasher = new PasswordHasher<Usuario>();
                usuarioExiste.Contrasena = passwordHasher.HashPassword(usuarioExiste, usuario.Contrasena);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> MostrarUsuarios()
        {
            var usuarios = await _context.Usuarios
                .Include(u => u.Rol)
                .Select(u => new UsuarioDto
                {
                    IdUsuario = u.IdUsuario,
                    Correo = u.Correo,
                    Nombres = u.Nombres,
                    Apellidos = u.Apellidos,
                    Direccion = u.Direccion,
                    IdRol = u.IdRol,
                    Rol = u.Rol.DescripcionRol,
                    UsuarioBloqueado = u.UsuarioBloqueado,
                    FechaNacimiento = u.FechaNacimiento,
                    Dni = u.Dni,
                    Sexo = u.Sexo,
                    Telefono = u.Telefono
                })
                .ToListAsync();

            if (usuarios == null || !usuarios.Any())
            {
                return NotFound();
            }

            return Ok(usuarios);
        }


        [HttpGet]
        [Route("usuario/{id}")]
        public async Task<ActionResult<Usuario>> MostrarUsuario(int id)
        {
            // Usar FirstOrDefaultAsync con una expresión lambda para buscar el usuario por id
            var usuario = await _context.Usuarios.Include(u => u.Rol).FirstOrDefaultAsync(u => u.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            var nuevoUsuario = new UsuarioDto
            {
                IdUsuario = usuario.IdUsuario,
                Correo = usuario.Correo,
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Direccion = usuario.Direccion,
                IdRol = usuario.IdRol,
                UsuarioBloqueado = usuario.UsuarioBloqueado,
                FechaNacimiento = usuario.FechaNacimiento,
                Dni = usuario.Dni,
                Sexo = usuario.Sexo,
                Telefono = usuario.Telefono,
                Rol = usuario.Rol.DescripcionRol
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
