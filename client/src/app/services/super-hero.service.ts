import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {
  private url ="SuperHero";

  constructor(private http: HttpClient) { }

  public getSuperHeroes() : Observable<SuperHero[]>{
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}`);
  }
  public updateHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.put<SuperHero[]>(
      `${environment.apiUrl}/${this.url}`,hero);
  }
  public createHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.post<SuperHero[]>(
      `${environment.apiUrl}/${this.url}`,hero);
  }
  public deleteHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.delete<SuperHero[]>(`${environment.apiUrl}/${this.url}/${hero.id}`);
  }
  public idHero(hero: SuperHero) : Observable<SuperHero[]>{
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}/${hero.id}`);
  }
}
