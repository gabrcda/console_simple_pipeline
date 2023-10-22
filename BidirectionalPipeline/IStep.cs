namespace BidirectionalPipeline
{
    public interface IStep<T>
    {
        IStep<T> NextStep { get; set; }
        public T ToProcess(T inputObject);
    }
}