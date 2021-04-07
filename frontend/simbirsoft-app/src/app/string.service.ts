import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StringService {

  constructor(private http: HttpClient) { }
  public getString(page: string): Observable<any>{
    console.log(page);

    const headers = new HttpHeaders().set('Content-Type','application/json');
    return this.http.post(environment.API + 'api/pageitems', JSON.stringify(page), {headers:headers});

  }
}
export class PageModel{
  public page: string
}
