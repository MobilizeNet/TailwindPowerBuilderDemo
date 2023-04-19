namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_producttypes
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_producttypes
   {

      public override void Create()
      {
         this.cb_next = CreateInnerControl_cb_next_type();
         this.cb_prev = CreateInnerControl_cb_prev_type();
         this.cb_update = CreateInnerControl_cb_update_type();
         this.dw_producttypes = CreateInnerControl_dw_producttypes_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_next, this.cb_prev, this.cb_update, this.dw_producttypes });
      }

      public override void Destroy()
      {
         this.cb_next = null;
         this.cb_prev = null;
         this.cb_update = null;
         this.dw_producttypes = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_producttypes.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_producttypes.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_producttypesInner.Icb_next_type CreateInnerControl_cb_next_type()
      {
         return Mobilize.Web.Application.Create<Iw_producttypesInner.Icb_next_type>(this);
      }

      protected virtual Iw_producttypesInner.Icb_prev_type CreateInnerControl_cb_prev_type()
      {
         return Mobilize.Web.Application.Create<Iw_producttypesInner.Icb_prev_type>(this);
      }

      protected virtual Iw_producttypesInner.Icb_update_type CreateInnerControl_cb_update_type()
      {
         return Mobilize.Web.Application.Create<Iw_producttypesInner.Icb_update_type>(this);
      }

      protected virtual Iw_producttypesInner.Idw_producttypes_type CreateInnerControl_dw_producttypes_type()
      {
         return Mobilize.Web.Application.Create<Iw_producttypesInner.Idw_producttypes_type>(this);
      }

      public class cb_next_type
         : Mobilize.Web.CommandButton, Iw_producttypesInner.Icb_next_type
      {

         public cb_next_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_producttypes Parent => (w_producttypes)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_producttypes.ScrollNextPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 805;
            this.Y = 624;
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

      public class cb_prev_type
         : Mobilize.Web.CommandButton, Iw_producttypesInner.Icb_prev_type
      {

         public cb_prev_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_producttypes Parent => (w_producttypes)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_producttypes.ScrollPriorPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 174;
            this.Y = 624;
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

      public class cb_update_type
         : Mobilize.Web.CommandButton, Iw_producttypesInner.Icb_update_type
      {

         public cb_update_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_producttypes Parent => (w_producttypes)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_producttypes.Update();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1449;
            this.Y = 624;
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

      public class dw_producttypes_type
         : Mobilize.Web.DataManagerControl, Iw_producttypesInner.Idw_producttypes_type
      {

         public dw_producttypes_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_producttypes Parent => (w_producttypes)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 233;
            this.Y = 116;
            this.Width = 2135;
            this.Height = 400;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_producttypes";
            this.Border = false;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}