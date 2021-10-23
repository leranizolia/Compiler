using System;
using System.Collections.Generic;
using System.Text;

namespace Minsk.CodeAnalysis.Binding
{
    internal abstract class BoundNode
    {
        public abstract BoundNodeKind Kind { get; }
    }
}
