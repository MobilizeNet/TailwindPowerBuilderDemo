#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_main\\Iw_main_Layout.cs"
#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_main\\Iw_main_Layout.cs"
namespace tailwindproductcatalog
{

   public interface Iw_main
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_mainInner.Icb_search_type cb_search { get; set; }

      Iw_mainInner.Icb_productfeatures_type cb_productfeatures { get; set; }

      Iw_mainInner.Icb_producttypes_type cb_producttypes { get; set; }

      Iw_mainInner.Icb_productbrands_type cb_productbrands { get; set; }

      Iw_mainInner.Icb_productitems_type cb_productitems { get; set; }

      Iw_mainInner.Icb_tags_window_type cb_tags_window { get; set; }

      Iw_mainInner.Ip_1_type p_1 { get; set; }

   }

   namespace Iw_mainInner
   {

      public interface Icb_search_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_productfeatures_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_producttypes_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_productbrands_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_productitems_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_tags_window_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Ip_1_type
         : Mobilize.Web.IPicture
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
