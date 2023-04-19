namespace tailwindproductcatalog
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_producttypelist
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText code_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn code { get; set; }


      public d_producttypelist()
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
         this.Header.Height = 108;
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
         id_db1.DbName = "producttypes.id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         name_db2.Update = true;
         name_db2.UpdateWhereClause = false;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "producttypes.name";
         var code_db3 = new Mobilize.Web.DB.Column();
         code_db3.Type = Mobilize.Web.CaseExtensions.String("char(450)");
         code_db3.Update = true;
         code_db3.UpdateWhereClause = true;
         code_db3.Name = Mobilize.Web.CaseExtensions.String("code");
         code_db3.DbName = "producttypes.code";
         this.RetrieveStatement = "PBSELECT(TABLE(NAME=\"producttypes\") COLUMN(NAME=\"producttypes.id\")COLUMN(NAME=\"producttypes.name\")COLUMN(NAME=\"producttypes.code\"))";
         this.UpdateTableName = "producttypes";
         this.UpdateWhere = 1;
         this.UpdateKeyInPlace = false;
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.name_t.Alignment = 2;
         this.name_t.Text = "Name";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 9;
         this.name_t.Y = 8;
         this.name_t.Height = 64;
         this.name_t.Width = 1161;
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
         this.code_t = new Mobilize.Web.DmText();
         this.code_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.code_t.Alignment = 2;
         this.code_t.Text = "Code";
         this.code_t.Border = 0;
         this.code_t.Color = "33554432";
         this.code_t.X = 1179;
         this.code_t.Y = 8;
         this.code_t.Height = 64;
         this.code_t.Width = 498;
         this.code_t.Name = Mobilize.Web.CaseExtensions.String("code_t");
         this.code_t.Visible = true;
         this.code_t.Font.FontFace = "Tahoma";
         this.code_t.Font.Height = -10;
         this.code_t.Font.Weight = 400;
         this.code_t.Font.FontFamily = "2";
         this.code_t.Font.Pitch = "2";
         this.code_t.Font.Charset = "0";
         this.code_t.Background.Mode = 1;
         this.code_t.Background.Color = "536870912";
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 10;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 9;
         this._name.Y = 8;
         this._name.Height = 76;
         this._name.Width = 1161;
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
         this.code = new Mobilize.Web.DmColumn();
         this.code.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.code.Id = 3;
         this.code.Alignment = 0;
         this.code.TabSequence = 20;
         this.code.Border = 0;
         this.code.Color = "33554432";
         this.code.X = 1179;
         this.code.Y = 8;
         this.code.Height = 76;
         this.code.Width = "498\t500";
         this.code.Format = "[general]";
         this.code.Name = Mobilize.Web.CaseExtensions.String("code");
         this.code.Visible = true;
         this.code.Edit.Limit = 450;
         this.code.Edit.Case = "any";
         this.code.Edit.FocusRectangle = false;
         this.code.Edit.AutoSelect = true;
         this.code.Edit.AutoHScroll = true;
         this.code.Font.FontFace = "Tahoma";
         this.code.Font.Height = -10;
         this.code.Font.Weight = 400;
         this.code.Font.FontFamily = "2";
         this.code.Font.Pitch = "2";
         this.code.Font.Charset = "0";
         this.code.Background.Mode = 1;
         this.code.Background.Color = "536870912";
         this.code.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, code_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.name_t, this.code_t, this._name, this.code });
         this.PopulateRadioButtons();
      }
   }

}