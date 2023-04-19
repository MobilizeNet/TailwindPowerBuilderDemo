namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_productbrandslist
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }


      public d_productbrandslist()
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
         this.Header.Height = 80;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 92;
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
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.name_t.Alignment = 2;
         this.name_t.Text = "Name";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 14;
         this.name_t.Y = 8;
         this.name_t.Height = 64;
         this.name_t.Width = 6583;
         this.name_t.Name = Mobilize.Web.CaseExtensions.String("name_t");
         this.name_t.Visible = true;
         this.name_t.Font.FontFace = "Tahoma";
         this.name_t.Font.Height = -10;
         this.name_t.Font.Weight = 400;
         this.name_t.Font.FontFamily = "2";
         this.name_t.Font.Pitch = "2";
         this.name_t.Font.Charset = "0";
         this.name_t.Background.Mode = 1;
         this.name_t.Background.Color = "536870912";
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 14;
         this._name.Y = 8;
         this._name.Height = 76;
         this._name.Width = 6583;
         this._name.Format = "[general]";
         this._name.Name = Mobilize.Web.CaseExtensions.String("name");
         this._name.Visible = true;
         this._name.Edit.Limit = 16383;
         this._name.Edit.Case = "any";
         this._name.Edit.FocusRectangle = false;
         this._name.Edit.AutoSelect = true;
         this._name.Edit.AutoHScroll = true;
         this._name.Font.FontFace = "Tahoma";
         this._name.Font.Height = -10;
         this._name.Font.Weight = 400;
         this._name.Font.FontFamily = "2";
         this._name.Font.Pitch = "2";
         this._name.Font.Charset = "0";
         this._name.Background.Mode = 1;
         this._name.Background.Color = "536870912";
         this._name.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.name_t, this._name });
         this.PopulateRadioButtons();
      }
   }

}