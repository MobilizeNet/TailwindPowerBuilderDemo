namespace tailwindproductcatalog
{

   public interface Iw_productfeatures
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_productfeaturesInner.Icb_next_type cb_next { get; set; }

      Iw_productfeaturesInner.Icb_prev_type cb_prev { get; set; }

      Iw_productfeaturesInner.Icb_update_type cb_update { get; set; }

      Iw_productfeaturesInner.Idw_productfeatures_type dw_productfeatures { get; set; }

   }

   namespace Iw_productfeaturesInner
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

      public interface Idw_productfeatures_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}