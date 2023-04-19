namespace tailwindproductcatalog
{

   public partial class w_producttypes
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_producttypesInner.Icb_next_type cb_next { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_producttypesInner.Icb_prev_type cb_prev { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_producttypesInner.Icb_update_type cb_update { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_producttypesInner.Idw_producttypes_type dw_producttypes { get; set; }


      public w_producttypes(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2569;
         this.Height = 1052;
         this.TitleBar = true;
         this.Title = "Edit Product Types";
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