using System.Web;
using System.Web.Mvc;

namespace esiv2.net.CustomStuff.HtmlHelpers
{
    public static class EventCreationHelper
    {
        private static string imagePath(string src)
        {
            return "~/Content/images/" + src;
        }

        public static IHtmlString DivButtonLink(this HtmlHelper helper, string name, string href)
        {
            // div
            TagBuilder tbDiv = new TagBuilder("div");
            tbDiv.Attributes.Add("class", "div-button");
            tbDiv.InnerHtml = name;

            // a
            TagBuilder tb = new TagBuilder("a");
            tb.Attributes.Add("href", href);
            tb.InnerHtml = tbDiv.ToString(TagRenderMode.Normal);

            return new MvcHtmlString(tb.ToString(TagRenderMode.Normal));
        }
    }
}