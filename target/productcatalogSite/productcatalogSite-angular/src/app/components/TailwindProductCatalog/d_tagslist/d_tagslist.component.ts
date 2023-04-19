import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_tagslist",
   templateUrl : "d_tagslist.component.html",
   styleUrls : ["d_tagslist.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogd_tagslist"])
export class DTagslistComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      value : 0
   };
   headerTemplates = {
      value_t : 0
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}