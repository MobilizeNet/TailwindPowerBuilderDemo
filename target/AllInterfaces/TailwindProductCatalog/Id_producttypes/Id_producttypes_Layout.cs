namespace tailwindproductcatalog
{

   public interface Id_producttypes
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmText code_t { get; set; }

      Mobilize.Web.DmColumn code { get; set; }

   }

}