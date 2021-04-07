import { Component } from '@angular/core';
import { StringService } from './string.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'simbirsoft-app';

  pageUrl = null;
  constructor(private stringService: StringService) {}

  public submit(){
    this.stringService.getString(this.pageUrl).subscribe(x => {});
    this.pageUrl = "";
  }
}
