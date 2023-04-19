#pragma warning disable
#line 1 "d_productitems\\d_productitems.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class d_productitems
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[14];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid) > 0)
            {
                yield return "brandid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid_t) > 0)
            {
                yield return "brandid_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_typeid_t) > 0)
            {
                yield return "typeid_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_typeid) > 0)
            {
                yield return "typeid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tagid) > 0)
            {
                yield return "tagid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tagid_t) > 0)
            {
                yield return "tagid_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0)
            {
                yield return "name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price_t) > 0)
            {
                yield return "price_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imagename) > 0)
            {
                yield return "imagename";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imagename_t) > 0)
            {
                yield return "imagename_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price) > 0)
            {
                yield return "price";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
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
                case "brandid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid) > 0;
                case "brandid_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid_t) > 0;
                case "typeid_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_typeid_t) > 0;
                case "typeid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_typeid) > 0;
                case "tagid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tagid) > 0;
                case "tagid_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tagid_t) > 0;
                case "name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0;
                case "price_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price_t) > 0;
                case "imagename":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imagename) > 0;
                case "imagename_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imagename_t) > 0;
                case "price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["_id"] = _Mobilize_References[1];
            refs["brandid"] = _Mobilize_References[2];
            refs["brandid_t"] = _Mobilize_References[3];
            refs["typeid_t"] = _Mobilize_References[4];
            refs["typeid"] = _Mobilize_References[5];
            refs["tagid"] = _Mobilize_References[6];
            refs["tagid_t"] = _Mobilize_References[7];
            refs["name_t"] = _Mobilize_References[8];
            refs["price_t"] = _Mobilize_References[9];
            refs["imagename"] = _Mobilize_References[10];
            refs["imagename_t"] = _Mobilize_References[11];
            refs["price"] = _Mobilize_References[12];
            refs["_name"] = _Mobilize_References[13];
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
            var ref_brandid = (Mobilize.WebMap.Common.Core.IObservable)this.brandid;
            if (ref_brandid != null)
                yield return ref_brandid;
            var ref_brandid_t = (Mobilize.WebMap.Common.Core.IObservable)this.brandid_t;
            if (ref_brandid_t != null)
                yield return ref_brandid_t;
            var ref_typeid_t = (Mobilize.WebMap.Common.Core.IObservable)this.typeid_t;
            if (ref_typeid_t != null)
                yield return ref_typeid_t;
            var ref_typeid = (Mobilize.WebMap.Common.Core.IObservable)this.typeid;
            if (ref_typeid != null)
                yield return ref_typeid;
            var ref_tagid = (Mobilize.WebMap.Common.Core.IObservable)this.tagid;
            if (ref_tagid != null)
                yield return ref_tagid;
            var ref_tagid_t = (Mobilize.WebMap.Common.Core.IObservable)this.tagid_t;
            if (ref_tagid_t != null)
                yield return ref_tagid_t;
            var ref_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_t;
            if (ref_name_t != null)
                yield return ref_name_t;
            var ref_price_t = (Mobilize.WebMap.Common.Core.IObservable)this.price_t;
            if (ref_price_t != null)
                yield return ref_price_t;
            var ref_imagename = (Mobilize.WebMap.Common.Core.IObservable)this.imagename;
            if (ref_imagename != null)
                yield return ref_imagename;
            var ref_imagename_t = (Mobilize.WebMap.Common.Core.IObservable)this.imagename_t;
            if (ref_imagename_t != null)
                yield return ref_imagename_t;
            var ref_price = (Mobilize.WebMap.Common.Core.IObservable)this.price;
            if (ref_price != null)
                yield return ref_price;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty__id = (uint)1 << 1;
        const uint _Mobilize_Loaded__id = (uint)1 << 1;
        const uint _Mobilize_Dirty_brandid = (uint)1 << 2;
        const uint _Mobilize_Loaded_brandid = (uint)1 << 2;
        const uint _Mobilize_Dirty_brandid_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_brandid_t = (uint)1 << 3;
        const uint _Mobilize_Dirty_typeid_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_typeid_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_typeid = (uint)1 << 5;
        const uint _Mobilize_Loaded_typeid = (uint)1 << 5;
        const uint _Mobilize_Dirty_tagid = (uint)1 << 6;
        const uint _Mobilize_Loaded_tagid = (uint)1 << 6;
        const uint _Mobilize_Dirty_tagid_t = (uint)1 << 7;
        const uint _Mobilize_Loaded_tagid_t = (uint)1 << 7;
        const uint _Mobilize_Dirty_name_t = (uint)1 << 8;
        const uint _Mobilize_Loaded_name_t = (uint)1 << 8;
        const uint _Mobilize_Dirty_price_t = (uint)1 << 9;
        const uint _Mobilize_Loaded_price_t = (uint)1 << 9;
        const uint _Mobilize_Dirty_imagename = (uint)1 << 10;
        const uint _Mobilize_Loaded_imagename = (uint)1 << 10;
        const uint _Mobilize_Dirty_imagename_t = (uint)1 << 11;
        const uint _Mobilize_Loaded_imagename_t = (uint)1 << 11;
        const uint _Mobilize_Dirty_price = (uint)1 << 12;
        const uint _Mobilize_Loaded_price = (uint)1 << 12;
        const uint _Mobilize_Dirty__name = (uint)1 << 13;
        const uint _Mobilize_Loaded__name = (uint)1 << 13;
#line 7
    }
}