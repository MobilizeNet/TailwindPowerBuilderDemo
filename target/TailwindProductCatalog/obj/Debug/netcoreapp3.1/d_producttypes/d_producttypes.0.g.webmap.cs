#pragma warning disable
#line 1 "d_producttypes\\d_producttypes.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class d_producttypes
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[6];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0)
            {
                yield return "name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code_t) > 0)
            {
                yield return "code_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code) > 0)
            {
                yield return "code";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
                case "name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "code_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code_t) > 0;
                case "code":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["_id"] = _Mobilize_References[1];
            refs["name_t"] = _Mobilize_References[2];
            refs["_name"] = _Mobilize_References[3];
            refs["code_t"] = _Mobilize_References[4];
            refs["code"] = _Mobilize_References[5];
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
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            var ref_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_t;
            if (ref_name_t != null)
                yield return ref_name_t;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_code_t = (Mobilize.WebMap.Common.Core.IObservable)this.code_t;
            if (ref_code_t != null)
                yield return ref_code_t;
            var ref_code = (Mobilize.WebMap.Common.Core.IObservable)this.code;
            if (ref_code != null)
                yield return ref_code;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty__id = (uint)1 << 1;
        const uint _Mobilize_Loaded__id = (uint)1 << 1;
        const uint _Mobilize_Dirty_name_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_name_t = (uint)1 << 2;
        const uint _Mobilize_Dirty__name = (uint)1 << 3;
        const uint _Mobilize_Loaded__name = (uint)1 << 3;
        const uint _Mobilize_Dirty_code_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_code_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_code = (uint)1 << 5;
        const uint _Mobilize_Loaded_code = (uint)1 << 5;
#line 7
    }
}