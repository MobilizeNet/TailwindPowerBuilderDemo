#pragma warning disable
#line 1 "w_productbrands\\w_productbrands.cs"
#pragma warning disable
#line 1 "w_productbrands\\w_productbrands.cs"
namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_productbrands
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_productbrands
   {

      public override void Create()
      {
         this.cb_next = CreateInnerControl_cb_next_type();
         this.cb_prev = CreateInnerControl_cb_prev_type();
         this.cb_update = CreateInnerControl_cb_update_type();
         this.dw_productbrands = CreateInnerControl_dw_productbrands_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_next, this.cb_prev, this.cb_update, this.dw_productbrands });
      }

      public override void Destroy()
      {
         this.cb_next = null;
         this.cb_prev = null;
         this.cb_update = null;
         this.dw_productbrands = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_productbrands.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_productbrands.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_productbrandsInner.Icb_next_type CreateInnerControl_cb_next_type()
      {
         return Mobilize.Web.Application.Create<Iw_productbrandsInner.Icb_next_type>(this);
      }

      protected virtual Iw_productbrandsInner.Icb_prev_type CreateInnerControl_cb_prev_type()
      {
         return Mobilize.Web.Application.Create<Iw_productbrandsInner.Icb_prev_type>(this);
      }

      protected virtual Iw_productbrandsInner.Icb_update_type CreateInnerControl_cb_update_type()
      {
         return Mobilize.Web.Application.Create<Iw_productbrandsInner.Icb_update_type>(this);
      }

      protected virtual Iw_productbrandsInner.Idw_productbrands_type CreateInnerControl_dw_productbrands_type()
      {
         return Mobilize.Web.Application.Create<Iw_productbrandsInner.Idw_productbrands_type>(this);
      }

      public partial class cb_next_type
         : Mobilize.Web.CommandButton, Iw_productbrandsInner.Icb_next_type
      {

         public cb_next_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productbrands Parent => (w_productbrands)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productbrands.ScrollNextPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 823;
            this.Y = 588;
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
         : Mobilize.Web.CommandButton, Iw_productbrandsInner.Icb_prev_type
      {

         public cb_prev_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productbrands Parent => (w_productbrands)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productbrands.ScrollPriorPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 192;
            this.Y = 588;
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
         : Mobilize.Web.CommandButton, Iw_productbrandsInner.Icb_update_type
      {

         public cb_update_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productbrands Parent => (w_productbrands)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productbrands.Update();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1467;
            this.Y = 588;
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

      public partial class dw_productbrands_type
         : Mobilize.Web.DataManagerControl, Iw_productbrandsInner.Idw_productbrands_type
      {

         public dw_productbrands_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productbrands Parent => (w_productbrands)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 151;
            this.Y = 88;
            this.Width = 2057;
            this.Height = 468;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_productbrands";
            this.Border = false;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
