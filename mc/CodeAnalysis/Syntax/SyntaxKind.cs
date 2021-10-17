namespace Minsk.CodeAnalysis.Syntax
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
        BangToken,
        AmpersandAmpersandToken,
        PipePipeToken,

        //Booleans
        TrueKeyword,
        FalseKeyword,
        IdentifierToken,

        //Expression Tokens
        LiteralExpression,
        BinaryExpression,
        ParenthesizedExpression,
        UnaryExpression,
        EqualsEqualsToken,
        BangEqualsToken
    }
}
