namespace email_scheduler.Server.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetEmails();

        IEnumerable<T> GetAllByUserID(Guid userId);

        T GetByID(Guid Id);

        T Insert(T enitity);
        void Delete(Guid Id);
        T Update(T entity);
        void Save();
    }
}
