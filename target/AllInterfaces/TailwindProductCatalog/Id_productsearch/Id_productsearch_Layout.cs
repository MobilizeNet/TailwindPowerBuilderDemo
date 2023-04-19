namespace tailwindproductcatalog
{

   public interface Id_productsearch
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText productfeatures_title_t { get; set; }

      Mobilize.Web.DmText productitems_name_t { get; set; }

      Mobilize.Web.DmText productitems_price_t { get; set; }

      Mobilize.Web.DmText productitems_imagename_t { get; set; }

      Mobilize.Web.DmText producttypes_code_t { get; set; }

      Mobilize.Web.DmText productbrands_brand_t { get; set; }

      Mobilize.Web.DmText producttypes_type_t { get; set; }

      Mobilize.Web.DmText tags_tag_t { get; set; }

      Mobilize.Web.DmColumn productfeatures_title { get; set; }

      Mobilize.Web.DmColumn productitems_name { get; set; }

      Mobilize.Web.DmColumn productitems_price { get; set; }

      Mobilize.Web.DmColumn productitems_imagename { get; set; }

      Mobilize.Web.DmColumn producttypes_code { get; set; }

      Mobilize.Web.DmColumn productbrands_brand { get; set; }

      Mobilize.Web.DmColumn producttypes_type { get; set; }

      Mobilize.Web.DmColumn tags_tag { get; set; }

      Mobilize.Web.DmColumn productitems_id { get; set; }

      Mobilize.Web.DmText productitems_id_t { get; set; }

   }

}