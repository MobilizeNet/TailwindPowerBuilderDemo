namespace tailwindproductcatalog
{

   public interface Id_tag
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmText value_t { get; set; }

      Mobilize.Web.DmColumn value { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

   }

}