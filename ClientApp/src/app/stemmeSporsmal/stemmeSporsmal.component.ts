import { Component } from '@angular/core';
import { SporsmalService } from '../services/sporsmal.service';
import { Sporsmal } from 'src/models/sporsmal';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-stemmeSporsmal',
    templateUrl: './stemmeSporsmal.component.html'
})
export class stemmeSporsmalComponent {

    //Endre litt?
    title = 'Recommend';
    sporsmalNr: number;
    errorMessage: any;

    constructor(private _sporsmalService: SporsmalService, private _avRoute: ActivatedRoute, private _router: Router)
    {

        if (this._avRoute.snapshot.params['id']) {
            this.sporsmalNr = this._avRoute.snapshot.params['id'];
            this.getSporsmalByNr(this.sporsmalNr);
        }
    }

    public sporsmal: Sporsmal;

    getSporsmalByNr(sporsmalNr) {

        this._sporsmalService.getSporsmalById(sporsmalNr).subscribe((response: Sporsmal) => {
            this.sporsmal = response;
        }, error => console.error(error));

    }

    saveAnbefaling() {
        
            this.sporsmal.totalStemmer += 1;
            this.sporsmal.totalOppStemmer += 1;
            this.sporsmal.sporsmalNr = this.sporsmal.sporsmalNr;
            this._sporsmalService.updateSporsmal(this.sporsmal)
                .subscribe(() => {
                    // Returne tilbake til FAQ-siden
                    this._router.navigate(['/FAQ']);
                }, error => console.error(error));
        

    }

    saveCount() {
        this.sporsmal.totalStemmer += 1;
        this.sporsmal.sporsmalNr = this.sporsmal.sporsmalNr;
        this._sporsmalService.updateSporsmal(this.sporsmal)
            .subscribe(() => {
                this._router.navigate(['/FAQ']);
            }, error => console.error(error));
    }

    cancel() {
        this._router.navigate(['/FAQ']);
    }

}
