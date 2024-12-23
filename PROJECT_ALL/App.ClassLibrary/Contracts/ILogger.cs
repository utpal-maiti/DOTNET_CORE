namespace App_ClassLibrary.Contracts
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
