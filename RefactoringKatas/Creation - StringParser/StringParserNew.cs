namespace RefactoringKatas
{
    public class StringParserNew
    {
        public Node Find()
        {
            StringBuffer textBuffer = new StringBuffer();
            const int textBegin = 0;
            const int textEnd = 20;
            var parser = new StringParserNew();

            var factory = new NodeFactory();
            return factory.CreateNode(textBuffer, textBegin, textEnd, parser.ShouldDecodeNodes());
        }

        private bool ShouldDecodeNodes()
        {
            return true;
        }
    }

    public class NodeFactory
    {
        public Node CreateNode(StringBuffer textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));

            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }
}
