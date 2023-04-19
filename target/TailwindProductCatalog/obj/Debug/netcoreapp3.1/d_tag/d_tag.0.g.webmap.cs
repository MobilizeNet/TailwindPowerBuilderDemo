#pragma warning disable
#line 1 "d_tag\\d_tag.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class d_tag
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0)
            {
                yield return "id_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_value_t) > 0)
            {
                yield return "value_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_value) > 0)
            {
                yield return "value";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "value_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_value_t) > 0;
                case "value":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_value) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["value_t"] = _Mobilize_References[1];
            refs["value"] = _Mobilize_References[2];
            refs["_id"] = _Mobilize_References[3];
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

            var ref_id_t = (Mobilize.WebMap.Common.Core.IObservable)this.id_t;
            if (ref_id_t != null)
                yield return ref_id_t;
            var ref_value_t = (Mobilize.WebMap.Common.Core.IObservable)this.value_t;
            if (ref_value_t != null)
                yield return ref_value_t;
            var ref_value = (Mobilize.WebMap.Common.Core.IObservable)this.value;
            if (ref_value != null)
                yield return ref_value;
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_value_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_value_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_value = (uint)1 << 2;
        const uint _Mobilize_Loaded_value = (uint)1 << 2;
        const uint _Mobilize_Dirty__id = (uint)1 << 3;
        const uint _Mobilize_Loaded__id = (uint)1 << 3;
#line 7
    }
}