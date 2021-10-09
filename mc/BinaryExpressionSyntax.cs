using System;
using System.Collections.Generic;
using System.Text;

namespace mc
{
    class BinaryExpressionSyntax : ExpressionSyntax
    {
        public BinaryExpressionSyntax(ExpressionSyntax left, SyntaxNode operatorToken, ExpressionSyntax right)
        {
            Left = left;
            OperatorToken = operatorToken;
            Right = right;
        }
        public override SyntaxKind Kind => SyntaxKind.BinaryExpression;

        public ExpressionSyntax Left { get; }
        public ExpressionSyntax Right { get; }
        public SyntaxNode OperatorToken { get; }
    }
}
