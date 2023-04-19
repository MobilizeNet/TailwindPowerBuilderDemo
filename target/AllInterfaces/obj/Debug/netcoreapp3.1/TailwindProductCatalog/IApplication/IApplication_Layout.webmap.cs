#pragma warning disable
#line 1 "TailwindProductCatalog\\IApplication\\IApplication_Layout.cs"
#pragma warning disable
#line 1 "TailwindProductCatalog\\IApplication\\IApplication_Layout.cs"
namespace tailwindproductcatalog
{

   public interface IApplication
      : Mobilize.Web.IApplication
   {

      void DoWmInit();

      int? OpenWindow(string commandline);

      void Create();

      void Destroy();

   }

}
#pragma warning restore
