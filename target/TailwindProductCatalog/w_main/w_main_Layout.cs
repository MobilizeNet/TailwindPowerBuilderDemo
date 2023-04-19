namespace tailwindproductcatalog
{

   public partial class w_main
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_search_type cb_search { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_productfeatures_type cb_productfeatures { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_producttypes_type cb_producttypes { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_productbrands_type cb_productbrands { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_productitems_type cb_productitems { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Icb_tags_window_type cb_tags_window { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_mainInner.Ip_1_type p_1 { get; set; }


      public w_main(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2217;
         this.Height = 1832;
         this.TitleBar = true;
         this.Title = "TailWind Products Catalog";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 16777215;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}