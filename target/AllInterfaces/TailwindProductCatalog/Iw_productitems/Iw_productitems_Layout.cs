namespace tailwindproductcatalog
{

   public interface Iw_productitems
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_productitemsInner.Ip_imgproduct_type p_imgproduct { get; set; }

      Iw_productitemsInner.Icb_next_type cb_next { get; set; }

      Iw_productitemsInner.Icb_prev_type cb_prev { get; set; }

      Iw_productitemsInner.Icb_update_type cb_update { get; set; }

      Iw_productitemsInner.Idw_productitems_type dw_productitems { get; set; }

   }

   namespace Iw_productitemsInner
   {

      public interface Ip_imgproduct_type
         : Mobilize.Web.IPicture
      {

         void DoWmInit();

      }

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

      public interface Idw_productitems_type
         : Mobilize.Web.IDataManagerControl
      {

         short? RowFocusChanged(int? currentrow);

         void DoWmInit();

      }

   }
}