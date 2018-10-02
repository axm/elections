namespace Spartan.Persons.Services.Events
{
    public interface IEventsDispatcher<T> where T: class
    {
        void Dispatch(T @event);
    }
}
