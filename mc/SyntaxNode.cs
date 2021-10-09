using System;
using System.Collections.Generic;
using System.Text;

namespace mc
{
    public abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind { get; }
    }
}
