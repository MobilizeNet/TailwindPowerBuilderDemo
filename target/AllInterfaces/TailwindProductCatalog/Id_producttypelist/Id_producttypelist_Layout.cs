namespace tailwindproductcatalog
{

   public interface Id_producttypelist
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmText code_t { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmColumn code { get; set; }

   }

}