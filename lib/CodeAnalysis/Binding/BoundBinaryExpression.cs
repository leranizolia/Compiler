﻿using System;

namespace Minsk.CodeAnalysis.Binding
{
    internal sealed class BoundBinaryExpression : BoundExpression
    {
        public BoundBinaryExpression(BoundExpression left, BoundBinaryOperator op, BoundExpression right)
        {
            Left = left;
            Op = op;
            Right = right;
        }
        public override Type Type => Op.Type;

        public override BoundNodeKind Kind => BoundNodeKind.BinaryExpression;

        public BoundExpression Left { get; }
        public BoundBinaryOperator Op { get; }
        public BoundExpression Right { get; }
        public BoundExpression Operand { get; }
    }
}
