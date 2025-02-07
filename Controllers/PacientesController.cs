using api_basica.Dtos;
using api_basica.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_basica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteSevices _pacienteServices;

        public PacientesController([FromKeyedServices("pacienteskey1")]IPacienteSevices pacienteServices)
        {
            _pacienteServices = pacienteServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var data = await _pacienteServices.ObtenerTodosLosPacientesAsync();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(PacientePostDTO dto)
        {
           await _pacienteServices.Add(dto);
            //_logger.LogInformation();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(PacienteDTO dto)
        {
            await _pacienteServices.Update(dto);
            return Ok(new { Message = "ok" });

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pacienteServices.Delete(id);
            return Ok();

        }
    }
}
