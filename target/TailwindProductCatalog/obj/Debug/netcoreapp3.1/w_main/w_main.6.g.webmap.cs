#pragma warning disable
#line 1 "w_main\\w_main.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class w_main : Mobilize.Web.Window, tailwindproductcatalog.Iw_main
    {
        public partial class p_1_type
        {
#line hidden
            protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
            {
                foreach (var item in base._Mobilize_GetChanges())
                {
                    yield return item;
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                return refs;
            }

            protected override void _Mobilize_CleanChanges()
            {
                if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
                {
                    this._Mobilize_ControlFlag = 0;
                }

                base._Mobilize_CleanChanges();
            }

            protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
            {
                foreach (var baseRef in base._Mobilize_GetReferences())
                {
                    yield return baseRef;
                }

                yield break;
            }
#line 318
        }
    }
}