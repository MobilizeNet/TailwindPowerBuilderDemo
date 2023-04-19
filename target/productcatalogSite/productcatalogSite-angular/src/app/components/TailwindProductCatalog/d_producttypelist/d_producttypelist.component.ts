import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_producttypelist",
   templateUrl : "d_producttypelist.component.html",
   styleUrls : ["d_producttypelist.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogd_producttypelist"])
export class DProducttypelistComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      name : 0,
      code : 1
   };
   headerTemplates = {
      name_t : 0,
      code_t : 1
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}