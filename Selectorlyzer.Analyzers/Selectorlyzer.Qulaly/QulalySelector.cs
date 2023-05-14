using Selectorlyzer.Qulaly.Matcher;
using Selectorlyzer.Qulaly.Matcher.Selectors;
using Selectorlyzer.Qulaly.Syntax;

namespace Selectorlyzer.Qulaly
{
    public class QulalySelector
    {
        public SelectorMatcher Matcher { get; }
        public Selector Selector { get; }

        public QulalySelector(SelectorMatcher matcher, Selector selector)
        {
            Matcher = matcher;
            Selector = selector;
        }

        public static QulalySelector Parse(string selector)
        {
            var syntaxParser = new SelectorSyntaxParser();
            var root = syntaxParser.GetProduction(selector);
            var selectorElement = (Selector)syntaxParser.Visit(root);

            return new QulalySelector(selectorElement.GetMatcher(), selectorElement);
        }
    }
}
