namespace App_ClassLibrary.Contracts
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
