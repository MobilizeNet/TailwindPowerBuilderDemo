#pragma warning disable
#line 1 "Program.cs"
#pragma warning disable
#line 1 "Program.cs"

namespace productcatalogSite
{
    using System;

    [Mobilize.WebMap.Common.Attributes.Observable]
    static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            (Mobilize.Web.Application.CurrentApplication as tailwindproductcatalog.Application).DoWmInit();
			(Mobilize.Web.Application.CurrentApplication as tailwindproductcatalog.Application).Create();
            if (args != null)
            {
                (Mobilize.Web.Application.CurrentApplication as tailwindproductcatalog.Application).OpenWindow(string.Join(" ", args));
            }
            else
            {
                (Mobilize.Web.Application.CurrentApplication as tailwindproductcatalog.Application).OpenWindow(string.Empty);
            }
        }
    }
}


#pragma warning restore
