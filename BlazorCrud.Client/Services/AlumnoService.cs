using BlazorCrud.Shared;
using System.Net.Http.Json;

namespace BlazorCrud.Client.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly HttpClient _http;

        public AlumnoService(HttpClient http)
        {
            _http = http;
        }

        //Listar
        public async Task<List<AlumnoDTO>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseAPI<List<AlumnoDTO>>>("api/Alumno/ListarAlumnos");

            if (result!.EsCorrecto)
            {
                return result.Valor!;
            }
            else
            {
                throw new Exception(result.Mensaje);
            }
        }

        //Buscar alumno
        public async Task<AlumnoDTO> Buscar(int id)
        {
            var result = await _http.GetFromJsonAsync<ResponseAPI<AlumnoDTO>>($"api/Alumno/Buscar/{id}");

            if (result!.EsCorrecto)
            {
                return result.Valor!;
            }
            else
            {
                throw new Exception(result.Mensaje);
            }
        }

        //Guardar alumno
        public async Task<int> Guardar(AlumnoDTO alumno)
        {
            var result = await _http.PostAsJsonAsync("api/Alumno/Guardar", alumno);
            var response = await result.Content.ReadFromJsonAsync<ResponseAPI<int>>();

            if (response!.EsCorrecto)
            {
                return response.Valor!;
            }
            else
            {
                throw new Exception(response.Mensaje);
            }
        }


        //Editar alumno
        public async Task<int> Editar(AlumnoDTO alumno)
        {
            var result = await _http.PutAsJsonAsync($"api/Alumno/Editar/{alumno.id}", alumno);
            var response = await result.Content.ReadFromJsonAsync<ResponseAPI<int>>();

            if (response!.EsCorrecto)
            {
                return response.Valor!;
            }
            else
            {
                throw new Exception(response.Mensaje);
            }
        }

        //Eliminar alumno
        public async Task<bool> Eliminar(int id)
        {
            var result = await _http.DeleteAsync($"api/Alumno/Eliminar/{id}");
            var response = await result.Content.ReadFromJsonAsync<ResponseAPI<int>>();

            if (response!.EsCorrecto)
            {
                return response.EsCorrecto!;
            }
            else
            {
                throw new Exception(response.Mensaje);
            }
        } 

    }
}
