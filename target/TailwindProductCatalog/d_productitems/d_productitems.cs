namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_productitems
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn brandid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText brandid_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText typeid_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn typeid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tagid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tagid_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText price_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn imagename { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText imagename_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn price { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }


      public d_productitems()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("0");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("0");
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
         this.Header.Height = 0;
         this.Header.Color = "536870912";
         this.Summary.Height = 224;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 1320;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         id_db1.Update = true;
         id_db1.UpdateWhereClause = true;
         id_db1.Key = Mobilize.Web.CaseExtensions.String("yes");
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "productitems.id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         name_db2.Update = true;
         name_db2.UpdateWhereClause = false;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "productitems.name";
         var price_db3 = new Mobilize.Web.DB.Column();
         price_db3.Type = Mobilize.Web.CaseExtensions.String("real");
         price_db3.Update = true;
         price_db3.UpdateWhereClause = true;
         price_db3.Name = Mobilize.Web.CaseExtensions.String("price");
         price_db3.DbName = "productitems.price";
         var imagename_db4 = new Mobilize.Web.DB.Column();
         imagename_db4.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         imagename_db4.Update = true;
         imagename_db4.UpdateWhereClause = false;
         imagename_db4.Name = Mobilize.Web.CaseExtensions.String("imagename");
         imagename_db4.DbName = "productitems.imagename";
         var brandid_db5 = new Mobilize.Web.DB.Column();
         brandid_db5.Type = Mobilize.Web.CaseExtensions.String("long");
         brandid_db5.Update = true;
         brandid_db5.UpdateWhereClause = true;
         brandid_db5.Name = Mobilize.Web.CaseExtensions.String("brandid");
         brandid_db5.DbName = "productitems.brandid";
         var typeid_db6 = new Mobilize.Web.DB.Column();
         typeid_db6.Type = Mobilize.Web.CaseExtensions.String("long");
         typeid_db6.Update = true;
         typeid_db6.UpdateWhereClause = true;
         typeid_db6.Name = Mobilize.Web.CaseExtensions.String("typeid");
         typeid_db6.DbName = "productitems.typeid";
         var tagid_db7 = new Mobilize.Web.DB.Column();
         tagid_db7.Type = Mobilize.Web.CaseExtensions.String("long");
         tagid_db7.Update = true;
         tagid_db7.UpdateWhereClause = true;
         tagid_db7.Name = Mobilize.Web.CaseExtensions.String("tagid");
         tagid_db7.DbName = "productitems.tagid";
         this.RetrieveStatement = "PBSELECT(TABLE(NAME=\"productitems\") COLUMN(NAME=\"productitems.id\")COLUMN(NAME=\"productitems.name\")COLUMN(NAME=\"productitems.price\")COLUMN(NAME=\"productitems.imagename\")COLUMN(NAME=\"productitems.brandid\")COLUMN(NAME=\"productitems.typeid\")COLUMN(NAME=\"productitems.tagid\"))";
         this.UpdateTableName = "productitems";
         this.UpdateWhere = 1;
         this.UpdateKeyInPlace = false;
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.id_t.Alignment = 1;
         this.id_t.Text = "Id:";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 37;
         this.id_t.Y = 4;
         this.id_t.Height = 68;
         this.id_t.Width = 334;
         this.id_t.Name = Mobilize.Web.CaseExtensions.String("id_t");
         this.id_t.Visible = true;
         this.id_t.Font.FontFace = "Segoe UI";
         this.id_t.Font.Height = -10;
         this.id_t.Font.Weight = 400;
         this.id_t.Font.FontFamily = "2";
         this.id_t.Font.Pitch = "2";
         this.id_t.Font.Charset = "0";
         this.id_t.Background.Mode = 1;
         this.id_t.Background.Color = "536870912";
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 1;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 389;
         this._id.Y = 4;
         this._id.Height = 76;
         this._id.Width = 329;
         this._id.Format = "[general]";
         this._id.Name = Mobilize.Web.CaseExtensions.String("id");
         this._id.Visible = true;
         this._id.Edit.Limit = 0;
         this._id.Edit.Case = "any";
         this._id.Edit.FocusRectangle = false;
         this._id.Edit.AutoSelect = true;
         this._id.Edit.AutoHScroll = true;
         this._id.Font.FontFace = "Segoe UI";
         this._id.Font.Height = -10;
         this._id.Font.Weight = 400;
         this._id.Font.FontFamily = "2";
         this._id.Font.Pitch = "2";
         this._id.Font.Charset = "0";
         this._id.Background.Mode = 1;
         this._id.Background.Color = "536870912";
         this._id.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.brandid = new Mobilize.Web.DmColumn();
         this.brandid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.brandid.Id = 5;
         this.brandid.Alignment = 1;
         this.brandid.TabSequence = 50;
         this.brandid.Border = 0;
         this.brandid.Color = "33554432";
         this.brandid.X = 393;
         this.brandid.Y = 468;
         this.brandid.Height = 80;
         this.brandid.Width = 2085;
         this.brandid.Format = "[general]";
         this.brandid.Name = Mobilize.Web.CaseExtensions.String("brandid");
         this.brandid.Visible = true;
         this.brandid.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_productbrandslist");
         this.brandid.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("name");
         this.brandid.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.brandid.DdDm.PercentWidth = 0;
         this.brandid.DdDm.Lines = 0;
         this.brandid.DdDm.Limit = 0;
         this.brandid.DdDm.AllowEdit = false;
         this.brandid.DdDm.UseAsBorder = true;
         this.brandid.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.brandid.Font.FontFace = "Segoe UI";
         this.brandid.Font.Height = -10;
         this.brandid.Font.Weight = 400;
         this.brandid.Font.FontFamily = "2";
         this.brandid.Font.Pitch = "2";
         this.brandid.Font.Charset = "0";
         this.brandid.Background.Mode = 1;
         this.brandid.Background.Color = "536870912";
         this.brandid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.brandid_t = new Mobilize.Web.DmText();
         this.brandid_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.brandid_t.Alignment = 1;
         this.brandid_t.Text = "Brandid:";
         this.brandid_t.Border = 0;
         this.brandid_t.Color = "33554432";
         this.brandid_t.X = 37;
         this.brandid_t.Y = 468;
         this.brandid_t.Height = 68;
         this.brandid_t.Width = 334;
         this.brandid_t.Name = Mobilize.Web.CaseExtensions.String("brandid_t");
         this.brandid_t.Visible = true;
         this.brandid_t.Font.FontFace = "Segoe UI";
         this.brandid_t.Font.Height = -10;
         this.brandid_t.Font.Weight = 400;
         this.brandid_t.Font.FontFamily = "2";
         this.brandid_t.Font.Pitch = "2";
         this.brandid_t.Font.Charset = "0";
         this.brandid_t.Background.Mode = 1;
         this.brandid_t.Background.Color = "536870912";
         this.typeid_t = new Mobilize.Web.DmText();
         this.typeid_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.typeid_t.Alignment = 1;
         this.typeid_t.Text = "Typeid:";
         this.typeid_t.Border = 0;
         this.typeid_t.Color = "33554432";
         this.typeid_t.X = 41;
         this.typeid_t.Y = 580;
         this.typeid_t.Height = 68;
         this.typeid_t.Width = 334;
         this.typeid_t.Name = Mobilize.Web.CaseExtensions.String("typeid_t");
         this.typeid_t.Visible = true;
         this.typeid_t.Font.FontFace = "Segoe UI";
         this.typeid_t.Font.Height = -10;
         this.typeid_t.Font.Weight = 400;
         this.typeid_t.Font.FontFamily = "2";
         this.typeid_t.Font.Pitch = "2";
         this.typeid_t.Font.Charset = "0";
         this.typeid_t.Background.Mode = 1;
         this.typeid_t.Background.Color = "536870912";
         this.typeid = new Mobilize.Web.DmColumn();
         this.typeid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.typeid.Id = 6;
         this.typeid.Alignment = 1;
         this.typeid.TabSequence = 60;
         this.typeid.Border = 0;
         this.typeid.Color = "33554432";
         this.typeid.X = 389;
         this.typeid.Y = 580;
         this.typeid.Height = 84;
         this.typeid.Width = 2089;
         this.typeid.Format = "[general]";
         this.typeid.Name = Mobilize.Web.CaseExtensions.String("typeid");
         this.typeid.Visible = true;
         this.typeid.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_producttypelist");
         this.typeid.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("name");
         this.typeid.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.typeid.DdDm.PercentWidth = 0;
         this.typeid.DdDm.Lines = 0;
         this.typeid.DdDm.Limit = 0;
         this.typeid.DdDm.AllowEdit = false;
         this.typeid.DdDm.UseAsBorder = true;
         this.typeid.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.typeid.Font.FontFace = "Segoe UI";
         this.typeid.Font.Height = -10;
         this.typeid.Font.Weight = 400;
         this.typeid.Font.FontFamily = "2";
         this.typeid.Font.Pitch = "2";
         this.typeid.Font.Charset = "0";
         this.typeid.Background.Mode = 1;
         this.typeid.Background.Color = "536870912";
         this.typeid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.tagid = new Mobilize.Web.DmColumn();
         this.tagid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tagid.Id = 7;
         this.tagid.Alignment = 1;
         this.tagid.TabSequence = 70;
         this.tagid.Border = 0;
         this.tagid.Color = "33554432";
         this.tagid.X = 384;
         this.tagid.Y = 700;
         this.tagid.Height = 80;
         this.tagid.Width = 2089;
         this.tagid.Format = "[general]";
         this.tagid.Name = Mobilize.Web.CaseExtensions.String("tagid");
         this.tagid.Visible = true;
         this.tagid.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_tagslist");
         this.tagid.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("value");
         this.tagid.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.tagid.DdDm.PercentWidth = 0;
         this.tagid.DdDm.Lines = 0;
         this.tagid.DdDm.Limit = 0;
         this.tagid.DdDm.AllowEdit = false;
         this.tagid.DdDm.UseAsBorder = true;
         this.tagid.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.tagid.DdDm.NilIsNull = true;
         this.tagid.Font.FontFace = "Segoe UI";
         this.tagid.Font.Height = -10;
         this.tagid.Font.Weight = 400;
         this.tagid.Font.FontFamily = "2";
         this.tagid.Font.Pitch = "2";
         this.tagid.Font.Charset = "0";
         this.tagid.Background.Mode = 1;
         this.tagid.Background.Color = "536870912";
         this.tagid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.tagid_t = new Mobilize.Web.DmText();
         this.tagid_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tagid_t.Alignment = 1;
         this.tagid_t.Text = "Tagid:";
         this.tagid_t.Border = 0;
         this.tagid_t.Color = "33554432";
         this.tagid_t.X = 32;
         this.tagid_t.Y = 704;
         this.tagid_t.Height = 68;
         this.tagid_t.Width = 334;
         this.tagid_t.Name = Mobilize.Web.CaseExtensions.String("tagid_t");
         this.tagid_t.Visible = true;
         this.tagid_t.Font.FontFace = "Segoe UI";
         this.tagid_t.Font.Height = -10;
         this.tagid_t.Font.Weight = 400;
         this.tagid_t.Font.FontFamily = "2";
         this.tagid_t.Font.Pitch = "2";
         this.tagid_t.Font.Charset = "0";
         this.tagid_t.Background.Mode = 1;
         this.tagid_t.Background.Color = "536870912";
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_t.Alignment = 1;
         this.name_t.Text = "Name:";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 37;
         this.name_t.Y = 140;
         this.name_t.Height = 68;
         this.name_t.Width = 334;
         this.name_t.Name = Mobilize.Web.CaseExtensions.String("name_t");
         this.name_t.Visible = true;
         this.name_t.Font.FontFace = "Segoe UI";
         this.name_t.Font.Height = -10;
         this.name_t.Font.Weight = 400;
         this.name_t.Font.FontFamily = "2";
         this.name_t.Font.Pitch = "2";
         this.name_t.Font.Charset = "0";
         this.name_t.Background.Mode = 1;
         this.name_t.Background.Color = "536870912";
         this.price_t = new Mobilize.Web.DmText();
         this.price_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.price_t.Alignment = 1;
         this.price_t.Text = "Price:";
         this.price_t.Border = 0;
         this.price_t.Color = "33554432";
         this.price_t.X = 37;
         this.price_t.Y = 252;
         this.price_t.Height = 68;
         this.price_t.Width = 334;
         this.price_t.Name = Mobilize.Web.CaseExtensions.String("price_t");
         this.price_t.Visible = true;
         this.price_t.Font.FontFace = "Segoe UI";
         this.price_t.Font.Height = -10;
         this.price_t.Font.Weight = 400;
         this.price_t.Font.FontFamily = "2";
         this.price_t.Font.Pitch = "2";
         this.price_t.Font.Charset = "0";
         this.price_t.Background.Mode = 1;
         this.price_t.Background.Color = "536870912";
         this.imagename = new Mobilize.Web.DmColumn();
         this.imagename.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.imagename.Id = 4;
         this.imagename.Alignment = 0;
         this.imagename.TabSequence = 40;
         this.imagename.Border = 0;
         this.imagename.Color = "33554432";
         this.imagename.X = 393;
         this.imagename.Y = 356;
         this.imagename.Height = 76;
         this.imagename.Width = 800;
         this.imagename.Format = "[general]";
         this.imagename.Name = Mobilize.Web.CaseExtensions.String("imagename");
         this.imagename.Visible = true;
         this.imagename.Edit.Limit = 16383;
         this.imagename.Edit.Case = "any";
         this.imagename.Edit.FocusRectangle = false;
         this.imagename.Edit.AutoSelect = true;
         this.imagename.Edit.AutoHScroll = true;
         this.imagename.Font.FontFace = "Segoe UI";
         this.imagename.Font.Height = -10;
         this.imagename.Font.Weight = 400;
         this.imagename.Font.FontFamily = "2";
         this.imagename.Font.Pitch = "2";
         this.imagename.Font.Charset = "0";
         this.imagename.Background.Mode = 1;
         this.imagename.Background.Color = "536870912";
         this.imagename.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.imagename_t = new Mobilize.Web.DmText();
         this.imagename_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.imagename_t.Alignment = 1;
         this.imagename_t.Text = "Imagename:";
         this.imagename_t.Border = 0;
         this.imagename_t.Color = "33554432";
         this.imagename_t.X = 37;
         this.imagename_t.Y = 356;
         this.imagename_t.Height = 68;
         this.imagename_t.Width = 334;
         this.imagename_t.Name = Mobilize.Web.CaseExtensions.String("imagename_t");
         this.imagename_t.Visible = true;
         this.imagename_t.Font.FontFace = "Segoe UI";
         this.imagename_t.Font.Height = -10;
         this.imagename_t.Font.Weight = 400;
         this.imagename_t.Font.FontFamily = "2";
         this.imagename_t.Font.Pitch = "2";
         this.imagename_t.Font.Charset = "0";
         this.imagename_t.Background.Mode = 1;
         this.imagename_t.Background.Color = "536870912";
         this.price = new Mobilize.Web.DmColumn();
         this.price.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.price.Id = 3;
         this.price.Alignment = 1;
         this.price.TabSequence = 30;
         this.price.Border = 0;
         this.price.Color = "33554432";
         this.price.X = 389;
         this.price.Y = 252;
         this.price.Height = 76;
         this.price.Width = 329;
         this.price.Format = "[general]";
         this.price.Name = Mobilize.Web.CaseExtensions.String("price");
         this.price.Visible = true;
         this.price.Edit.Limit = 0;
         this.price.Edit.Case = "any";
         this.price.Edit.FocusRectangle = false;
         this.price.Edit.AutoSelect = true;
         this.price.Edit.AutoHScroll = true;
         this.price.Font.FontFace = "Segoe UI";
         this.price.Font.Height = -10;
         this.price.Font.Weight = 400;
         this.price.Font.FontFamily = "2";
         this.price.Font.Pitch = "2";
         this.price.Font.Charset = "0";
         this.price.Background.Mode = 1;
         this.price.Background.Color = "536870912";
         this.price.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 389;
         this._name.Y = 140;
         this._name.Height = 76;
         this._name.Width = 1815;
         this._name.Format = "[general]";
         this._name.Name = Mobilize.Web.CaseExtensions.String("name");
         this._name.Visible = true;
         this._name.Edit.Limit = 16383;
         this._name.Edit.Case = "any";
         this._name.Edit.FocusRectangle = false;
         this._name.Edit.AutoSelect = true;
         this._name.Edit.AutoHScroll = true;
         this._name.Font.FontFace = "Segoe UI";
         this._name.Font.Height = -10;
         this._name.Font.Weight = 400;
         this._name.Font.FontFamily = "2";
         this._name.Font.Pitch = "2";
         this._name.Font.Charset = "0";
         this._name.Background.Mode = 1;
         this._name.Background.Color = "536870912";
         this._name.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, price_db3, imagename_db4, brandid_db5, typeid_db6, tagid_db7 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this._id, this.brandid, this.brandid_t, this.typeid_t, this.typeid, this.tagid, this.tagid_t, this.name_t, this.price_t, this.imagename, this.imagename_t, this.price, this._name });
         this.PopulateRadioButtons();
      }
   }

}