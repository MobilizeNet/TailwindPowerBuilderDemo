namespace tailwindproductcatalog
{

   public interface Id_productfeatures
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmText productitemid_t { get; set; }

      Mobilize.Web.DmColumn productitemid { get; set; }

      Mobilize.Web.DmText title_t { get; set; }

      Mobilize.Web.DmColumn _title { get; set; }

      Mobilize.Web.DmText description_t { get; set; }

      Mobilize.Web.DmColumn description { get; set; }

   }

}