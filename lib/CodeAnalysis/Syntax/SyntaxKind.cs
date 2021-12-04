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
        EqualsToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        BangToken,
        AmpersandAmpersandToken,
        PipePipeToken,
        BangEqualsToken,
        EqualsEqualsToken,

        //Booleans
        TrueKeyword,
        FalseKeyword,
        IdentifierToken,

        //Expression Tokens
        LiteralExpression,
        BinaryExpression,
        ParenthesizedExpression,
        UnaryExpression,
        NameExpression,
        AssignmentExpression
    }
}
