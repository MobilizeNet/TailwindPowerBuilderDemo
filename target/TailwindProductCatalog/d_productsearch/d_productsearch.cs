namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_productsearch
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productfeatures_title_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productitems_name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productitems_price_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productitems_imagename_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText producttypes_code_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productbrands_brand_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText producttypes_type_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tags_tag_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productfeatures_title { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productitems_name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productitems_price { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productitems_imagename { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn producttypes_code { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productbrands_brand { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn producttypes_type { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tags_tag { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn productitems_id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText productitems_id_t { get; set; }


      public d_productsearch()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("0");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("1");
         this.PrintSpecification.PrinterName = "";
         this.PrintSpecification.DocumentName = "";
         this.PrintSpecification.Orientation = Mobilize.Web.CaseExtensions.String("0");
         this.PrintSpecification.Margin.Left = 110;
         this.PrintSpecification.Margin.Right = 110;
         this.PrintSpecification.Margin.Top = 96;
         this.PrintSpecification.Margin.Bottom = 96;
         this.PrintSpecification.Paper.Source = 0;
         this.PrintSpecification.Paper.Size = 0;
         this.PrintSpecification.CanUseDefaultPrinter = true;
         this.PrintSpecification.Prompt = false;
         this.PrintSpecification.Buttons = false;
         this.PrintSpecification.ClipText = false;
         this.PrintSpecification.OverridePrintJob = false;
         this.PrintSpecification.Collate = true;
         this.Header.Height = 144;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 92;
         this.Detail.Color = "536870912";
         var productitems_id_db1 = new Mobilize.Web.DB.Column();
         productitems_id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         productitems_id_db1.UpdateWhereClause = true;
         productitems_id_db1.Name = Mobilize.Web.CaseExtensions.String("productitems_id");
         productitems_id_db1.DbName = "productitems.id";
         productitems_id_db1.DbAlias = "pitems.id";
         var productitems_name_db2 = new Mobilize.Web.DB.Column();
         productitems_name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         productitems_name_db2.UpdateWhereClause = false;
         productitems_name_db2.Name = Mobilize.Web.CaseExtensions.String("productitems_name");
         productitems_name_db2.DbName = "productitems.name";
         productitems_name_db2.DbAlias = "pitems.name";
         var productitems_price_db3 = new Mobilize.Web.DB.Column();
         productitems_price_db3.Type = Mobilize.Web.CaseExtensions.String("real");
         productitems_price_db3.UpdateWhereClause = true;
         productitems_price_db3.Name = Mobilize.Web.CaseExtensions.String("productitems_price");
         productitems_price_db3.DbName = "productitems.price";
         productitems_price_db3.DbAlias = "pitems.price";
         var productitems_imagename_db4 = new Mobilize.Web.DB.Column();
         productitems_imagename_db4.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         productitems_imagename_db4.UpdateWhereClause = false;
         productitems_imagename_db4.Name = Mobilize.Web.CaseExtensions.String("productitems_imagename");
         productitems_imagename_db4.DbName = "productitems.imagename";
         productitems_imagename_db4.DbAlias = "pitems.imagename";
         var productfeatures_title_db5 = new Mobilize.Web.DB.Column();
         productfeatures_title_db5.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         productfeatures_title_db5.UpdateWhereClause = false;
         productfeatures_title_db5.Name = Mobilize.Web.CaseExtensions.String("productfeatures_title");
         productfeatures_title_db5.DbName = "productfeatures.title";
         productfeatures_title_db5.DbAlias = "pfeatures.title";
         var productbrands_brand_db6 = new Mobilize.Web.DB.Column();
         productbrands_brand_db6.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         productbrands_brand_db6.UpdateWhereClause = false;
         productbrands_brand_db6.Name = Mobilize.Web.CaseExtensions.String("productbrands_brand");
         productbrands_brand_db6.DbName = "productbrands.brand";
         productbrands_brand_db6.DbAlias = "pbrands.brand";
         var producttypes_type_db7 = new Mobilize.Web.DB.Column();
         producttypes_type_db7.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         producttypes_type_db7.UpdateWhereClause = false;
         producttypes_type_db7.Name = Mobilize.Web.CaseExtensions.String("producttypes_type");
         producttypes_type_db7.DbName = "producttypes.type";
         producttypes_type_db7.DbAlias = "ptypes.type";
         var producttypes_code_db8 = new Mobilize.Web.DB.Column();
         producttypes_code_db8.Type = Mobilize.Web.CaseExtensions.String("char(450)");
         producttypes_code_db8.UpdateWhereClause = true;
         producttypes_code_db8.Name = Mobilize.Web.CaseExtensions.String("producttypes_code");
         producttypes_code_db8.DbName = "producttypes.code";
         producttypes_code_db8.DbAlias = "ptypes.code";
         var tags_tag_db9 = new Mobilize.Web.DB.Column();
         tags_tag_db9.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         tags_tag_db9.UpdateWhereClause = false;
         tags_tag_db9.Name = Mobilize.Web.CaseExtensions.String("tags_tag");
         tags_tag_db9.DbName = "tags.tag";
         tags_tag_db9.DbAlias = "ptags.tag";
         this.AddArguments(new Mobilize.Web.DBArgument("keyword", "String"));
         this.RetrieveStatement = "  SELECT \r\n         pitems.id as id,\r\n         pitems.name as name,   \r\n         pitems.price as price,   \r\n         pitems.imagename as imagename,\r\n\t\t pfeatures.title as title,\r\n\t\t pbrands.Name as brand,  \r\n         ptypes.name as type,   \r\n         ptypes.code as code,\r\n         ptags.value as tag \r\n    FROM  productitems pitems \r\n         left outer join producttypes ptypes on ptypes.id = pitems.typeid\r\n\t\t left outer join tags ptags on ptags.Id = pitems.tagid\r\n\t\t left outer join productbrands pbrands on pbrands.Id = pitems.brandid\r\n\t\t left outer join productfeatures pfeatures on pfeatures.ProductItemId = pitems.Id\r\n\twhere \r\n\t pitems.name like :keyword or\r\n\t ptypes.name like :keyword or\r\n\t ptypes.code like :keyword or\r\n\t pbrands.name like :keyword or \r\n\t pfeatures.title like :keyword";
         this.productfeatures_title_t = new Mobilize.Web.DmText();
         this.productfeatures_title_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productfeatures_title_t.Alignment = 2;
         this.productfeatures_title_t.Text = "Feature";
         this.productfeatures_title_t.Border = 0;
         this.productfeatures_title_t.Color = "33554432";
         this.productfeatures_title_t.X = 2555;
         this.productfeatures_title_t.Y = 8;
         this.productfeatures_title_t.Height = 104;
         this.productfeatures_title_t.Width = 882;
         this.productfeatures_title_t.Name = Mobilize.Web.CaseExtensions.String("productfeatures_title_t");
         this.productfeatures_title_t.Visible = true;
         this.productfeatures_title_t.Font.FontFace = "Tahoma";
         this.productfeatures_title_t.Font.Height = -12;
         this.productfeatures_title_t.Font.Weight = 400;
         this.productfeatures_title_t.Font.FontFamily = "2";
         this.productfeatures_title_t.Font.Pitch = "2";
         this.productfeatures_title_t.Font.Charset = "0";
         this.productfeatures_title_t.Background.Mode = 1;
         this.productfeatures_title_t.Background.Color = "536870912";
         this.productitems_name_t = new Mobilize.Web.DmText();
         this.productitems_name_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productitems_name_t.Alignment = 2;
         this.productitems_name_t.Text = "Name";
         this.productitems_name_t.Border = 0;
         this.productitems_name_t.Color = "33554432";
         this.productitems_name_t.X = 9;
         this.productitems_name_t.Y = 8;
         this.productitems_name_t.Height = 112;
         this.productitems_name_t.Width = 1019;
         this.productitems_name_t.Name = Mobilize.Web.CaseExtensions.String("productitems_name_t");
         this.productitems_name_t.Visible = true;
         this.productitems_name_t.Font.FontFace = "Tahoma";
         this.productitems_name_t.Font.Height = -12;
         this.productitems_name_t.Font.Weight = 400;
         this.productitems_name_t.Font.FontFamily = "2";
         this.productitems_name_t.Font.Pitch = "2";
         this.productitems_name_t.Font.Charset = "0";
         this.productitems_name_t.Background.Mode = 1;
         this.productitems_name_t.Background.Color = "536870912";
         this.productitems_price_t = new Mobilize.Web.DmText();
         this.productitems_price_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productitems_price_t.Alignment = 2;
         this.productitems_price_t.Text = "Price$";
         this.productitems_price_t.Border = 0;
         this.productitems_price_t.Color = "33554432";
         this.productitems_price_t.X = 4297;
         this.productitems_price_t.Y = 8;
         this.productitems_price_t.Height = 64;
         this.productitems_price_t.Width = 338;
         this.productitems_price_t.Name = Mobilize.Web.CaseExtensions.String("productitems_price_t");
         this.productitems_price_t.Visible = true;
         this.productitems_price_t.Font.FontFace = "Tahoma";
         this.productitems_price_t.Font.Height = -12;
         this.productitems_price_t.Font.Weight = 400;
         this.productitems_price_t.Font.FontFamily = "2";
         this.productitems_price_t.Font.Pitch = "2";
         this.productitems_price_t.Font.Charset = "0";
         this.productitems_price_t.Background.Mode = 1;
         this.productitems_price_t.Background.Color = "536870912";
         this.productitems_imagename_t = new Mobilize.Web.DmText();
         this.productitems_imagename_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productitems_imagename_t.Alignment = 2;
         this.productitems_imagename_t.Text = "Imagename";
         this.productitems_imagename_t.Border = 0;
         this.productitems_imagename_t.Color = "33554432";
         this.productitems_imagename_t.X = 11227;
         this.productitems_imagename_t.Y = 8;
         this.productitems_imagename_t.Height = 112;
         this.productitems_imagename_t.Width = 571;
         this.productitems_imagename_t.Name = Mobilize.Web.CaseExtensions.String("productitems_imagename_t");
         this.productitems_imagename_t.Visible = true;
         this.productitems_imagename_t.Font.FontFace = "Tahoma";
         this.productitems_imagename_t.Font.Height = -12;
         this.productitems_imagename_t.Font.Weight = 400;
         this.productitems_imagename_t.Font.FontFamily = "2";
         this.productitems_imagename_t.Font.Pitch = "2";
         this.productitems_imagename_t.Font.Charset = "0";
         this.productitems_imagename_t.Background.Mode = 1;
         this.productitems_imagename_t.Background.Color = "536870912";
         this.producttypes_code_t = new Mobilize.Web.DmText();
         this.producttypes_code_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.producttypes_code_t.Alignment = 2;
         this.producttypes_code_t.Text = "Code";
         this.producttypes_code_t.Border = 0;
         this.producttypes_code_t.Color = "33554432";
         this.producttypes_code_t.X = 3447;
         this.producttypes_code_t.Y = 8;
         this.producttypes_code_t.Height = 112;
         this.producttypes_code_t.Width = 841;
         this.producttypes_code_t.Name = Mobilize.Web.CaseExtensions.String("producttypes_code_t");
         this.producttypes_code_t.Visible = true;
         this.producttypes_code_t.Font.FontFace = "Tahoma";
         this.producttypes_code_t.Font.Height = -12;
         this.producttypes_code_t.Font.Weight = 400;
         this.producttypes_code_t.Font.FontFamily = "2";
         this.producttypes_code_t.Font.Pitch = "2";
         this.producttypes_code_t.Font.Charset = "0";
         this.producttypes_code_t.Background.Mode = 1;
         this.producttypes_code_t.Background.Color = "536870912";
         this.productbrands_brand_t = new Mobilize.Web.DmText();
         this.productbrands_brand_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productbrands_brand_t.Alignment = 0;
         this.productbrands_brand_t.Text = "Brand";
         this.productbrands_brand_t.Border = 0;
         this.productbrands_brand_t.Color = "33554432";
         this.productbrands_brand_t.X = 1038;
         this.productbrands_brand_t.Y = 4;
         this.productbrands_brand_t.Height = 76;
         this.productbrands_brand_t.Width = 814;
         this.productbrands_brand_t.Name = Mobilize.Web.CaseExtensions.String("productbrands_brand_t");
         this.productbrands_brand_t.Visible = true;
         this.productbrands_brand_t.Font.FontFace = "Tahoma";
         this.productbrands_brand_t.Font.Height = -12;
         this.productbrands_brand_t.Font.Weight = 400;
         this.productbrands_brand_t.Font.FontFamily = "2";
         this.productbrands_brand_t.Font.Pitch = "2";
         this.productbrands_brand_t.Font.Charset = "0";
         this.productbrands_brand_t.Background.Mode = 2;
         this.productbrands_brand_t.Background.Color = "1073741824";
         this.producttypes_type_t = new Mobilize.Web.DmText();
         this.producttypes_type_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.producttypes_type_t.Alignment = 0;
         this.producttypes_type_t.Text = "Type";
         this.producttypes_type_t.Border = 0;
         this.producttypes_type_t.Color = "33554432";
         this.producttypes_type_t.X = 1861;
         this.producttypes_type_t.Y = 4;
         this.producttypes_type_t.Height = 76;
         this.producttypes_type_t.Width = 686;
         this.producttypes_type_t.Name = Mobilize.Web.CaseExtensions.String("producttypes_type_t");
         this.producttypes_type_t.Visible = true;
         this.producttypes_type_t.Font.FontFace = "Tahoma";
         this.producttypes_type_t.Font.Height = -12;
         this.producttypes_type_t.Font.Weight = 400;
         this.producttypes_type_t.Font.FontFamily = "2";
         this.producttypes_type_t.Font.Pitch = "2";
         this.producttypes_type_t.Font.Charset = "0";
         this.producttypes_type_t.Background.Mode = 2;
         this.producttypes_type_t.Background.Color = "1073741824";
         this.tags_tag_t = new Mobilize.Web.DmText();
         this.tags_tag_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.tags_tag_t.Alignment = 0;
         this.tags_tag_t.Text = "Tag";
         this.tags_tag_t.Border = 0;
         this.tags_tag_t.Color = "33554432";
         this.tags_tag_t.X = 4645;
         this.tags_tag_t.Y = 4;
         this.tags_tag_t.Height = 76;
         this.tags_tag_t.Width = 6574;
         this.tags_tag_t.Name = Mobilize.Web.CaseExtensions.String("tags_tag_t");
         this.tags_tag_t.Visible = true;
         this.tags_tag_t.Font.FontFace = "Tahoma";
         this.tags_tag_t.Font.Height = -12;
         this.tags_tag_t.Font.Weight = 400;
         this.tags_tag_t.Font.FontFamily = "2";
         this.tags_tag_t.Font.Pitch = "2";
         this.tags_tag_t.Font.Charset = "0";
         this.tags_tag_t.Background.Mode = 2;
         this.tags_tag_t.Background.Color = "1073741824";
         this.productfeatures_title = new Mobilize.Web.DmColumn();
         this.productfeatures_title.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productfeatures_title.Id = 5;
         this.productfeatures_title.Alignment = 0;
         this.productfeatures_title.TabSequence = 32766;
         this.productfeatures_title.Border = 0;
         this.productfeatures_title.Color = "33554432";
         this.productfeatures_title.X = 2555;
         this.productfeatures_title.Y = 8;
         this.productfeatures_title.Height = 76;
         this.productfeatures_title.Width = 882;
         this.productfeatures_title.Format = "[general]";
         this.productfeatures_title.Name = Mobilize.Web.CaseExtensions.String("productfeatures_title");
         this.productfeatures_title.Visible = true;
         this.productfeatures_title.Edit.Limit = 16383;
         this.productfeatures_title.Edit.Case = "any";
         this.productfeatures_title.Edit.FocusRectangle = false;
         this.productfeatures_title.Edit.AutoSelect = true;
         this.productfeatures_title.Edit.AutoHScroll = true;
         this.productfeatures_title.Font.FontFace = "Tahoma";
         this.productfeatures_title.Font.Height = -10;
         this.productfeatures_title.Font.Weight = 400;
         this.productfeatures_title.Font.FontFamily = "2";
         this.productfeatures_title.Font.Pitch = "2";
         this.productfeatures_title.Font.Charset = "0";
         this.productfeatures_title.Background.Mode = 1;
         this.productfeatures_title.Background.Color = "536870912";
         this.productfeatures_title.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.productitems_name = new Mobilize.Web.DmColumn();
         this.productitems_name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productitems_name.Id = 2;
         this.productitems_name.Alignment = 0;
         this.productitems_name.TabSequence = 32766;
         this.productitems_name.Border = 0;
         this.productitems_name.Color = "33554432";
         this.productitems_name.X = 9;
         this.productitems_name.Y = 8;
         this.productitems_name.Height = 76;
         this.productitems_name.Width = 1019;
         this.productitems_name.Format = "[general]";
         this.productitems_name.Name = Mobilize.Web.CaseExtensions.String("productitems_name");
         this.productitems_name.Visible = true;
         this.productitems_name.Edit.Limit = 16383;
         this.productitems_name.Edit.Case = "any";
         this.productitems_name.Edit.FocusRectangle = false;
         this.productitems_name.Edit.AutoSelect = true;
         this.productitems_name.Edit.AutoHScroll = true;
         this.productitems_name.Font.FontFace = "Tahoma";
         this.productitems_name.Font.Height = -10;
         this.productitems_name.Font.Weight = 400;
         this.productitems_name.Font.FontFamily = "2";
         this.productitems_name.Font.Pitch = "2";
         this.productitems_name.Font.Charset = "0";
         this.productitems_name.Background.Mode = 1;
         this.productitems_name.Background.Color = "536870912";
         this.productitems_name.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.productitems_price = new Mobilize.Web.DmColumn();
         this.productitems_price.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productitems_price.Id = 3;
         this.productitems_price.Alignment = 1;
         this.productitems_price.TabSequence = 32766;
         this.productitems_price.Border = 0;
         this.productitems_price.Color = "33554432";
         this.productitems_price.X = 4297;
         this.productitems_price.Y = 8;
         this.productitems_price.Height = 76;
         this.productitems_price.Width = 338;
         this.productitems_price.Format = "[general]";
         this.productitems_price.Name = Mobilize.Web.CaseExtensions.String("productitems_price");
         this.productitems_price.Visible = true;
         this.productitems_price.Edit.Limit = 0;
         this.productitems_price.Edit.Case = "any";
         this.productitems_price.Edit.FocusRectangle = false;
         this.productitems_price.Edit.AutoSelect = true;
         this.productitems_price.Edit.AutoHScroll = true;
         this.productitems_price.Font.FontFace = "Tahoma";
         this.productitems_price.Font.Height = -10;
         this.productitems_price.Font.Weight = 400;
         this.productitems_price.Font.FontFamily = "2";
         this.productitems_price.Font.Pitch = "2";
         this.productitems_price.Font.Charset = "0";
         this.productitems_price.Background.Mode = 1;
         this.productitems_price.Background.Color = "536870912";
         this.productitems_price.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.productitems_imagename = new Mobilize.Web.DmColumn();
         this.productitems_imagename.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productitems_imagename.Id = 4;
         this.productitems_imagename.Alignment = 0;
         this.productitems_imagename.TabSequence = 32766;
         this.productitems_imagename.Border = 0;
         this.productitems_imagename.Color = "33554432";
         this.productitems_imagename.X = 11227;
         this.productitems_imagename.Y = 8;
         this.productitems_imagename.Height = 76;
         this.productitems_imagename.Width = 571;
         this.productitems_imagename.Format = "[general]";
         this.productitems_imagename.Name = Mobilize.Web.CaseExtensions.String("productitems_imagename");
         this.productitems_imagename.Visible = true;
         this.productitems_imagename.Edit.Limit = 16383;
         this.productitems_imagename.Edit.Case = "any";
         this.productitems_imagename.Edit.FocusRectangle = false;
         this.productitems_imagename.Edit.AutoSelect = true;
         this.productitems_imagename.Edit.AutoHScroll = true;
         this.productitems_imagename.Font.FontFace = "Tahoma";
         this.productitems_imagename.Font.Height = -10;
         this.productitems_imagename.Font.Weight = 400;
         this.productitems_imagename.Font.FontFamily = "2";
         this.productitems_imagename.Font.Pitch = "2";
         this.productitems_imagename.Font.Charset = "0";
         this.productitems_imagename.Background.Mode = 1;
         this.productitems_imagename.Background.Color = "536870912";
         this.productitems_imagename.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.producttypes_code = new Mobilize.Web.DmColumn();
         this.producttypes_code.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.producttypes_code.Id = 8;
         this.producttypes_code.Alignment = 0;
         this.producttypes_code.TabSequence = 32766;
         this.producttypes_code.Border = 0;
         this.producttypes_code.Color = "33554432";
         this.producttypes_code.X = 3447;
         this.producttypes_code.Y = 8;
         this.producttypes_code.Height = 76;
         this.producttypes_code.Width = 841;
         this.producttypes_code.Format = "[general]";
         this.producttypes_code.Name = Mobilize.Web.CaseExtensions.String("producttypes_code");
         this.producttypes_code.Visible = true;
         this.producttypes_code.Edit.Limit = 450;
         this.producttypes_code.Edit.Case = "any";
         this.producttypes_code.Edit.FocusRectangle = false;
         this.producttypes_code.Edit.AutoSelect = true;
         this.producttypes_code.Edit.AutoHScroll = true;
         this.producttypes_code.Font.FontFace = "Tahoma";
         this.producttypes_code.Font.Height = -10;
         this.producttypes_code.Font.Weight = 400;
         this.producttypes_code.Font.FontFamily = "2";
         this.producttypes_code.Font.Pitch = "2";
         this.producttypes_code.Font.Charset = "0";
         this.producttypes_code.Background.Mode = 1;
         this.producttypes_code.Background.Color = "536870912";
         this.producttypes_code.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.productbrands_brand = new Mobilize.Web.DmColumn();
         this.productbrands_brand.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productbrands_brand.Id = 6;
         this.productbrands_brand.Alignment = 0;
         this.productbrands_brand.TabSequence = 32766;
         this.productbrands_brand.Border = 0;
         this.productbrands_brand.Color = "33554432";
         this.productbrands_brand.X = 1038;
         this.productbrands_brand.Y = 0;
         this.productbrands_brand.Height = 64;
         this.productbrands_brand.Width = 814;
         this.productbrands_brand.Format = "[general]";
         this.productbrands_brand.Name = Mobilize.Web.CaseExtensions.String("productbrands_brand");
         this.productbrands_brand.Visible = true;
         this.productbrands_brand.Edit.Limit = 0;
         this.productbrands_brand.Edit.Case = "any";
         this.productbrands_brand.Edit.FocusRectangle = false;
         this.productbrands_brand.Edit.AutoSelect = false;
         this.productbrands_brand.Font.FontFace = "Tahoma";
         this.productbrands_brand.Font.Height = -10;
         this.productbrands_brand.Font.Weight = 400;
         this.productbrands_brand.Font.FontFamily = "2";
         this.productbrands_brand.Font.Pitch = "2";
         this.productbrands_brand.Font.Charset = "0";
         this.productbrands_brand.Background.Mode = 1;
         this.productbrands_brand.Background.Color = "536870912";
         this.productbrands_brand.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.producttypes_type = new Mobilize.Web.DmColumn();
         this.producttypes_type.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.producttypes_type.Id = 7;
         this.producttypes_type.Alignment = 0;
         this.producttypes_type.TabSequence = 32766;
         this.producttypes_type.Border = 0;
         this.producttypes_type.Color = "33554432";
         this.producttypes_type.X = 1861;
         this.producttypes_type.Y = 0;
         this.producttypes_type.Height = 64;
         this.producttypes_type.Width = 686;
         this.producttypes_type.Format = "[general]";
         this.producttypes_type.Name = Mobilize.Web.CaseExtensions.String("producttypes_type");
         this.producttypes_type.Visible = true;
         this.producttypes_type.Edit.Limit = 0;
         this.producttypes_type.Edit.Case = "any";
         this.producttypes_type.Edit.FocusRectangle = false;
         this.producttypes_type.Edit.AutoSelect = false;
         this.producttypes_type.Font.FontFace = "Tahoma";
         this.producttypes_type.Font.Height = -10;
         this.producttypes_type.Font.Weight = 400;
         this.producttypes_type.Font.FontFamily = "2";
         this.producttypes_type.Font.Pitch = "2";
         this.producttypes_type.Font.Charset = "0";
         this.producttypes_type.Background.Mode = 1;
         this.producttypes_type.Background.Color = "536870912";
         this.producttypes_type.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.tags_tag = new Mobilize.Web.DmColumn();
         this.tags_tag.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tags_tag.Id = 9;
         this.tags_tag.Alignment = 0;
         this.tags_tag.TabSequence = 32766;
         this.tags_tag.Border = 0;
         this.tags_tag.Color = "33554432";
         this.tags_tag.X = 4645;
         this.tags_tag.Y = 0;
         this.tags_tag.Height = 64;
         this.tags_tag.Width = 6574;
         this.tags_tag.Format = "[general]";
         this.tags_tag.Name = Mobilize.Web.CaseExtensions.String("tags_tag");
         this.tags_tag.Visible = true;
         this.tags_tag.Edit.Limit = 0;
         this.tags_tag.Edit.Case = "any";
         this.tags_tag.Edit.FocusRectangle = false;
         this.tags_tag.Edit.AutoSelect = false;
         this.tags_tag.Font.FontFace = "Tahoma";
         this.tags_tag.Font.Height = -10;
         this.tags_tag.Font.Weight = 400;
         this.tags_tag.Font.FontFamily = "2";
         this.tags_tag.Font.Pitch = "2";
         this.tags_tag.Font.Charset = "0";
         this.tags_tag.Background.Mode = 1;
         this.tags_tag.Background.Color = "536870912";
         this.tags_tag.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.productitems_id = new Mobilize.Web.DmColumn();
         this.productitems_id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.productitems_id.Id = 1;
         this.productitems_id.Alignment = 0;
         this.productitems_id.TabSequence = 0;
         this.productitems_id.Border = 0;
         this.productitems_id.Color = "33554432";
         this.productitems_id.X = 11813;
         this.productitems_id.Y = 0;
         this.productitems_id.Height = 64;
         this.productitems_id.Width = 2126;
         this.productitems_id.Name = Mobilize.Web.CaseExtensions.String("productitems_id");
         this.productitems_id.Visible = true;
         this.productitems_id.Edit.Limit = 0;
         this.productitems_id.Edit.Case = "any";
         this.productitems_id.Edit.FocusRectangle = false;
         this.productitems_id.Edit.AutoSelect = false;
         this.productitems_id.Font.FontFace = "Tahoma";
         this.productitems_id.Font.Height = -10;
         this.productitems_id.Font.Weight = 400;
         this.productitems_id.Font.FontFamily = "2";
         this.productitems_id.Font.Pitch = "2";
         this.productitems_id.Font.Charset = "0";
         this.productitems_id.Background.Mode = 1;
         this.productitems_id.Background.Color = "536870912";
         this.productitems_id_t = new Mobilize.Web.DmText();
         this.productitems_id_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.productitems_id_t.Alignment = 0;
         this.productitems_id_t.Text = "Productitems Id";
         this.productitems_id_t.Border = 0;
         this.productitems_id_t.Color = "33554432";
         this.productitems_id_t.X = 11808;
         this.productitems_id_t.Y = 4;
         this.productitems_id_t.Height = 76;
         this.productitems_id_t.Width = 2130;
         this.productitems_id_t.Name = Mobilize.Web.CaseExtensions.String("productitems_id_t");
         this.productitems_id_t.Visible = true;
         this.productitems_id_t.Font.FontFace = "Tahoma";
         this.productitems_id_t.Font.Height = -12;
         this.productitems_id_t.Font.Weight = 400;
         this.productitems_id_t.Font.FontFamily = "2";
         this.productitems_id_t.Font.Pitch = "2";
         this.productitems_id_t.Font.Charset = "0";
         this.productitems_id_t.Background.Mode = 2;
         this.productitems_id_t.Background.Color = "1073741824";
         this.AddColumns(new Mobilize.Web.DB.Column[] { productitems_id_db1, productitems_name_db2, productitems_price_db3, productitems_imagename_db4, productfeatures_title_db5, productbrands_brand_db6, producttypes_type_db7, producttypes_code_db8, tags_tag_db9 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.productfeatures_title_t, this.productitems_name_t, this.productitems_price_t, this.productitems_imagename_t, this.producttypes_code_t, this.productbrands_brand_t, this.producttypes_type_t, this.tags_tag_t, this.productfeatures_title, this.productitems_name, this.productitems_price, this.productitems_imagename, this.producttypes_code, this.productbrands_brand, this.producttypes_type, this.tags_tag, this.productitems_id, this.productitems_id_t });
         this.PopulateRadioButtons();
      }
   }

}