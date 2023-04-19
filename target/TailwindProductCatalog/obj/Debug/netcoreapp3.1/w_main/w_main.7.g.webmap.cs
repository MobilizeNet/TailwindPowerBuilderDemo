#pragma warning disable
#line 1 "w_main\\w_main.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class w_main
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[7];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_search) > 0)
            {
                yield return "cb_search";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productfeatures) > 0)
            {
                yield return "cb_productfeatures";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_producttypes) > 0)
            {
                yield return "cb_producttypes";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productbrands) > 0)
            {
                yield return "cb_productbrands";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productitems) > 0)
            {
                yield return "cb_productitems";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_tags_window) > 0)
            {
                yield return "cb_tags_window";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_p_1) > 0)
            {
                yield return "p_1";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_search":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_search) > 0;
                case "cb_productfeatures":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productfeatures) > 0;
                case "cb_producttypes":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_producttypes) > 0;
                case "cb_productbrands":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productbrands) > 0;
                case "cb_productitems":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_productitems) > 0;
                case "cb_tags_window":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_tags_window) > 0;
                case "p_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_p_1) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_search"] = _Mobilize_References[0];
            refs["cb_productfeatures"] = _Mobilize_References[1];
            refs["cb_producttypes"] = _Mobilize_References[2];
            refs["cb_productbrands"] = _Mobilize_References[3];
            refs["cb_productitems"] = _Mobilize_References[4];
            refs["cb_tags_window"] = _Mobilize_References[5];
            refs["p_1"] = _Mobilize_References[6];
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

            var ref_cb_search = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_search);
            if (ref_cb_search != null)
                yield return ref_cb_search;
            var ref_cb_productfeatures = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_productfeatures);
            if (ref_cb_productfeatures != null)
                yield return ref_cb_productfeatures;
            var ref_cb_producttypes = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_producttypes);
            if (ref_cb_producttypes != null)
                yield return ref_cb_producttypes;
            var ref_cb_productbrands = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_productbrands);
            if (ref_cb_productbrands != null)
                yield return ref_cb_productbrands;
            var ref_cb_productitems = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_productitems);
            if (ref_cb_productitems != null)
                yield return ref_cb_productitems;
            var ref_cb_tags_window = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_tags_window);
            if (ref_cb_tags_window != null)
                yield return ref_cb_tags_window;
            var ref_p_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.p_1);
            if (ref_p_1 != null)
                yield return ref_p_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_search = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_search = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_productfeatures = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_productfeatures = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_producttypes = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_producttypes = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_productbrands = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_productbrands = (uint)1 << 3;
        const uint _Mobilize_Dirty_cb_productitems = (uint)1 << 4;
        const uint _Mobilize_Loaded_cb_productitems = (uint)1 << 4;
        const uint _Mobilize_Dirty_cb_tags_window = (uint)1 << 5;
        const uint _Mobilize_Loaded_cb_tags_window = (uint)1 << 5;
        const uint _Mobilize_Dirty_p_1 = (uint)1 << 6;
        const uint _Mobilize_Loaded_p_1 = (uint)1 << 6;
#line 7
    }
}