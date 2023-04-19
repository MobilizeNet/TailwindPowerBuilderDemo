#pragma warning disable
#line 1 "w_tags\\w_tags.cs"
#pragma warning disable
#line 1 "w_tags\\w_tags.cs"
namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_tags
      : Mobilize.Web.Window, tailwindproductcatalog.Iw_tags
   {

      public override void Create()
      {
         this.cb_update = CreateInnerControl_cb_update_type();
         this.cb_prev = CreateInnerControl_cb_prev_type();
         this.cb_next = CreateInnerControl_cb_next_type();
         this.dw_tag = CreateInnerControl_dw_tag_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_update, this.cb_prev, this.cb_next, this.dw_tag });
      }

      public override void Destroy()
      {
         this.cb_update = null;
         this.cb_prev = null;
         this.cb_next = null;
         this.dw_tag = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_tag.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_tag.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_tagsInner.Icb_update_type CreateInnerControl_cb_update_type()
      {
         return Mobilize.Web.Application.Create<Iw_tagsInner.Icb_update_type>(this);
      }

      protected virtual Iw_tagsInner.Icb_prev_type CreateInnerControl_cb_prev_type()
      {
         return Mobilize.Web.Application.Create<Iw_tagsInner.Icb_prev_type>(this);
      }

      protected virtual Iw_tagsInner.Icb_next_type CreateInnerControl_cb_next_type()
      {
         return Mobilize.Web.Application.Create<Iw_tagsInner.Icb_next_type>(this);
      }

      protected virtual Iw_tagsInner.Idw_tag_type CreateInnerControl_dw_tag_type()
      {
         return Mobilize.Web.Application.Create<Iw_tagsInner.Idw_tag_type>(this);
      }

      public partial class cb_update_type
         : Mobilize.Web.CommandButton, Iw_tagsInner.Icb_update_type
      {

         public cb_update_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_tags Parent => (w_tags)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_tag.Update();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1467;
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
            this.Text = "Update";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_prev_type
         : Mobilize.Web.CommandButton, Iw_tagsInner.Icb_prev_type
      {

         public cb_prev_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_tags Parent => (w_tags)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_tag.ScrollPriorPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 192;
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
            this.Text = "Prev";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_next_type
         : Mobilize.Web.CommandButton, Iw_tagsInner.Icb_next_type
      {

         public cb_next_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_tags Parent => (w_tags)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_tag.ScrollNextPage();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 823;
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
            this.Text = "Next";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class dw_tag_type
         : Mobilize.Web.DataManagerControl, Iw_tagsInner.Idw_tag_type
      {

         public dw_tag_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_tags Parent => (w_tags)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 187;
            this.Y = 168;
            this.Width = 2514;
            this.Height = 340;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_tag";
            this.HScrollBar = true;
            this.Border = false;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
