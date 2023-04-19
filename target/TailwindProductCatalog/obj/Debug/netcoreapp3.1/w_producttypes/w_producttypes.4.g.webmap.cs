#pragma warning disable
#line 1 "w_producttypes\\w_producttypes.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class w_producttypes
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_next) > 0)
            {
                yield return "cb_next";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_prev) > 0)
            {
                yield return "cb_prev";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_update) > 0)
            {
                yield return "cb_update";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_producttypes) > 0)
            {
                yield return "dw_producttypes";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_next":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_next) > 0;
                case "cb_prev":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_prev) > 0;
                case "cb_update":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_update) > 0;
                case "dw_producttypes":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_producttypes) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_next"] = _Mobilize_References[0];
            refs["cb_prev"] = _Mobilize_References[1];
            refs["cb_update"] = _Mobilize_References[2];
            refs["dw_producttypes"] = _Mobilize_References[3];
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

            var ref_cb_next = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_next);
            if (ref_cb_next != null)
                yield return ref_cb_next;
            var ref_cb_prev = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_prev);
            if (ref_cb_prev != null)
                yield return ref_cb_prev;
            var ref_cb_update = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_update);
            if (ref_cb_update != null)
                yield return ref_cb_update;
            var ref_dw_producttypes = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_producttypes);
            if (ref_dw_producttypes != null)
                yield return ref_dw_producttypes;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_next = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_next = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_prev = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_prev = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_update = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_update = (uint)1 << 2;
        const uint _Mobilize_Dirty_dw_producttypes = (uint)1 << 3;
        const uint _Mobilize_Loaded_dw_producttypes = (uint)1 << 3;
#line 7
    }
}