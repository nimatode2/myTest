namespace MyTestProject
{
    /// <summary>
    /// subject interface for model
    /// </summary>
    public interface IModelSubject
    {
        IModelObserver RegisterObserver(IModelObserver o);
        IModelObserver RemoveObserver(IModelObserver o);
        void NotifyObservers();
    }

    /// <summary>
    /// observer interface for model observers
    /// </summary>
    public interface IModelObserver
    {
        void UpdateData(object sender);
    }

    public interface IControllerStrategy
    {

    }
}