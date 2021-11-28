using Minsk.CodeAnalysis.Syntax;
using System.Collections.Generic;
using Xunit;

namespace Minsk.Tests.CodeAnalysis.Syntax
{
    public class LexerTest
    {
        [Theory]
        [MemberData(nameof(GetTokensData))]
        public void Test1(SyntaxKind kind, string text)
        {
            var tokens = SyntaxTree.ParseTokens(text);

            var token = Assert.Single(tokens);
            Assert.Equal(kind, token.Kind);
            Assert.Equal(text, token.Text);
        }

        public static IEnumerable<object[]> GetTokensData()
        {
            foreach (var (kind, text) in GetTokens())
            {
                yield return new object[] { kind, text };
            }
        }

        private static IEnumerable<(SyntaxKind kind, string text)> GetTokens()
        {
            return new[] { 
                (SyntaxKind.IdentifierToken, "a"),
                (SyntaxKind.IdentifierToken, "abc")
            };

        }
    }

    //Tokens
    //BadToken,
    //EndOfFileToken,
    //NumberToken,
    //WhitespaceToken,
    //PlusToken,
    //MinusToken,
    //StarToken,
    //SlashToken,
    //EqualsToken,
    //OpenParenthesisToken,
    //CloseParenthesisToken,
    //BangToken,
    //AmpersandAmpersandToken,
    //PipePipeToken,

    //Booleans
    //TrueKeyword,
    //FalseKeyword,
    //IdentifierToken,
}
