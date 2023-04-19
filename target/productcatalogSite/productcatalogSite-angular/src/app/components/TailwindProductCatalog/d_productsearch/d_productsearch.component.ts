import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_productsearch",
   templateUrl : "d_productsearch.component.html",
   styleUrls : ["d_productsearch.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogd_productsearch"])
export class DProductsearchComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      productfeatures_title : 0,
      productitems_name : 1,
      productitems_price : 2,
      productitems_imagename : 3,
      producttypes_code : 4,
      productbrands_brand : 5,
      producttypes_type : 6,
      tags_tag : 7,
      productitems_id : 8
   };
   headerTemplates = {
      productfeatures_title_t : 0,
      productitems_name_t : 1,
      productitems_price_t : 2,
      productitems_imagename_t : 3,
      producttypes_code_t : 4,
      productbrands_brand_t : 5,
      producttypes_type_t : 6,
      tags_tag_t : 7,
      productitems_id_t : 8
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}