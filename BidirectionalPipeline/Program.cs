using System.Text;

namespace BidirectionalPipeline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var AirplaneAssembly = new BidirectionalPipeline<StringBuilder>();
            AirplaneAssembly.AddStep(new StepFuselage());
            AirplaneAssembly.AddStep(new StepWings());

            for(int i = 1; i <= 5; i++)
            {
                var airplanes = AirplaneAssembly.RunPipelineSteps(new StringBuilder());
                Console.WriteLine($"Airplane{i}: {airplanes}");
            }
        }
    }
}