namespace tailwindproductcatalog
{

   public partial class w_productfeatures
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productfeaturesInner.Icb_next_type cb_next { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productfeaturesInner.Icb_prev_type cb_prev { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productfeaturesInner.Icb_update_type cb_update { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productfeaturesInner.Idw_productfeatures_type dw_productfeatures { get; set; }


      public w_productfeatures(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3177;
         this.Height = 1136;
         this.TitleBar = true;
         this.Title = "Edit Product Features";
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