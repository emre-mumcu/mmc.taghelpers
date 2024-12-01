using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mmc.taghelpers.Material;

[HtmlTargetElement("mif", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialIconsFilledTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-icons", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("mio", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialIconsOutlinedTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-icons-outlined", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("mir", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialIconsRoundedTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-icons-round", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("mis", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialIconsSharpTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-icons-sharp", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}

[HtmlTargetElement("mit", TagStructure = TagStructure.NormalOrSelfClosing)]
public class MaterialIconsTwoToneTagHelper : TagHelper
{
	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "span";

		output.TagMode = TagMode.StartTagAndEndTag;

		output.AddClass("material-icons-two-tone", HtmlEncoder.Default);

		output.Content.AppendHtml((await output.GetChildContentAsync()).GetContent().Trim());
	}
}