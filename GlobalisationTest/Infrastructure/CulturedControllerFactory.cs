using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace GlobalisationTest
{
    public class CulturedControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            try
            {
                string cult = requestContext.RouteData.Values["culture"] as string;
                string lang = requestContext.RouteData.Values["language"] as string;

                string culture = string.Format("{0}-{1}", lang, cult);

                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            }
            catch (CultureNotFoundException)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            }

            return base.CreateController(requestContext, controllerName);
        }

    }
}