namespace tailwindproductcatalog
{

   public partial class w_productitems
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productitemsInner.Ip_imgproduct_type p_imgproduct { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productitemsInner.Icb_next_type cb_next { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productitemsInner.Icb_prev_type cb_prev { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productitemsInner.Icb_update_type cb_update { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productitemsInner.Idw_productitems_type dw_productitems { get; set; }


      public w_productitems(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4105;
         this.Height = 1536;
         this.TitleBar = true;
         this.Title = "Edit Products";
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