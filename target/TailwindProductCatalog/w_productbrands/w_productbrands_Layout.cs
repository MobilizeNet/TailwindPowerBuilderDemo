namespace tailwindproductcatalog
{

   public partial class w_productbrands
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productbrandsInner.Icb_next_type cb_next { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productbrandsInner.Icb_prev_type cb_prev { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productbrandsInner.Icb_update_type cb_update { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productbrandsInner.Idw_productbrands_type dw_productbrands { get; set; }


      public w_productbrands(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2386;
         this.Height = 932;
         this.TitleBar = true;
         this.Title = "Edit Product Brands";
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