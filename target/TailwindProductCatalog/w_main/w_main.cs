namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_main
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_main
   {

      public override void Create()
      {
         this.cb_search = CreateInnerControl_cb_search_type();
         this.cb_productfeatures = CreateInnerControl_cb_productfeatures_type();
         this.cb_producttypes = CreateInnerControl_cb_producttypes_type();
         this.cb_productbrands = CreateInnerControl_cb_productbrands_type();
         this.cb_productitems = CreateInnerControl_cb_productitems_type();
         this.cb_tags_window = CreateInnerControl_cb_tags_window_type();
         this.p_1 = CreateInnerControl_p_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_search, this.cb_productfeatures, this.cb_producttypes, this.cb_productbrands, this.cb_productitems, this.cb_tags_window, this.p_1 });
      }

      public override void Destroy()
      {
         this.cb_search = null;
         this.cb_productfeatures = null;
         this.cb_producttypes = null;
         this.cb_productbrands = null;
         this.cb_productitems = null;
         this.cb_tags_window = null;
         this.p_1 = null;
      }

      public virtual int? OpenWindow()
      {
         ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBMS = "SQLITEODBC";
         ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBParm = "Driver=SQLite3 ODBC Driver; Database=C:\\A1\\_work\\tailwind.db";
         ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).ServerName = "";
         ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).Connect();
         if ( Mobilize.Web.Comparison.NotEquals(((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).SQLCode, 0) == true )
         {
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBMS = "ODBC";
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).AutoCommit = false;
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBParm = "ConnectString='DSN=Tailwind;UID=sa;PWD=Pass@word'";
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).Connect();
            if ( Mobilize.Web.Comparison.NotEquals(((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.sqlca<Mobilize.Web.ITransaction>())).SQLCode, 0) == true )
            {
               Mobilize.Web.MessageBox.Show("connect", ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.sqlca<Mobilize.Web.ITransaction>())).SQLErrText, Mobilize.Web.Icon.StopSign);
               Mobilize.Web.Application.CurrentApplication.Terminate(0);
            }
         }
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_mainInner.Icb_search_type CreateInnerControl_cb_search_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_search_type>(this);
      }

      protected virtual Iw_mainInner.Icb_productfeatures_type CreateInnerControl_cb_productfeatures_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_productfeatures_type>(this);
      }

      protected virtual Iw_mainInner.Icb_producttypes_type CreateInnerControl_cb_producttypes_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_producttypes_type>(this);
      }

      protected virtual Iw_mainInner.Icb_productbrands_type CreateInnerControl_cb_productbrands_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_productbrands_type>(this);
      }

      protected virtual Iw_mainInner.Icb_productitems_type CreateInnerControl_cb_productitems_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_productitems_type>(this);
      }

      protected virtual Iw_mainInner.Icb_tags_window_type CreateInnerControl_cb_tags_window_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Icb_tags_window_type>(this);
      }

      protected virtual Iw_mainInner.Ip_1_type CreateInnerControl_p_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_mainInner.Ip_1_type>(this);
      }

      public class cb_search_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_search_type
      {

         public cb_search_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_productsearch<tailwindproductcatalog.Iw_productsearch>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_productsearch = (tailwindproductcatalog.Iw_productsearch)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_productsearch<tailwindproductcatalog.Iw_productsearch>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1253;
            this.Y = 648;
            this.Width = 754;
            this.Height = 176;
            this.TabOrder = 20;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Search Product ...";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_productfeatures_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_productfeatures_type
      {

         public cb_productfeatures_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_productfeatures<tailwindproductcatalog.Iw_productfeatures>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_productfeatures = (tailwindproductcatalog.Iw_productfeatures)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_productfeatures<tailwindproductcatalog.Iw_productfeatures>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 352;
            this.Y = 1140;
            this.Width = 814;
            this.Height = 156;
            this.TabOrder = 40;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Features";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_producttypes_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_producttypes_type
      {

         public cb_producttypes_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_producttypes<tailwindproductcatalog.Iw_producttypes>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_producttypes = (tailwindproductcatalog.Iw_producttypes)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_producttypes<tailwindproductcatalog.Iw_producttypes>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 352;
            this.Y = 976;
            this.Width = 814;
            this.Height = 156;
            this.TabOrder = 30;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Types";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_productbrands_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_productbrands_type
      {

         public cb_productbrands_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_productbrands<tailwindproductcatalog.Iw_productbrands>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_productbrands = (tailwindproductcatalog.Iw_productbrands)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_productbrands<tailwindproductcatalog.Iw_productbrands>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 352;
            this.Y = 812;
            this.Width = 814;
            this.Height = 156;
            this.TabOrder = 20;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Brands";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_productitems_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_productitems_type
      {

         public cb_productitems_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_productitems<tailwindproductcatalog.Iw_productitems>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_productitems = (tailwindproductcatalog.Iw_productitems)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_productitems<tailwindproductcatalog.Iw_productitems>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 352;
            this.Y = 648;
            this.Width = 814;
            this.Height = 156;
            this.TabOrder = 10;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Products";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_tags_window_type
         : Mobilize.Web.CommandButton, Iw_mainInner.Icb_tags_window_type
      {

         public cb_tags_window_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_tags<tailwindproductcatalog.Iw_tags>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_tags = (tailwindproductcatalog.Iw_tags)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_tags<tailwindproductcatalog.Iw_tags>()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 352;
            this.Y = 1308;
            this.Width = 814;
            this.Height = 156;
            this.TabOrder = 50;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Tags";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class p_1_type
         : Mobilize.Web.Picture, Iw_mainInner.Ip_1_type
      {

         public p_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main Parent => (w_main)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 242;
            this.Y = 132;
            this.Width = 928;
            this.Height = 272;
            this.OriginalSize = true;
            this.PictureName = "TailWindLogo.JPG";
            this.FocusRectangle = false;
         }

      }

   }

}