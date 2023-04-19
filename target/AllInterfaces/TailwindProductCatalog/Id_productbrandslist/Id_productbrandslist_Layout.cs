namespace tailwindproductcatalog
{

   public interface Id_productbrandslist
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

   }

}