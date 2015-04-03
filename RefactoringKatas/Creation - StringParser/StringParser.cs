namespace RefactoringKatas
{
    public class StringParser
    {
        public Node Find()
        {
            StringBuffer textBuffer = new StringBuffer();
            const int textBegin = 0;
            const int textEnd = 20;
            var parser = new StringParser();
            return StringNode.CreateStringNode(textBuffer, textBegin, textEnd, parser.shouldDecodeNodes());
        }

        private bool shouldDecodeNodes()
        {
            return true;
        }
    }
}
