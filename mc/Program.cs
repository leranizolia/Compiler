using System;

namespace mc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> ");
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
                return;

            var lexer = new Lexer(line);
            while (true)
            {
                var token = lexer.NextToken();
                if (token.Kind == SyntaxKind.EndOfFileToken)
                    break;

                Console.Write($"{token.Kind}: '{token.Text}'");
                if (token.Value != null)
                    Console.Write($" {token.Value}");

                Console.WriteLine();
            }
        }
    }
}
