using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mmc.taghelpers.Material;

[HtmlTargetElement("mso", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialSymbolsOutlinedTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-symbols-outlined", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("msr", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialSymbolsRoundedTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-symbols-rounded", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("mss", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialSymbolsSharpTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-symbols-sharp", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}