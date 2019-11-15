import { Component } from '@angular/core';
import { Sporsmal } from 'src/models/Sporsmal';
import { SporsmalService } from '../services/sporsmal.service';

@Component({
    selector: 'app-FAQ',
    templateUrl: './FAQ.component.html'
})
export class SporsmalComponent {

    public sporsmalList: Sporsmal[];

    constructor(private _sporsmalService: SporsmalService) {
        this.getSporsmal();
    }

    getEmployees() {
        this._sporsmalService.getSporsmal().subscribe(
            (data: Sporsmal[]) => this.sporsmalList = data
        );
    }

    delete(sporsmalID) {
        const ans = confirm('Do you want to delete sporsmal with Id: ' + sporsmalID);
        if (ans) {
            this._sporsmalService.deleteSporsmal(sporsmalID).subscribe(() => {
                this.getSporsmal();
            }, error => console.error(error));
        }
    }
}
