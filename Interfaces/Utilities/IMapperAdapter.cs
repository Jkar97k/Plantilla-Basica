namespace api_basica.Interfaces.Utilities
{
    public interface IMapperAdapter
    {
        TDestination Map<TSource, TDestination>(TSource source);
        void Map<TSource, TDestination>(TSource source, TDestination destination);
        List<TDestination> MapList<TSource, TDestination>(IEnumerable<TSource> source);
    }
}