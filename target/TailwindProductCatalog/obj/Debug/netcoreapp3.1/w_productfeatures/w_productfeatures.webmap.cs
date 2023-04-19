#pragma warning disable
#line 1 "w_productfeatures\\w_productfeatures.cs"
#pragma warning disable
#line 1 "w_productfeatures\\w_productfeatures.cs"
namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_productfeatures
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_productfeatures
   {

      public override void Create()
      {
         this.cb_next = CreateInnerControl_cb_next_type();
         this.cb_prev = CreateInnerControl_cb_prev_type();
         this.cb_update = CreateInnerControl_cb_update_type();
         this.dw_productfeatures = CreateInnerControl_dw_productfeatures_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_next, this.cb_prev, this.cb_update, this.dw_productfeatures });
      }

      public override void Destroy()
      {
         this.cb_next = null;
         this.cb_prev = null;
         this.cb_update = null;
         this.dw_productfeatures = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_productfeatures.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_productfeatures.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_productfeaturesInner.Icb_next_type CreateInnerControl_cb_next_type()
      {
         return Mobilize.Web.Application.Create<Iw_productfeaturesInner.Icb_next_type>(this);
      }

      protected virtual Iw_productfeaturesInner.Icb_prev_type CreateInnerControl_cb_prev_type()
      {
         return Mobilize.Web.Application.Create<Iw_productfeaturesInner.Icb_prev_type>(this);
      }

      protected virtual Iw_productfeaturesInner.Icb_update_type CreateInnerControl_cb_update_type()
      {
         return Mobilize.Web.Application.Create<Iw_productfeaturesInner.Icb_update_type>(this);
      }

      protected virtual Iw_productfeaturesInner.Idw_productfeatures_type CreateInnerControl_dw_productfeatures_type()
      {
         return Mobilize.Web.Application.Create<Iw_productfeaturesInner.Idw_productfeatures_type>(this);
      }

      public partial class cb_next_type
         : Mobilize.Web.CommandButton, Iw_productfeaturesInner.Icb_next_type
      {

         public cb_next_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productfeatures Parent => (w_productfeatures)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productfeatures.ScrollNextPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 855;
            this.Y = 736;
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
         : Mobilize.Web.CommandButton, Iw_productfeaturesInner.Icb_prev_type
      {

         public cb_prev_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productfeatures Parent => (w_productfeatures)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productfeatures.ScrollPriorPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 224;
            this.Y = 736;
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
         : Mobilize.Web.CommandButton, Iw_productfeaturesInner.Icb_update_type
      {

         public cb_update_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productfeatures Parent => (w_productfeatures)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_productfeatures.Update();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1499;
            this.Y = 736;
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

      public partial class dw_productfeatures_type
         : Mobilize.Web.DataManagerControl, Iw_productfeaturesInner.Idw_productfeatures_type
      {

         public dw_productfeatures_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_productfeatures Parent => (w_productfeatures)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 215;
            this.Y = 128;
            this.Width = 2757;
            this.Height = 564;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_productfeatures";
            this.Border = false;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
