import { Component } from '@angular/core';
import { BootstrapService } from './bootstrap.component.service';

@Component({
selector: 'bootstrap-app',
templateUrl: 'bootstrap.component.html',
styleUrls : ['bootstrap.component.css'],
providers: [BootstrapService]
})
export class BootstrapComponent {

}