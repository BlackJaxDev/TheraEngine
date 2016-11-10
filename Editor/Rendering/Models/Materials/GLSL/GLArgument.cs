using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CustomEngine.Rendering.Models.Materials
{
    public class GLArgument<T> : BaseGLArgument where T : GLVar
    {
        public GLArgument(string name) : base(name) { }

        protected GLOutput<T> _connectedTo = null;
        protected GLOutput<T> ConnectedTo
        {
            get { return _connectedTo; }
            set
            {
                if (CanConnectTo(value))
                    _connectedTo = value;
            }
        }
        public override Type[] GetArgType()
        {
            return new Type[] { typeof(T) };
        }
    }
}
