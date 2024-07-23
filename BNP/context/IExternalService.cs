namespace BNP.external
{
    public interface IExternalService
    {
        IList<T> GetCurrentPrice<T>();
    }
}