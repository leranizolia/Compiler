﻿namespace Minsk.CodeAnalysis
{
    public enum SyntaxKind
    {
        //Tokens
        BadToken,
        EndOfFileToken,
        NumberToken,
        WhitespaceToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,

        //Expression Tokens
        LiteralExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}
