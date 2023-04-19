namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_tag
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText value_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn value { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }


      public d_tag()
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
         this.Header.Height = 36;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 348;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         id_db1.Update = true;
         id_db1.UpdateWhereClause = true;
         id_db1.Key = Mobilize.Web.CaseExtensions.String("yes");
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "tags.id";
         var value_db2 = new Mobilize.Web.DB.Column();
         value_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         value_db2.Update = true;
         value_db2.UpdateWhereClause = false;
         value_db2.Name = Mobilize.Web.CaseExtensions.String("value");
         value_db2.DbName = "tags.value";
         this.RetrieveStatement = "PBSELECT(TABLE(NAME=\"tags\") COLUMN(NAME=\"tags.id\")COLUMN(NAME=\"tags.value\"))";
         this.UpdateTableName = "tags";
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
         this.id_t.Width = 169;
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
         this.value_t = new Mobilize.Web.DmText();
         this.value_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.value_t.Alignment = 1;
         this.value_t.Text = "Tag Value:";
         this.value_t.Border = 0;
         this.value_t.Color = "33554432";
         this.value_t.X = 0;
         this.value_t.Y = 140;
         this.value_t.Height = 68;
         this.value_t.Width = 288;
         this.value_t.Name = Mobilize.Web.CaseExtensions.String("value_t");
         this.value_t.Visible = true;
         this.value_t.Font.FontFace = "Segoe UI";
         this.value_t.Font.Height = -10;
         this.value_t.Font.Weight = 400;
         this.value_t.Font.FontFamily = "2";
         this.value_t.Font.Pitch = "2";
         this.value_t.Font.Charset = "0";
         this.value_t.Background.Mode = 1;
         this.value_t.Background.Color = "536870912";
         this.value = new Mobilize.Web.DmColumn();
         this.value.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.value.Id = 2;
         this.value.Alignment = 0;
         this.value.TabSequence = 20;
         this.value.Border = 0;
         this.value.Color = "33554432";
         this.value.X = 389;
         this.value.Y = 140;
         this.value.Height = 100;
         this.value.Width = 1993;
         this.value.Format = "[general]";
         this.value.Name = Mobilize.Web.CaseExtensions.String("value");
         this.value.Visible = true;
         this.value.Edit.Limit = 16383;
         this.value.Edit.Case = "any";
         this.value.Edit.FocusRectangle = false;
         this.value.Edit.AutoSelect = true;
         this.value.Edit.AutoHScroll = true;
         this.value.Font.FontFace = "Segoe UI";
         this.value.Font.Height = -10;
         this.value.Font.Weight = 400;
         this.value.Font.FontFamily = "2";
         this.value.Font.Pitch = "2";
         this.value.Font.Charset = "0";
         this.value.Background.Mode = 1;
         this.value.Background.Color = "536870912";
         this.value.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
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
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, value_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.value_t, this.value, this._id });
         this.PopulateRadioButtons();
      }
   }

}