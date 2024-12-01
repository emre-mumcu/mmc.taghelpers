using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using mmc.taghelpers.Types;

namespace mmc.taghelpers.Common;

[HtmlTargetElement("mmc-code", TagStructure = TagStructure.NormalOrSelfClosing)]
public class mmcCodeTagHelper : TagHelper
{
	public Language Lang { get; set; } = Language.xml;
	public bool WrapInPreTag { get; set; } = true;

	public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
	{
		string lang = Lang.ToString().TrimStart('_').Replace("_", "-");

		output.TagName = string.Empty;

		if(WrapInPreTag) output.PreElement.AppendHtml("<pre>");

		output.PreElement.AppendHtml(@$"<code class=""language-{lang}"">");
		
		output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent().Trim());
		
		output.PostElement.AppendHtml("</code>");

		if (WrapInPreTag) output.PostElement.AppendHtml("</pre>");
	}
}