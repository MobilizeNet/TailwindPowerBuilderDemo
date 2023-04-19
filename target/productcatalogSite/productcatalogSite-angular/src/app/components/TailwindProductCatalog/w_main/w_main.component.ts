import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-main",
   templateUrl : "w_main.component.html",
   styleUrls : ["w_main.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["tailwindproductcatalogw_main"])
export class WMainComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}