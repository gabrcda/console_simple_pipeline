namespace BidirectionalPipeline
{
    public class BidirectionalPipeline<T>
    {
        private List<IStep<T>> pipeline = new();

        public BidirectionalPipeline<T> AddStep(IStep<T> step)
        {
            pipeline.Add(step);
            return this;
        }

        public T RunPipelineSteps(T inputObject)
        {
            for(int i = 0; i < (pipeline.Count - 1); i++)
            {
                pipeline[i].NextStep = pipeline[i+1];
            }
            return pipeline[0].ToProcess(inputObject);
        }
    }
}