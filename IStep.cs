namespace SimplePipeline
{
    public interface IStep<T>
    {
        public T ToProcess(T inputObject);
    }
}