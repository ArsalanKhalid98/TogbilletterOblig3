import { Component } from '@angular/core';
import { SporsmalService } from '../services/sporsmal.service';
import { Kunde } from 'src/models/kunde';

@Component({
    selector: 'app-nyeSporsmal',
    templateUrl: './nyeSporsmal.component.html'
})
export class nyeSporsmalComponent {

    public kundeList: Kunde[];

    constructor(private _sporsmalService: SporsmalService) {
        this.GetKunde();
    }

    GetKunde() {
        this._sporsmalService.GetKunde().subscribe(
            (data: Kunde[]) => this.kundeList = data
        );
    }

}
