using api_basica.Interfaces.Utilities;
using AutoMapper;

namespace api_basica.Utilities.AutoMapper
{
    public class MapperAdapter : IMapperAdapter
    {
        private readonly IMapper _mapper;

        public MapperAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }


        // Método genérico para mapear de un tipo a otro
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }

        // Método para mapear listas
        public List<TDestination> MapList<TSource, TDestination>(IEnumerable<TSource> source)
        {
            return _mapper.Map<List<TDestination>>(source);
        }

        public void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            if (source == null || destination == null)
            {
                throw new ArgumentNullException("Source or destination cannot be null");
            }

            _mapper.Map(source, destination);
        }


    }
}
