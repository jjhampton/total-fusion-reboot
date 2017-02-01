import { Component, OnInit } from '@angular/core';
import { MenuService, IMenuItem } from '../services/menuService';

@Component({
    selector: 'my-app',
    template: `
    <h1>Total Fusion Menu</h1>
    <ul>
        <li *ngFor="let item of menuItems">
            <strong>{{item.name}}</strong><br>
            {{item.description}}
            Price: {{item.price}}<br>
        </li>
    </ul>
    `,
    providers: [
        MenuService
    ]
})
export class AppComponent extends OnInit {

    constructor(private _service: MenuService) {
        super();
    }

    ngOnInit() {
        this._service.loadData()
            .then(data => {
                this.menuItems = data;
            });
    }

    menuItems: IMenuItem[] = [];
}