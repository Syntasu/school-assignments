
using System.Collections.Generic;
using System.Text;

namespace ProgrammerenHuiswerk.Framework
{
    public abstract class BaseRunable
    {
        private List<string> _outputList = new List<string>();
        public List<string> Output => _outputList;

        public bool HasOuput
        {
            get
            {
                return _outputList.Count > 0;
            }
        }

        public string OutputString
        {
            get
            {

                if (!HasOuput) return string.Empty;

                StringBuilder builder = new StringBuilder();
                foreach (var line in _outputList)
                {
                    builder.Append(line);
                    builder.Append("\n");
                }

                return builder.ToString();
            }
        }

        public BaseRunable()
        {
            AssignmentManager.Register(this);
        }

        public void Flush()
        {
            _outputList.Clear();
        }

        public abstract void Execute();


    }
}
