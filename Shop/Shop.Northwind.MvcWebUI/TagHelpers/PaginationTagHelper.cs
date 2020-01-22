using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Shop.Northwind.MvcWebUI.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PaginationTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination pagination-md justify-content-center'>");
            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='page-item {0}'>", i == CurrentPage ? "active" : "");
                stringBuilder.AppendFormat("<a href='/Home/Index?page={0}&pageSize={1}&category={2}' class='page-link'>{3}</a>", i,
                    PageSize, CurrentCategory, i);
                stringBuilder.AppendFormat("</li>");
            }

            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
