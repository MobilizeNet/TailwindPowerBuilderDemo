#pragma warning disable
#line 1 "d_productsearch\\d_productsearch.cs"
#line hidden
namespace tailwindproductcatalog
{
    public partial class d_productsearch
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[18];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productfeatures_title_t) > 0)
            {
                yield return "productfeatures_title_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_name_t) > 0)
            {
                yield return "productitems_name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_price_t) > 0)
            {
                yield return "productitems_price_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_imagename_t) > 0)
            {
                yield return "productitems_imagename_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_code_t) > 0)
            {
                yield return "producttypes_code_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productbrands_brand_t) > 0)
            {
                yield return "productbrands_brand_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_type_t) > 0)
            {
                yield return "producttypes_type_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tags_tag_t) > 0)
            {
                yield return "tags_tag_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productfeatures_title) > 0)
            {
                yield return "productfeatures_title";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_name) > 0)
            {
                yield return "productitems_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_price) > 0)
            {
                yield return "productitems_price";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_imagename) > 0)
            {
                yield return "productitems_imagename";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_code) > 0)
            {
                yield return "producttypes_code";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productbrands_brand) > 0)
            {
                yield return "productbrands_brand";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_type) > 0)
            {
                yield return "producttypes_type";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tags_tag) > 0)
            {
                yield return "tags_tag";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_id) > 0)
            {
                yield return "productitems_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_id_t) > 0)
            {
                yield return "productitems_id_t";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "productfeatures_title_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productfeatures_title_t) > 0;
                case "productitems_name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_name_t) > 0;
                case "productitems_price_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_price_t) > 0;
                case "productitems_imagename_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_imagename_t) > 0;
                case "producttypes_code_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_code_t) > 0;
                case "productbrands_brand_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productbrands_brand_t) > 0;
                case "producttypes_type_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_type_t) > 0;
                case "tags_tag_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tags_tag_t) > 0;
                case "productfeatures_title":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productfeatures_title) > 0;
                case "productitems_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_name) > 0;
                case "productitems_price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_price) > 0;
                case "productitems_imagename":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_imagename) > 0;
                case "producttypes_code":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_code) > 0;
                case "productbrands_brand":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productbrands_brand) > 0;
                case "producttypes_type":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_producttypes_type) > 0;
                case "tags_tag":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tags_tag) > 0;
                case "productitems_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_id) > 0;
                case "productitems_id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productitems_id_t) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["productfeatures_title_t"] = _Mobilize_References[0];
            refs["productitems_name_t"] = _Mobilize_References[1];
            refs["productitems_price_t"] = _Mobilize_References[2];
            refs["productitems_imagename_t"] = _Mobilize_References[3];
            refs["producttypes_code_t"] = _Mobilize_References[4];
            refs["productbrands_brand_t"] = _Mobilize_References[5];
            refs["producttypes_type_t"] = _Mobilize_References[6];
            refs["tags_tag_t"] = _Mobilize_References[7];
            refs["productfeatures_title"] = _Mobilize_References[8];
            refs["productitems_name"] = _Mobilize_References[9];
            refs["productitems_price"] = _Mobilize_References[10];
            refs["productitems_imagename"] = _Mobilize_References[11];
            refs["producttypes_code"] = _Mobilize_References[12];
            refs["productbrands_brand"] = _Mobilize_References[13];
            refs["producttypes_type"] = _Mobilize_References[14];
            refs["tags_tag"] = _Mobilize_References[15];
            refs["productitems_id"] = _Mobilize_References[16];
            refs["productitems_id_t"] = _Mobilize_References[17];
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

            var ref_productfeatures_title_t = (Mobilize.WebMap.Common.Core.IObservable)this.productfeatures_title_t;
            if (ref_productfeatures_title_t != null)
                yield return ref_productfeatures_title_t;
            var ref_productitems_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_name_t;
            if (ref_productitems_name_t != null)
                yield return ref_productitems_name_t;
            var ref_productitems_price_t = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_price_t;
            if (ref_productitems_price_t != null)
                yield return ref_productitems_price_t;
            var ref_productitems_imagename_t = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_imagename_t;
            if (ref_productitems_imagename_t != null)
                yield return ref_productitems_imagename_t;
            var ref_producttypes_code_t = (Mobilize.WebMap.Common.Core.IObservable)this.producttypes_code_t;
            if (ref_producttypes_code_t != null)
                yield return ref_producttypes_code_t;
            var ref_productbrands_brand_t = (Mobilize.WebMap.Common.Core.IObservable)this.productbrands_brand_t;
            if (ref_productbrands_brand_t != null)
                yield return ref_productbrands_brand_t;
            var ref_producttypes_type_t = (Mobilize.WebMap.Common.Core.IObservable)this.producttypes_type_t;
            if (ref_producttypes_type_t != null)
                yield return ref_producttypes_type_t;
            var ref_tags_tag_t = (Mobilize.WebMap.Common.Core.IObservable)this.tags_tag_t;
            if (ref_tags_tag_t != null)
                yield return ref_tags_tag_t;
            var ref_productfeatures_title = (Mobilize.WebMap.Common.Core.IObservable)this.productfeatures_title;
            if (ref_productfeatures_title != null)
                yield return ref_productfeatures_title;
            var ref_productitems_name = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_name;
            if (ref_productitems_name != null)
                yield return ref_productitems_name;
            var ref_productitems_price = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_price;
            if (ref_productitems_price != null)
                yield return ref_productitems_price;
            var ref_productitems_imagename = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_imagename;
            if (ref_productitems_imagename != null)
                yield return ref_productitems_imagename;
            var ref_producttypes_code = (Mobilize.WebMap.Common.Core.IObservable)this.producttypes_code;
            if (ref_producttypes_code != null)
                yield return ref_producttypes_code;
            var ref_productbrands_brand = (Mobilize.WebMap.Common.Core.IObservable)this.productbrands_brand;
            if (ref_productbrands_brand != null)
                yield return ref_productbrands_brand;
            var ref_producttypes_type = (Mobilize.WebMap.Common.Core.IObservable)this.producttypes_type;
            if (ref_producttypes_type != null)
                yield return ref_producttypes_type;
            var ref_tags_tag = (Mobilize.WebMap.Common.Core.IObservable)this.tags_tag;
            if (ref_tags_tag != null)
                yield return ref_tags_tag;
            var ref_productitems_id = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_id;
            if (ref_productitems_id != null)
                yield return ref_productitems_id;
            var ref_productitems_id_t = (Mobilize.WebMap.Common.Core.IObservable)this.productitems_id_t;
            if (ref_productitems_id_t != null)
                yield return ref_productitems_id_t;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_productfeatures_title_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_productfeatures_title_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_productitems_name_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_productitems_name_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_productitems_price_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_productitems_price_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_productitems_imagename_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_productitems_imagename_t = (uint)1 << 3;
        const uint _Mobilize_Dirty_producttypes_code_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_producttypes_code_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_productbrands_brand_t = (uint)1 << 5;
        const uint _Mobilize_Loaded_productbrands_brand_t = (uint)1 << 5;
        const uint _Mobilize_Dirty_producttypes_type_t = (uint)1 << 6;
        const uint _Mobilize_Loaded_producttypes_type_t = (uint)1 << 6;
        const uint _Mobilize_Dirty_tags_tag_t = (uint)1 << 7;
        const uint _Mobilize_Loaded_tags_tag_t = (uint)1 << 7;
        const uint _Mobilize_Dirty_productfeatures_title = (uint)1 << 8;
        const uint _Mobilize_Loaded_productfeatures_title = (uint)1 << 8;
        const uint _Mobilize_Dirty_productitems_name = (uint)1 << 9;
        const uint _Mobilize_Loaded_productitems_name = (uint)1 << 9;
        const uint _Mobilize_Dirty_productitems_price = (uint)1 << 10;
        const uint _Mobilize_Loaded_productitems_price = (uint)1 << 10;
        const uint _Mobilize_Dirty_productitems_imagename = (uint)1 << 11;
        const uint _Mobilize_Loaded_productitems_imagename = (uint)1 << 11;
        const uint _Mobilize_Dirty_producttypes_code = (uint)1 << 12;
        const uint _Mobilize_Loaded_producttypes_code = (uint)1 << 12;
        const uint _Mobilize_Dirty_productbrands_brand = (uint)1 << 13;
        const uint _Mobilize_Loaded_productbrands_brand = (uint)1 << 13;
        const uint _Mobilize_Dirty_producttypes_type = (uint)1 << 14;
        const uint _Mobilize_Loaded_producttypes_type = (uint)1 << 14;
        const uint _Mobilize_Dirty_tags_tag = (uint)1 << 15;
        const uint _Mobilize_Loaded_tags_tag = (uint)1 << 15;
        const uint _Mobilize_Dirty_productitems_id = (uint)1 << 16;
        const uint _Mobilize_Loaded_productitems_id = (uint)1 << 16;
        const uint _Mobilize_Dirty_productitems_id_t = (uint)1 << 17;
        const uint _Mobilize_Loaded_productitems_id_t = (uint)1 << 17;
#line 7
    }
}