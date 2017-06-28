using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1
{
    public class TestTagHelper : TagHelper
    {
        public string Value { get; set; }

        public IDictionary<string, ModelExpression> Dict { get; set; } = new Dictionary<string, ModelExpression>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();
            output.Content.SetContent($"Processed value: {Value} and {Dict.Count}");
        }
    }
}
