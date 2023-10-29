// TODO: TERMINAR ESSE DO BOB
namespace Strings
{
    static class Bob
    {
        public static string Response(string statement)
        {
            if (statement.EndsWith('?'))
            {
                return "Sure.";
            }
            else if (statement.EndsWith('!') || statement.All(char.IsUpper))
            {
                return "Whoa, chill out!";
            }
            else if (statement.EndsWith('?') && statement.All(char.IsUpper))
            {
                return "Calm down, I know what I'm doing!";
            }
            else if (statement.All(char.IsWhiteSpace) || statement == "")
            {
                return "Fine. Be that way!";
            }
            else
            {
                return "Whatever.";
            }
        }
    }
}