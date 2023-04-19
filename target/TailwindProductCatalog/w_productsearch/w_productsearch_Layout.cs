namespace tailwindproductcatalog
{

   public partial class w_productsearch
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productsearchInner.Idw_productsearch_type dw_productsearch { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productsearchInner.Ist_instructions_type st_instructions { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productsearchInner.Isle_keyword_type sle_keyword { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_productsearchInner.Icb_search_type cb_search { get; set; }


      public w_productsearch(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 5874;
         this.Height = 2388;
         this.TitleBar = true;
         this.Title = "Product Search";
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