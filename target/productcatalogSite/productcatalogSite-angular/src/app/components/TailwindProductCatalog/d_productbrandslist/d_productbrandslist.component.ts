import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_productbrandslist",
   templateUrl : "d_productbrandslist.component.html",
   styleUrls : ["d_productbrandslist.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogd_productbrandslist"])
export class DProductbrandslistComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      name : 0
   };
   headerTemplates = {
      name_t : 0
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}