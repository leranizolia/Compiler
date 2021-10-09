using System;
using System.Collections.Generic;
using System.Text;

namespace mc
{
    public class NumberExpressionSyntax : ExpressionSyntax
    {
        public NumberExpressionSyntax(SyntaxToken numberToken)
        {
            NumberToken = numberToken;
        }

        public SyntaxToken NumberToken { get; }
        public override SyntaxKind Kind => SyntaxKind.NumberExpression;
    }
}
