﻿namespace Selectorlyzer.Qulaly.Matcher.Selectors.Properties
{
    public class PropertyGreaterThanEqualMatchSelector : PropertyCountSelector
    {
        public PropertyGreaterThanEqualMatchSelector(string propertyName, int value)
            : base(propertyName, value)
        {
        }

        public override SelectorMatcher GetMatcher()
        {
            return (in SelectorMatcherContext ctx) =>
            {
                var value = GetPropertyNumberValue(ctx);
                return value != null && value >= Value;
            };
        }

        public override string ToSelectorString()
        {
            return $"[{PropertyName}>={Value}]";
        }
    }
}
