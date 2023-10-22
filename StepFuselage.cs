using System.Text;

namespace SimplePipeline
{
    public class StepFuselage : IStep<StringBuilder>
    {
        public StringBuilder ToProcess(StringBuilder inputObject)
        {
            inputObject.Append("Fuselage");
            return inputObject;
        }
    }
}