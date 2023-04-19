namespace tailwindproductcatalog
{

   public interface Iw_producttypes
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_producttypesInner.Icb_next_type cb_next { get; set; }

      Iw_producttypesInner.Icb_prev_type cb_prev { get; set; }

      Iw_producttypesInner.Icb_update_type cb_update { get; set; }

      Iw_producttypesInner.Idw_producttypes_type dw_producttypes { get; set; }

   }

   namespace Iw_producttypesInner
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

      public interface Idw_producttypes_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}