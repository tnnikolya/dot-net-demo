import { Component } from '@angular/core';
import { slideInAnimation } from '../animation';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'dot-net-demo-app-root',
  templateUrl: './dotNetDemoApp.component.html',
  styleUrls: ['./dotNetDemoApp.component.scss'],
  animations: [
    slideInAnimation
  ]
})
export class DotNetDemoAppComponent {
  prepareRoute(outlet: RouterOutlet) {
    return outlet && outlet.activatedRouteData && outlet.activatedRouteData['animation'];
  }
}
