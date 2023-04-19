namespace tailwindproductcatalog
{

   public partial class w_tags
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_tagsInner.Icb_update_type cb_update { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_tagsInner.Icb_prev_type cb_prev { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_tagsInner.Icb_next_type cb_next { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_tagsInner.Idw_tag_type dw_tag { get; set; }


      public w_tags(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2871;
         this.Height = 952;
         this.TitleBar = true;
         this.Title = "Edit Product Tags";
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