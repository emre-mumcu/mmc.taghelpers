using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using mmc.taghelpers.Types;

namespace mmc.taghelpers.Common;

[HtmlTargetElement("mmc-css-bs", TagStructure = TagStructure.NormalOrSelfClosing)]
public class mmcBootstrapCss : TagHelper
{
	public string Version { get; set; } = null!;

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		var linkBuilder = new TagBuilder("link");

		{
			linkBuilder.TagRenderMode = TagRenderMode.SelfClosing;

			linkBuilder.Attributes.Add("id", "theme");
			linkBuilder.Attributes.Add("rel", "stylesheet");
			linkBuilder.Attributes.Add("href", $"https://cdn.jsdelivr.net/npm/bootstrap@{Version}/dist/css/bootstrap.min.css");
			linkBuilder.Attributes.Add("crossorigin", "anonymous");
		}

		output.Content.AppendHtml(linkBuilder);
	}
}

[HtmlTargetElement("mmc-css-material-symbols", TagStructure = TagStructure.WithoutEndTag)]
public class mmcMaterialSymbolsStylesTagHelper : TagHelper
{
	public MaterialSymbol SymbolStyle { get; set; } = MaterialSymbol.Rounded;

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		output.Content.AppendHtml(@$"<link href=""https://fonts.googleapis.com/css2?family=Material+Symbols+{SymbolStyle}"" rel=""stylesheet"" />");		
	}
}

[HtmlTargetElement("mmc-css-material-symbols-all", TagStructure = TagStructure.WithoutEndTag)]
public class mmcMaterialSymbolsAllStylesTagHelper : TagHelper
{
	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		foreach (MaterialSymbol item in Enum.GetValues(typeof(MaterialSymbol)))
		{
			output.Content.AppendHtml(@$"<link href=""https://fonts.googleapis.com/css2?family=Material+Symbols+{item}"" rel=""stylesheet"" />");
		}		
	}
}

[HtmlTargetElement("mmc-css-material-icons", TagStructure = TagStructure.WithoutEndTag)]
public class mmcMaterialIconsStylesTagHelper : TagHelper
{
	public MaterialIcon IconStyle { get; set; } = MaterialIcon.Round;

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		string styleName = $"+{IconStyle.ToString()}";

		if(IconStyle == MaterialIcon.Filled) styleName = string.Empty;

		if(IconStyle == MaterialIcon.TwoTone) styleName = $"+Two+Tone";

		output.Content.AppendHtml(@$"<link href=""https://fonts.googleapis.com/css2?family=Material+Icons{styleName}"" rel=""stylesheet"" />");
	}
}

[HtmlTargetElement("mmc-css-material-icons-all", TagStructure = TagStructure.WithoutEndTag)]
public class mmcMaterialIconsAllStylesTagHelper : TagHelper
{
	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		foreach (MaterialIcon item in Enum.GetValues(typeof(MaterialIcon)))
		{
			string styleName = $"+{item.ToString()}";

			if (item == MaterialIcon.Filled) styleName = string.Empty;

			if (item == MaterialIcon.TwoTone) styleName = $"+Two+Tone";

			output.Content.AppendHtml(@$"<link href=""https://fonts.googleapis.com/css2?family=Material+Icons{styleName}"" rel=""stylesheet"" />");
		}
	}
}