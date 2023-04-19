namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_productbrands
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }


      public d_productbrands()
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
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 280;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         id_db1.Update = true;
         id_db1.UpdateWhereClause = true;
         id_db1.Key = Mobilize.Web.CaseExtensions.String("yes");
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "productbrands.id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         name_db2.Update = true;
         name_db2.UpdateWhereClause = false;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "productbrands.name";
         this.RetrieveStatement = "PBSELECT(TABLE(NAME=\"productbrands\") COLUMN(NAME=\"productbrands.id\")COLUMN(NAME=\"productbrands.name\"))";
         this.UpdateTableName = "productbrands";
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
         this.id_t.Width = 174;
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
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_t.Alignment = 1;
         this.name_t.Text = "Brand Name:";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 0;
         this.name_t.Y = 140;
         this.name_t.Height = 68;
         this.name_t.Width = 347;
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
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 1;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 411;
         this._id.Y = 0;
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
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 411;
         this._name.Y = 136;
         this._name.Height = 76;
         this._name.Width = 791;
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
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.name_t, this._id, this._name });
         this.PopulateRadioButtons();
      }
   }

}