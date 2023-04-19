#pragma warning disable
#line 1 "w_productsearch\\w_productsearch.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class w_productsearch
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[4];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_productsearch) > 0)
            {
                yield return "dw_productsearch";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_instructions) > 0)
            {
                yield return "st_instructions";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_keyword) > 0)
            {
                yield return "sle_keyword";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_search) > 0)
            {
                yield return "cb_search";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "dw_productsearch":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_productsearch) > 0;
                case "st_instructions":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_instructions) > 0;
                case "sle_keyword":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_keyword) > 0;
                case "cb_search":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_search) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["dw_productsearch"] = _Mobilize_References[0];
            refs["st_instructions"] = _Mobilize_References[1];
            refs["sle_keyword"] = _Mobilize_References[2];
            refs["cb_search"] = _Mobilize_References[3];
            return refs;
        }

        protected override void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_LoadedFlag_0 = 0;
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

            var ref_dw_productsearch = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_productsearch);
            if (ref_dw_productsearch != null)
                yield return ref_dw_productsearch;
            var ref_st_instructions = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_instructions);
            if (ref_st_instructions != null)
                yield return ref_st_instructions;
            var ref_sle_keyword = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.sle_keyword);
            if (ref_sle_keyword != null)
                yield return ref_sle_keyword;
            var ref_cb_search = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_search);
            if (ref_cb_search != null)
                yield return ref_cb_search;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_dw_productsearch = (uint)1 << 0;
        const uint _Mobilize_Loaded_dw_productsearch = (uint)1 << 0;
        const uint _Mobilize_Dirty_st_instructions = (uint)1 << 1;
        const uint _Mobilize_Loaded_st_instructions = (uint)1 << 1;
        const uint _Mobilize_Dirty_sle_keyword = (uint)1 << 2;
        const uint _Mobilize_Loaded_sle_keyword = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_search = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_search = (uint)1 << 3;
#line 7
    }
}