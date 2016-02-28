using System;
using System.Web;
using System.Web.Mvc;

namespace esiv2.net.CustomStuff.HtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        private static string imagePath(string src)
        {
            return "~/Content/images/" + src;
        }

        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(imagePath(src)));
            tb.Attributes.Add("alt", alt);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

        public static IHtmlString Image(this HtmlHelper helper, string src, string alt, String[] properties)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(imagePath(src)));
            tb.Attributes.Add("alt", alt);

            foreach (String property in properties)
            {
                string[] splitProperty = property.Split(new char[] { ':' });
                tb.Attributes.Add(splitProperty[0], splitProperty[1]);
            }

            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}