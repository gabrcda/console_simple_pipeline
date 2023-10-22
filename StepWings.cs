using System.Text;

namespace SimplePipeline
{
    public class StepWings : IStep<StringBuilder>
    {
        public StringBuilder ToProcess(StringBuilder inputObject)
        {
            inputObject.Append(", Wings");
            return inputObject;
        }
    }
}