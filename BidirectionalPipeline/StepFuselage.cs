using System.Text;

namespace BidirectionalPipeline
{
    public class StepFuselage : IStep<StringBuilder>
    {
        public IStep<StringBuilder> NextStep { get; set; }

        public StringBuilder ToProcess(StringBuilder inputObject)
        {
            inputObject.Append("Fuselage");
            inputObject = NextStep?.ToProcess(inputObject) ?? inputObject;
            return inputObject;
        }
    }
}