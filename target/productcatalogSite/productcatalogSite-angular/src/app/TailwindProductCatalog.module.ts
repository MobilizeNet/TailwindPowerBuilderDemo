
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as TailwindProductCatalog from './components/TailwindProductCatalog';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  TailwindProductCatalog.DProductbrandsComponent,
  TailwindProductCatalog.DProductbrandslistComponent,
  TailwindProductCatalog.DProductfeaturesComponent,
  TailwindProductCatalog.DProductitemsComponent,
  TailwindProductCatalog.DProductsearchComponent,
  TailwindProductCatalog.DProducttypelistComponent,
  TailwindProductCatalog.DProducttypesComponent,
  TailwindProductCatalog.DTagComponent,
  TailwindProductCatalog.DTagslistComponent,
  TailwindProductCatalog.WMainComponent,
  TailwindProductCatalog.WProductbrandsComponent,
  TailwindProductCatalog.WProductfeaturesComponent,
  TailwindProductCatalog.WProductitemsComponent,
  TailwindProductCatalog.WProductsearchComponent,
  TailwindProductCatalog.WProducttypesComponent,
  TailwindProductCatalog.WTagsComponent,
    ],
  declarations: [
  TailwindProductCatalog.DProductbrandsComponent,
  TailwindProductCatalog.DProductbrandslistComponent,
  TailwindProductCatalog.DProductfeaturesComponent,
  TailwindProductCatalog.DProductitemsComponent,
  TailwindProductCatalog.DProductsearchComponent,
  TailwindProductCatalog.DProducttypelistComponent,
  TailwindProductCatalog.DProducttypesComponent,
  TailwindProductCatalog.DTagComponent,
  TailwindProductCatalog.DTagslistComponent,
  TailwindProductCatalog.WMainComponent,
  TailwindProductCatalog.WProductbrandsComponent,
  TailwindProductCatalog.WProductfeaturesComponent,
  TailwindProductCatalog.WProductitemsComponent,
  TailwindProductCatalog.WProductsearchComponent,
  TailwindProductCatalog.WProducttypesComponent,
  TailwindProductCatalog.WTagsComponent,
    ],
  bootstrap: [
  TailwindProductCatalog.DProductbrandsComponent,
  TailwindProductCatalog.DProductbrandslistComponent,
  TailwindProductCatalog.DProductfeaturesComponent,
  TailwindProductCatalog.DProductitemsComponent,
  TailwindProductCatalog.DProductsearchComponent,
  TailwindProductCatalog.DProducttypelistComponent,
  TailwindProductCatalog.DProducttypesComponent,
  TailwindProductCatalog.DTagComponent,
  TailwindProductCatalog.DTagslistComponent,
  TailwindProductCatalog.WMainComponent,
  TailwindProductCatalog.WProductbrandsComponent,
  TailwindProductCatalog.WProductfeaturesComponent,
  TailwindProductCatalog.WProductitemsComponent,
  TailwindProductCatalog.WProductsearchComponent,
  TailwindProductCatalog.WProducttypesComponent,
  TailwindProductCatalog.WTagsComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TailwindProductCatalogModule { }

