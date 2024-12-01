using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mmc.taghelpers.Common;

[HtmlTargetElement("mmc-js-bs", TagStructure = TagStructure.NormalOrSelfClosing)]
public class mmcBootstrapJsTagHelper : TagHelper
{
	public string Version { get; set; } = null!;

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = string.Empty;

		output.TagMode = TagMode.SelfClosing;

		var linkBuilder = new TagBuilder("script");

		{
			linkBuilder.TagRenderMode = TagRenderMode.Normal;
			
			linkBuilder.Attributes.Add("src", $"https://cdn.jsdelivr.net/npm/bootstrap@{Version}/dist/js/bootstrap.bundle.min.js");
			
			linkBuilder.Attributes.Add("crossorigin", "anonymous");
		}

		output.Content.AppendHtml(linkBuilder);
	}
}