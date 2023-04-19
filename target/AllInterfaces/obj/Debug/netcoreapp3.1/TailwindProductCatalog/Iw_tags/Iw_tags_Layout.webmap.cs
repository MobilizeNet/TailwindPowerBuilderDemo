#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_tags\\Iw_tags_Layout.cs"
#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_tags\\Iw_tags_Layout.cs"
namespace tailwindproductcatalog
{

   public interface Iw_tags
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_tagsInner.Icb_update_type cb_update { get; set; }

      Iw_tagsInner.Icb_prev_type cb_prev { get; set; }

      Iw_tagsInner.Icb_next_type cb_next { get; set; }

      Iw_tagsInner.Idw_tag_type dw_tag { get; set; }

   }

   namespace Iw_tagsInner
   {

      public interface Icb_update_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_prev_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_next_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Idw_tag_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
