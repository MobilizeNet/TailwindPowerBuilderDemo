import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AppComponent } from './app.component';
import { RootComponent } from './root.component';
import { AppRoutingModule } from './app-routing.module';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapModule, WebMapService, WEBMAP_CONFIG, WebMapServiceConfig } from '@mobilize/angularclient';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { HttpClientXsrfModule } from '@angular/common/http';
import { TailwindProductCatalogModule } from './TailwindProductCatalog.module';
const config: WebMapServiceConfig = {
  useDynamicServerEvents: true,
  webMapVersion: 'v5',
  usePercentage: false,
  useBundleEvent: true,
  showBrowserContextMenu: true,
  baseHref: '',
  dataManagerBusyLoaderTime: 0,
  wmSourceVersion: 'PB',
  styleProperties:[],
};

@NgModule({
declarations: [
AppComponent,
RootComponent
],
imports: [
	HttpClientXsrfModule.withOptions({
		cookieName: "tailwindproductcatalog-Xsrf-Cookie",
		headerName: "tailwindproductcatalog-Xsrf-Header",
	}),
BrowserModule,
WebMapModule,
AppRoutingModule,
BaseComponentsModule,
PowerComponentsModule,
TailwindProductCatalogModule,
],
providers: [WebMapService, { provide: WEBMAP_CONFIG, useValue: config }
],
bootstrap: [AppComponent],
schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }

