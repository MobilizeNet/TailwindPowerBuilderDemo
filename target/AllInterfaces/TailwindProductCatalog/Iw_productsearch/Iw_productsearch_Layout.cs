namespace tailwindproductcatalog
{

   public interface Iw_productsearch
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_productsearchInner.Idw_productsearch_type dw_productsearch { get; set; }

      Iw_productsearchInner.Ist_instructions_type st_instructions { get; set; }

      Iw_productsearchInner.Isle_keyword_type sle_keyword { get; set; }

      Iw_productsearchInner.Icb_search_type cb_search { get; set; }

   }

   namespace Iw_productsearchInner
   {

      public interface Idw_productsearch_type
         : Mobilize.Web.IDataManagerControl
      {

         short? DoubleClicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo);

         void DoWmInit();

      }

      public interface Ist_instructions_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Isle_keyword_type
         : Mobilize.Web.ISingleLineEdit
      {

         void DoWmInit();

      }

      public interface Icb_search_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}