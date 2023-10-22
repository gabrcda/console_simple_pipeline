namespace SimplePipeline
{
    public class Pipeline<T>
    {
        private List<IStep<T>> pipeline = new();

        public Pipeline<T> AddStep(IStep<T> step)
        {
            pipeline.Add(step);
            return this;
        }

        public T RunPipelineSteps(T inputObject)
        {
            foreach (var step in pipeline)
            {
                inputObject = step.ToProcess(inputObject);
            }
            return inputObject;
        }
    }
}