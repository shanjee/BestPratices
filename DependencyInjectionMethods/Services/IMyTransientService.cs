namespace DependencyInjectionMethods.Services
{
    public interface IMyTransientService:IMyService
    {
    }

    public interface IMyScopedService : IMyService
    {
    }

    public interface IMySingletonService : IMyService
    {
    }

}
