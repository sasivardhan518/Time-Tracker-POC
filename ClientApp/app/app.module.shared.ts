import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { BootstrapComponent } from './components/bootstrap/bootstrap.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        BootstrapComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'bootstrap-app', component: BootstrapComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers:[
    ]
})
export class AppModuleShared {
}
