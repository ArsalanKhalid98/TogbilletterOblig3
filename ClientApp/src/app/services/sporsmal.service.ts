import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Sporsmal } from 'src/Models/Sporsmal';


@Injectable({
    providedIn: 'root'
})
export class SporsmalService {

    myAppUrl = '';

    constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.myAppUrl = baseUrl;
    }

    

    getSporsmal() {
        return this._http.get(this.myAppUrl + 'api/sporsmal/getSporsmal').pipe(map(
            response => {
                return response;
            }));
    }

    getSporsmalById(ID: number) {
        return this._http.get(this.myAppUrl + 'api/sporsmal/getSporsmalById/' + ID)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    Create(sporsmal: Sporsmal) {
        return this._http.post(this.myAppUrl + 'api/sporsmal/Create', sporsmal)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    updateSporsmal(sporsmal: Sporsmal) {
        return this._http.put(this.myAppUrl + 'api/sporsmal/Update', sporsmal)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    deleteSporsmal(ID: number) {
        return this._http.delete(this.myAppUrl + 'api/sporsmal/Delete/' + ID)
            .pipe(map(
                response => {
                    return response;
                }));
    }
}
