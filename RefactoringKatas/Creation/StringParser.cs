using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringKatas.Creation
{
    public class StringParser
    {
        public Node find()
        {
            StringBuffer textBuffer = new StringBuffer();
            int textBegin = 0;
            int textEnd = 10;
            var parser = new StringParser();
            return Node.createStringNode(textBuffer, textBegin, textEnd, parser.shouldDecodeNodes());
        }

        private bool shouldDecodeNodes()
        {
            
        }
    }

    public class StringNode : Node
    {
        public StringNode(StringBuffer textBuffer, int textBegin, int textEnd)
        {
            
        }

    }

    public class DecodingStringNode : Node
    {
        public DecodingStringNode(StringNode stringNode)
        {
            
        }
    }

    public class Node
    {
        public static Node createStringNode(StringBuffer textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));

            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }

    public class StringBuffer
    {
    }
}
