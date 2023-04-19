namespace tailwindproductcatalog
{

   public interface Id_productitems
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmColumn brandid { get; set; }

      Mobilize.Web.DmText brandid_t { get; set; }

      Mobilize.Web.DmText typeid_t { get; set; }

      Mobilize.Web.DmColumn typeid { get; set; }

      Mobilize.Web.DmColumn tagid { get; set; }

      Mobilize.Web.DmText tagid_t { get; set; }

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmText price_t { get; set; }

      Mobilize.Web.DmColumn imagename { get; set; }

      Mobilize.Web.DmText imagename_t { get; set; }

      Mobilize.Web.DmColumn price { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

   }

}