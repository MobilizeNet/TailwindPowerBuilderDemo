#pragma warning disable
#line 1 "d_productfeatures\\d_productfeatures.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class d_productfeatures
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[8];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitemid_t) > 0)
            {
                yield return "productitemid_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitemid) > 0)
            {
                yield return "productitemid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_title_t) > 0)
            {
                yield return "title_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__title) > 0)
            {
                yield return "_title";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_t) > 0)
            {
                yield return "description_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description) > 0)
            {
                yield return "description";
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
                case "productitemid_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitemid_t) > 0;
                case "productitemid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitemid) > 0;
                case "title_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_title_t) > 0;
                case "_title":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__title) > 0;
                case "description_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_t) > 0;
                case "description":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["_id"] = _Mobilize_References[1];
            refs["productitemid_t"] = _Mobilize_References[2];
            refs["productitemid"] = _Mobilize_References[3];
            refs["title_t"] = _Mobilize_References[4];
            refs["_title"] = _Mobilize_References[5];
            refs["description_t"] = _Mobilize_References[6];
            refs["description"] = _Mobilize_References[7];
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
            var ref_productitemid_t = (Mobilize.WebMap.Common.Core.IObservable)this.productitemid_t;
            if (ref_productitemid_t != null)
                yield return ref_productitemid_t;
            var ref_productitemid = (Mobilize.WebMap.Common.Core.IObservable)this.productitemid;
            if (ref_productitemid != null)
                yield return ref_productitemid;
            var ref_title_t = (Mobilize.WebMap.Common.Core.IObservable)this.title_t;
            if (ref_title_t != null)
                yield return ref_title_t;
            var ref__title = (Mobilize.WebMap.Common.Core.IObservable)this._title;
            if (ref__title != null)
                yield return ref__title;
            var ref_description_t = (Mobilize.WebMap.Common.Core.IObservable)this.description_t;
            if (ref_description_t != null)
                yield return ref_description_t;
            var ref_description = (Mobilize.WebMap.Common.Core.IObservable)this.description;
            if (ref_description != null)
                yield return ref_description;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty__id = (uint)1 << 1;
        const uint _Mobilize_Loaded__id = (uint)1 << 1;
        const uint _Mobilize_Dirty_productitemid_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_productitemid_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_productitemid = (uint)1 << 3;
        const uint _Mobilize_Loaded_productitemid = (uint)1 << 3;
        const uint _Mobilize_Dirty_title_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_title_t = (uint)1 << 4;
        const uint _Mobilize_Dirty__title = (uint)1 << 5;
        const uint _Mobilize_Loaded__title = (uint)1 << 5;
        const uint _Mobilize_Dirty_description_t = (uint)1 << 6;
        const uint _Mobilize_Loaded_description_t = (uint)1 << 6;
        const uint _Mobilize_Dirty_description = (uint)1 << 7;
        const uint _Mobilize_Loaded_description = (uint)1 << 7;
#line 7
    }
}