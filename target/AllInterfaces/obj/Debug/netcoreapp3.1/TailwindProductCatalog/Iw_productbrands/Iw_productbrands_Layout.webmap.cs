#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_productbrands\\Iw_productbrands_Layout.cs"
#pragma warning disable
#line 1 "TailwindProductCatalog\\Iw_productbrands\\Iw_productbrands_Layout.cs"
namespace tailwindproductcatalog
{

   public interface Iw_productbrands
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_productbrandsInner.Icb_next_type cb_next { get; set; }

      Iw_productbrandsInner.Icb_prev_type cb_prev { get; set; }

      Iw_productbrandsInner.Icb_update_type cb_update { get; set; }

      Iw_productbrandsInner.Idw_productbrands_type dw_productbrands { get; set; }

   }

   namespace Iw_productbrandsInner
   {

      public interface Icb_next_type
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

      public interface Icb_update_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Idw_productbrands_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
