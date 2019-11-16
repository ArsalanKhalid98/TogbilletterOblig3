import { Component } from '@angular/core';
import { SporsmalService } from '../services/sporsmal.service';
import { Sporsmal } from 'src/models/sporsmal';

@Component({
    selector: 'app-FAQ',
    templateUrl: './FAQ.component.html'
})
export class SporsmalComponent {

    public sporsmalList: Sporsmal[];

    constructor(private _sporsmalService: SporsmalService) {
        this.getSporsmal();
    }

    getSporsmal() {
        this._sporsmalService.getSporsmal().subscribe(
            (data: Sporsmal[]) => this.sporsmalList = data
        );
    }

    delete(ID) {
        const ans = confirm('Do you want to delete sporsmal with Id: ' + ID);
        if (ans) {
            this._sporsmalService.deleteSporsmal(ID).subscribe(() => {
                this.getSporsmal();
            }, error => console.error(error));
        }
    }
}
