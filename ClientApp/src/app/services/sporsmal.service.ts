import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Sporsmal } from 'src/models/sporsmal';
import { Kunde } from 'src/models/Kunde';


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

    saveSporsmal(sporsmal: Sporsmal) {
        return this._http.post(this.myAppUrl + 'api/sporsmal/Create', sporsmal)
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


    // For nye spørsmål sendt av kunder:

    GetKunde() {
        return this._http.get(this.myAppUrl + 'api/kunde/GetKunde').pipe(map(
            response => {
                return response;
            }));
    }

    GetKundeById(ID: number) {
        return this._http.get(this.myAppUrl + 'api/kunde/GetKundeById/' + ID)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    CreateKunde(kunde: Kunde) {
        return this._http.post(this.myAppUrl + 'api/kunde/CreateKunde', kunde)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    UpdateKunde(kunde: Kunde) {
        return this._http.put(this.myAppUrl + 'api/kunde/UpdateKunde', kunde)
            .pipe(map(
                response => {
                    return response;
                }));
    }

    SaveKunde(kunde: Kunde) {
        return this._http.post(this.myAppUrl + 'api/kunde/CreateKunde', kunde)
            .pipe(map(
                response => {
                    return response;
                }));
    }
}
