import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './components/app.component';
import { MenuService } from './services/menuService';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule],
    declarations: [AppComponent],
    providers: [
        MenuService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }