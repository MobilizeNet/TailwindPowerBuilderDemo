namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_productsearch
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_productsearch
   {

      public override void Create()
      {
         this.dw_productsearch = CreateInnerControl_dw_productsearch_type();
         this.st_instructions = CreateInnerControl_st_instructions_type();
         this.sle_keyword = CreateInnerControl_sle_keyword_type();
         this.cb_search = CreateInnerControl_cb_search_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_productsearch, this.st_instructions, this.sle_keyword, this.cb_search });
      }

      public override void Destroy()
      {
         this.dw_productsearch = null;
         this.st_instructions = null;
         this.sle_keyword = null;
         this.cb_search = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_productsearch.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.sqlca<Mobilize.Web.ITransaction>()));
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_productsearchInner.Idw_productsearch_type CreateInnerControl_dw_productsearch_type()
      {
         return Mobilize.Web.Application.Create<Iw_productsearchInner.Idw_productsearch_type>(this);
      }

      protected virtual Iw_productsearchInner.Ist_instructions_type CreateInnerControl_st_instructions_type()
      {
         return Mobilize.Web.Application.Create<Iw_productsearchInner.Ist_instructions_type>(this);
      }

      protected virtual Iw_productsearchInner.Isle_keyword_type CreateInnerControl_sle_keyword_type()
      {
         return Mobilize.Web.Application.Create<Iw_productsearchInner.Isle_keyword_type>(this);
      }

      protected virtual Iw_productsearchInner.Icb_search_type CreateInnerControl_cb_search_type()
      {
         return Mobilize.Web.Application.Create<Iw_productsearchInner.Icb_search_type>(this);
      }

      public class dw_productsearch_type
         : Mobilize.Web.DataManagerControl, Iw_productsearchInner.Idw_productsearch_type
      {

         public dw_productsearch_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productsearch Parent => (w_productsearch)base.Parent;

         public virtual short? DoubleClicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo)
         {
            int? _id = 0;
            _id = Mobilize.Web.TypeConversion.Long(this.Parent.dw_productsearch.GetItemNumber(row, "productitems_id"));
            Mobilize.Web.BuiltInExtensions.OpenWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_productitems<tailwindproductcatalog.Iw_productitems>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_productitems = (tailwindproductcatalog.Iw_productitems)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_productitems<tailwindproductcatalog.Iw_productitems>()), _id);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 114;
            this.Y = 764;
            this.Width = 5655;
            this.Height = 1356;
            this.TabOrder = 20;
            this.Title = "none";
            this.DataObject = "d_productsearch";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnlbuttondblclk = new Mobilize.Web.DataManagerDoubleClickedEventHandler(DoubleClicked);
         }

      }

      public class st_instructions_type
         : Mobilize.Web.StaticText, Iw_productsearchInner.Ist_instructions_type
      {

         public st_instructions_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productsearch Parent => (w_productsearch)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 201;
            this.Y = 160;
            this.Width = 2848;
            this.Height = 132;
            this.TextSize = -12;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.TextColor = 33554432;
            this.BackColor = 16777215;
            this.Text = "Please type a keyword to search for matching products and press the Search button";
            this.FocusRectangle = false;
         }

      }

      public class sle_keyword_type
         : Mobilize.Web.SingleLineEdit, Iw_productsearchInner.Isle_keyword_type
      {

         public sle_keyword_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productsearch Parent => (w_productsearch)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 197;
            this.Y = 308;
            this.Width = 1591;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -12;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class cb_search_type
         : Mobilize.Web.CommandButton, Iw_productsearchInner.Icb_search_type
      {

         public cb_search_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productsearch Parent => (w_productsearch)base.Parent;

         public virtual int? Clicked()
         {
            string query = "";
            query = Mobilize.Web.PlusFunctions.Plus(this.Parent.sle_keyword.Text, "%");
            this.Parent.dw_productsearch.Retrieve(query);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 192;
            this.Y = 504;
            this.Width = 832;
            this.Height = 168;
            this.TabOrder = 10;
            this.TextSize = -12;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Search";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}