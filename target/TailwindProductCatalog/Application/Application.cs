namespace tailwindproductcatalog
{

   public class Application
      : Mobilize.Web.Application, tailwindproductcatalog.IApplication
   {

      public Application(System.IServiceProvider provider)
      : base(provider)
      {
         this.AppName = "productcatalog";
      }

      public void DoWmInit()
      {
      }

      public virtual int? OpenWindow(string commandline)
      { // Profile Tailwind

         Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_main<tailwindproductcatalog.Iw_main>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_main = (tailwindproductcatalog.Iw_main)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_main<tailwindproductcatalog.Iw_main>()));
         return null;
      }

      public override void Create()
      {
         this.AppName = "productcatalog";
         Mobilize.Web.Application.CurrentApplication.Variables.Message = Mobilize.Web.Application.Create<Mobilize.Web.IMessage>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = Mobilize.Web.Application.Create<Mobilize.Web.ITransaction>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicDescriptionArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicStagingArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.Error = Mobilize.Web.Application.Create<Mobilize.Web.IError>();
      }

      public override void Destroy()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Error = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Message = null;
      }

   }

}