namespace Innergy_Exercise.Business.Handlers
{
    public interface IWarehouseHandler<in T> where T: class
    {
        void Handle(T context);
    }
}