namespace StarCastGrupoDois.Application.Core
{
    public interface IService<in T>
    {
        void Salvar(T obj);
    }
}