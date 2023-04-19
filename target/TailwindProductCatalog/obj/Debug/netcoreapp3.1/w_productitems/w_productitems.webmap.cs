#pragma warning disable
#line 1 "w_productitems\\w_productitems.cs"
#pragma warning disable
#line 1 "w_productitems\\w_productitems.cs"
namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_productitems
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_productitems
   {

      public override void Create()
      {
         this.p_imgproduct = CreateInnerControl_p_imgproduct_type();
         this.cb_next = CreateInnerControl_cb_next_type();
         this.cb_prev = CreateInnerControl_cb_prev_type();
         this.cb_update = CreateInnerControl_cb_update_type();
         this.dw_productitems = CreateInnerControl_dw_productitems_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.p_imgproduct, this.cb_next, this.cb_prev, this.cb_update, this.dw_productitems });
      }

      public override void Destroy()
      {
         this.p_imgproduct = null;
         this.cb_next = null;
         this.cb_prev = null;
         this.cb_update = null;
         this.dw_productitems = null;
      }

      public virtual int? OpenWindow()
      {
         short? row = 0;
         this.dw_productitems.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_productitems.Retrieve();
         if ( ((Mobilize.Web.Comparison.NotEquals(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.message<Mobilize.Web.IMessage>())).DoubleParm, 0))) == true )
         {
            row = (short?)this.dw_productitems.Find(Mobilize.Web.PlusFunctions.Plus("id = ", Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.message<Mobilize.Web.IMessage>())).DoubleParm)), 0, this.dw_productitems.RowCount());
            this.dw_productitems.ScrollToRow(row);
         }
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_productitemsInner.Ip_imgproduct_type CreateInnerControl_p_imgproduct_type()
      {
         return Mobilize.Web.Application.Create<Iw_productitemsInner.Ip_imgproduct_type>(this);
      }

      protected virtual Iw_productitemsInner.Icb_next_type CreateInnerControl_cb_next_type()
      {
         return Mobilize.Web.Application.Create<Iw_productitemsInner.Icb_next_type>(this);
      }

      protected virtual Iw_productitemsInner.Icb_prev_type CreateInnerControl_cb_prev_type()
      {
         return Mobilize.Web.Application.Create<Iw_productitemsInner.Icb_prev_type>(this);
      }

      protected virtual Iw_productitemsInner.Icb_update_type CreateInnerControl_cb_update_type()
      {
         return Mobilize.Web.Application.Create<Iw_productitemsInner.Icb_update_type>(this);
      }

      protected virtual Iw_productitemsInner.Idw_productitems_type CreateInnerControl_dw_productitems_type()
      {
         return Mobilize.Web.Application.Create<Iw_productitemsInner.Idw_productitems_type>(this);
      }

      public partial class p_imgproduct_type
         : Mobilize.Web.Picture, Iw_productitemsInner.Ip_imgproduct_type
      {

         public p_imgproduct_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productitems Parent => (w_productitems)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2711;
            this.Y = 104;
            this.Width = 1353;
            this.Height = 892;
            this.OriginalSize = true;
            this.FocusRectangle = false;
         }

      }

      public partial class cb_next_type
         : Mobilize.Web.CommandButton, Iw_productitemsInner.Icb_next_type
      {

         public cb_next_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productitems Parent => (w_productitems)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productitems.ScrollNextRow();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 800;
            this.Y = 1160;
            this.Width = 558;
            this.Height = 132;
            this.TabOrder = 30;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Next";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_prev_type
         : Mobilize.Web.CommandButton, Iw_productitemsInner.Icb_prev_type
      {

         public cb_prev_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productitems Parent => (w_productitems)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productitems.ScrollPriorPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 169;
            this.Y = 1160;
            this.Width = 558;
            this.Height = 132;
            this.TabOrder = 20;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Prev";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_update_type
         : Mobilize.Web.CommandButton, Iw_productitemsInner.Icb_update_type
      {

         public cb_update_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productitems Parent => (w_productitems)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productitems.Update();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1445;
            this.Y = 1160;
            this.Width = 558;
            this.Height = 132;
            this.TabOrder = 20;
            this.TextSize = -14;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Segoe UI";
            this.Text = "Update";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class dw_productitems_type
         : Mobilize.Web.DataManagerControl, Iw_productitemsInner.Idw_productitems_type
      {

         public dw_productitems_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productitems Parent => (w_productitems)base.Parent;

         public virtual short? RowFocusChanged(int? currentrow)
         {
            string path = "";
            string fullpath = "";
            path = "product-images\\product-list\\";
            fullpath = "";
            fullpath = Mobilize.Web.PlusFunctions.Plus(path, GetItemString(currentrow, "ImageName"));
            this.Parent.p_imgproduct.PictureName = fullpath;
            return null;
         //dw_productitems.modify("p_imgproduct.filename='" + fullpath + "'")
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 133;
            this.Y = 120;
            this.Width = 2551;
            this.Height = 968;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_productitems";
            this.Border = false;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnrowchange = new Mobilize.Web.RowFocusChangedEventHandler(RowFocusChanged);
         }

      }

   }

}
#pragma warning restore
