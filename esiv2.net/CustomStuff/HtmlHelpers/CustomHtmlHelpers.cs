using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace esiv2.net.CustomStuff.HtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute("~/Content/Images/" + src));
            tb.Attributes.Add("alt", alt); // TODO - Fix picture Scaling
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

        public static IHtmlString Image(this HtmlHelper helper, string src, string alt, string attribute, string atrValue )
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute("~/Content/Images/" + src));
            tb.Attributes.Add("alt", alt);
            tb.Attributes.Add(attribute, atrValue);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}