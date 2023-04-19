import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-productitems",
   templateUrl : "w_productitems.component.html",
   styleUrls : ["w_productitems.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogw_productitems"])
export class WProductitemsComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}