using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using AlumnosCrud.Server.Models;
using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;


namespace AlumnosCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly DbSistemaEscolarContext _dbContext;

        public AlumnoController(DbSistemaEscolarContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Listar a los alumnos
        [HttpGet]
        [Route("ListarAlumnos")]
        public async Task<IActionResult>Alumnos()
        {
            var responseApi = new ResponseAPI<List<AlumnoDTO>>();
            var listaAlumnoDTO = new List<AlumnoDTO>();

            try
            {
                foreach(var item in await _dbContext.TblAlumnos.ToListAsync())
                {
                    listaAlumnoDTO.Add(new AlumnoDTO
                    {
                        id = item.id,
                        primer_nombre = item.primer_nombre,
                        segundo_nombre = item.segundo_nombre,
                        primer_apellido = item.primer_apellido,
                        segundo_apellido = item.segundo_apellido,
                        genero = item.genero,
                        lugar_nacimiento = item.lugar_nacimiento,
                        fecha_nacimiento = item.fecha_nacimiento,
                        direccion = item.direccion,
                        telefono = item.telefono,
                        region = item.region,
                        escuela_procedencia = item.escuela_procedencia,
                        anio_ingreso = item.anio_ingreso,
                        numero_identidad = item.numero_identidad,
                        tiene_hermanos = item.tiene_hermanos,
                        numero_miembros = item.numero_miembros,
                        nombre_madre = item.nombre_madre,
                        profesion_madre = item.profesion_madre,
                        lugar_trabajo_madre = item.lugar_trabajo_madre,
                        telefono_madre = item.telefono_madre,
                        celular_madre = item.celular_madre,
                        nombre_padre = item.nombre_padre,
                        profesion_padre = item.profesion_padre,
                        lugar_trabajo_padre = item.lugar_trabajo_padre,
                        telefono_padre = item.telefono_padre,
                        celular_padre = item.celular_padre,
                        ausencia_nombre1 = item.ausencia_nombre1,
                        ausencia_nombre2 = item.ausencia_nombre2,
                        ausencia_nombre3 = item.ausencia_nombre3,
                        parentesco1 = item.parentesco1,
                        parentesco2 = item.parentesco2,
                        parentesco3 = item.parentesco3,
                        telefono_ausencia1 = item.telefono_ausencia1,
                        telefono_ausencia2 = item.telefono_ausencia2,
                        telefono_ausencia3 = item.telefono_ausencia3,
                        estado_civil_padres = item.estado_civil_padres,
                        con_quien_vive_alumno = item.con_quien_vive_alumno,
                        observaciones = item.observaciones
                    });
                }

                responseApi.EsCorrecto = true;
                responseApi.Valor = listaAlumnoDTO;
            }
            catch (Exception ex) 
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }

        //Buscar alumno
        [HttpGet]
        [Route("Buscar/{id}")]
        public async Task<IActionResult> Buscar(int id)
        {
            var responseApi = new ResponseAPI<AlumnoDTO>();
            var AlumnoDTO = new AlumnoDTO();

            try
            {
                var dbAlumno = await _dbContext.TblAlumnos.FirstOrDefaultAsync(x => x.id == id);
                if (dbAlumno != null)
                {
                    AlumnoDTO.id = dbAlumno.id;
                    AlumnoDTO.primer_nombre = dbAlumno.primer_nombre;
                    AlumnoDTO.segundo_nombre = dbAlumno.segundo_nombre;
                    AlumnoDTO.primer_apellido = dbAlumno.primer_apellido;
                    AlumnoDTO.segundo_apellido = dbAlumno.segundo_apellido;
                    AlumnoDTO.genero = dbAlumno.genero;
                    AlumnoDTO.lugar_nacimiento = dbAlumno.lugar_nacimiento;
                    AlumnoDTO.fecha_nacimiento = dbAlumno.fecha_nacimiento;
                    AlumnoDTO.direccion = dbAlumno.direccion;
                    AlumnoDTO.telefono = dbAlumno.telefono;
                    AlumnoDTO.region = dbAlumno.region;
                    AlumnoDTO.escuela_procedencia = dbAlumno.escuela_procedencia;
                    AlumnoDTO.anio_ingreso = dbAlumno.anio_ingreso;
                    AlumnoDTO.numero_identidad = dbAlumno.numero_identidad;
                    AlumnoDTO.tiene_hermanos = dbAlumno.tiene_hermanos;
                    AlumnoDTO.numero_miembros = dbAlumno.numero_miembros;
                    AlumnoDTO.nombre_madre = dbAlumno.nombre_madre;
                    AlumnoDTO.profesion_madre = dbAlumno.profesion_madre;
                    AlumnoDTO.lugar_trabajo_madre = dbAlumno.lugar_trabajo_madre;
                    AlumnoDTO.telefono_madre = dbAlumno.telefono_madre;
                    AlumnoDTO.celular_madre = dbAlumno.celular_madre;
                    AlumnoDTO.nombre_padre = dbAlumno.nombre_padre;
                    AlumnoDTO.profesion_padre = dbAlumno.profesion_padre;
                    AlumnoDTO.lugar_trabajo_padre = dbAlumno.lugar_trabajo_padre;
                    AlumnoDTO.telefono_padre = dbAlumno.telefono_padre;
                    AlumnoDTO.celular_padre = dbAlumno.celular_padre;
                    AlumnoDTO.ausencia_nombre1 = dbAlumno.ausencia_nombre1;
                    AlumnoDTO.ausencia_nombre2 = dbAlumno.ausencia_nombre2;
                    AlumnoDTO.ausencia_nombre3 = dbAlumno.ausencia_nombre3;
                    AlumnoDTO.parentesco1 = dbAlumno.parentesco1;
                    AlumnoDTO.parentesco2 = dbAlumno.parentesco2;
                    AlumnoDTO.parentesco3 = dbAlumno.parentesco3;
                    AlumnoDTO.telefono_ausencia1 = dbAlumno.telefono_ausencia1;
                    AlumnoDTO.telefono_ausencia2 = dbAlumno.telefono_ausencia2;
                    AlumnoDTO.telefono_ausencia3 = dbAlumno.telefono_ausencia3;
                    AlumnoDTO.estado_civil_padres = dbAlumno.estado_civil_padres;
                    AlumnoDTO.con_quien_vive_alumno = dbAlumno.con_quien_vive_alumno;
                    AlumnoDTO.observaciones = dbAlumno.observaciones;

                    responseApi.EsCorrecto = true;
                    responseApi.Valor = AlumnoDTO;
                }
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "No encontrado";
                }

                
            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }

        //Guardar Alumno
        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(AlumnoDTO alumno)
        {
            var responseApi = new ResponseAPI<int>();
            
            try
            {
                var dbAlumno = new TblAlumnos
                {
                    id = alumno.id,
                    primer_nombre = alumno.primer_nombre,
                    segundo_nombre = alumno.segundo_nombre,
                    primer_apellido = alumno.primer_apellido,
                    segundo_apellido = alumno.segundo_apellido,
                    genero = alumno.genero,
                    lugar_nacimiento = alumno.lugar_nacimiento,
                    fecha_nacimiento = alumno.fecha_nacimiento,
                    direccion = alumno.direccion,
                    telefono = alumno.telefono,
                    region = alumno.region,
                    escuela_procedencia = alumno.escuela_procedencia,
                    anio_ingreso = alumno.anio_ingreso,
                    numero_identidad = alumno.numero_identidad,
                    tiene_hermanos = alumno.tiene_hermanos,
                    numero_miembros = alumno.numero_miembros,
                    nombre_madre = alumno.nombre_madre,
                    profesion_madre = alumno.profesion_madre,
                    lugar_trabajo_madre = alumno.lugar_trabajo_madre,
                    telefono_madre = alumno.telefono_madre,
                    celular_madre = alumno.celular_madre,
                    nombre_padre = alumno.nombre_padre,
                    profesion_padre = alumno.profesion_padre,
                    lugar_trabajo_padre = alumno.lugar_trabajo_padre,
                    telefono_padre = alumno.telefono_padre,
                    celular_padre = alumno.celular_padre,
                    ausencia_nombre1 = alumno.ausencia_nombre1,
                    ausencia_nombre2 = alumno.ausencia_nombre2,
                    ausencia_nombre3 = alumno.ausencia_nombre3,
                    parentesco1 = alumno.parentesco1,
                    parentesco2 = alumno.parentesco2,
                    parentesco3 = alumno.parentesco3,
                    telefono_ausencia1 = alumno.telefono_ausencia1,
                    telefono_ausencia2 = alumno.telefono_ausencia2,
                    telefono_ausencia3 = alumno.telefono_ausencia3,
                    estado_civil_padres = alumno.estado_civil_padres,
                    con_quien_vive_alumno = alumno.con_quien_vive_alumno,
                    observaciones = alumno.observaciones
                };


                _dbContext.TblAlumnos.Add(dbAlumno);
                await _dbContext.SaveChangesAsync();

                if(dbAlumno.id != 0)
                {
                    responseApi.EsCorrecto = true;
                    responseApi.Valor = dbAlumno.id;
                }
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "No guardado";
                }


            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }

        //Editar Alumno
        [HttpPut]
        [Route("Editar/{id}")]
        public async Task<IActionResult> Editar(AlumnoDTO alumno, int id)
        {
            var responseApi = new ResponseAPI<int>();

            try
            {
                var dbAlumno = await _dbContext.TblAlumnos.FirstOrDefaultAsync(e => e.id == id);

              
                if (dbAlumno != null)
                {
                    dbAlumno.id = alumno.id;
                    dbAlumno.primer_nombre = alumno.primer_nombre;
                    dbAlumno.segundo_nombre = alumno.segundo_nombre;
                    dbAlumno.primer_apellido = alumno.primer_apellido;
                    dbAlumno.segundo_apellido = alumno.segundo_apellido;
                    dbAlumno.genero = alumno.genero;
                    dbAlumno.lugar_nacimiento = alumno.lugar_nacimiento;
                    dbAlumno.fecha_nacimiento = alumno.fecha_nacimiento;
                    dbAlumno.direccion = alumno.direccion;
                    dbAlumno.telefono = alumno.telefono;
                    dbAlumno.region = alumno.region;
                    dbAlumno.escuela_procedencia = alumno.escuela_procedencia;
                    dbAlumno.anio_ingreso = alumno.anio_ingreso;
                    dbAlumno.numero_identidad = alumno.numero_identidad;
                    dbAlumno.tiene_hermanos = alumno.tiene_hermanos;
                    dbAlumno.numero_miembros = alumno.numero_miembros;
                    dbAlumno.nombre_madre = alumno.nombre_madre;
                    dbAlumno.profesion_madre = alumno.profesion_madre;
                    dbAlumno.lugar_trabajo_madre = alumno.lugar_trabajo_madre;
                    dbAlumno.telefono_madre = alumno.telefono_madre;
                    dbAlumno.celular_madre = alumno.celular_madre;
                    dbAlumno.nombre_padre = alumno.nombre_padre;
                    dbAlumno.profesion_padre = alumno.profesion_padre;
                    dbAlumno.lugar_trabajo_padre = alumno.lugar_trabajo_padre;
                    dbAlumno.telefono_padre = alumno.telefono_padre;
                    dbAlumno.celular_padre = alumno.celular_padre;
                    dbAlumno.ausencia_nombre1 = alumno.ausencia_nombre1;
                    dbAlumno.ausencia_nombre2 = alumno.ausencia_nombre2;
                    dbAlumno.ausencia_nombre3 = alumno.ausencia_nombre3;
                    dbAlumno.parentesco1 = alumno.parentesco1;
                    dbAlumno.parentesco2 = alumno.parentesco2;
                    dbAlumno.parentesco3 = alumno.parentesco3;
                    dbAlumno.telefono_ausencia1 = alumno.telefono_ausencia1;
                    dbAlumno.telefono_ausencia2 = alumno.telefono_ausencia2;
                    dbAlumno.telefono_ausencia3 = alumno.telefono_ausencia3;
                    dbAlumno.estado_civil_padres = alumno.estado_civil_padres;
                    dbAlumno.con_quien_vive_alumno = alumno.con_quien_vive_alumno;
                    dbAlumno.observaciones = alumno.observaciones;


                    _dbContext.TblAlumnos.Update(dbAlumno);
                    await _dbContext.SaveChangesAsync();

                    responseApi.EsCorrecto = true;
                    responseApi.Valor = dbAlumno.id;
                }
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "No encontrado";
                }


            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }

        //Eliminar Alumno
        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<IActionResult> Elimina(int id)
        {
            var responseApi = new ResponseAPI<int>();

            try
            {
                var dbAlumno = await _dbContext.TblAlumnos.FirstOrDefaultAsync(e => e.id == id);


                if (dbAlumno != null)
                {
                    
                    _dbContext.TblAlumnos.Remove(dbAlumno);
                    await _dbContext.SaveChangesAsync();

                    responseApi.EsCorrecto = true;
                   
                }
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "No encontrado";
                }


            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }
    }
}
