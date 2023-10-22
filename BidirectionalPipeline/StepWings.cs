using System.Text;

namespace BidirectionalPipeline
{
    public class StepWings : IStep<StringBuilder>
    {
        public IStep<StringBuilder> NextStep { get; set; }

        public StringBuilder ToProcess(StringBuilder inputObject)
        {
            inputObject.Append(", Wings");
            inputObject = NextStep?.ToProcess(inputObject) ?? inputObject;
            return inputObject;
        }
    }
}