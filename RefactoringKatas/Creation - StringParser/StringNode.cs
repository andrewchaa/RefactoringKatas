namespace RefactoringKatas
{
    public class StringNode : Node
    {
        public StringNode(StringBuffer textBuffer, int textBegin, int textEnd)
        {
            
        }

        public static Node CreateStringNode(StringBuffer textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            
            return new StringNode(textBuffer, textBegin, textEnd);

        }
    }
}