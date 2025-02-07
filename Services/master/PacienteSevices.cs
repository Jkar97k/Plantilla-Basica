using api_basica.Dtos;
using api_basica.Interfaces.Repository;
using api_basica.Interfaces.Services;
using api_basica.Interfaces.Utilities;
using api_basica.Repository.Models;

namespace api_basica.Services.master
{
    public class PacienteSevices : IPacienteSevices
    {
        private readonly IPacienteRepository _repository;
        private readonly IMapperAdapter _mapper;

        public PacienteSevices(IPacienteRepository repository, IMapperAdapter mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PacienteDTO>> ObtenerTodosLosPacientesAsync()
        {
            var data = await _repository.Get();

            var mapeo = _mapper.MapList< Paciente, PacienteDTO> (data);

            return mapeo;
        }

        public async Task Add(PacientePostDTO dto)
        {
            var data = await _repository.GetOne(x => x.Nombre == dto.Nombre);

            if (data != null)
            {
                return;
            }

            var entity = _mapper.Map<PacientePostDTO, Paciente>(dto);
            await _repository.Add(entity);
            await _repository.SaveChanges();
        }

        public async Task Update(PacienteDTO dto)
        {
            var data = await _repository.GetOne(x => x.IdPaciente == dto.IdPaciente);
            if (data == null)
            {
                return;
            }
            _mapper.Map(dto, data);

             _repository.Update(data);

            await _repository.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var data = await _repository.GetOne(x => x.IdPaciente == id);
            if (data == null)
            {
                return;
            }
            _repository.DeleteAsync(data);
            await _repository.SaveChanges();
        }
    }
}
