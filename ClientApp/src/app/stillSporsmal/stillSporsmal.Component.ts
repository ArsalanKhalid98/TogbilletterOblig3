import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators, ReactiveFormsModule  } from '@angular/forms';
import { SporsmalService } from '../services/sporsmal.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Kunde } from 'src/models/Kunde';


@Component({
    selector: 'app-stillSporsmal',
    templateUrl: './stillSporsmal.component.html'
})
export class stillSporsmalComponent {

    kundeForm: FormGroup;
    title = "Create";
    KundeNr: number;
    errorMessage: any;

    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute,
        private _sporsmalService: SporsmalService, private _router: Router) {
        if (this._avRoute.snapshot.params['ID']) {
            this.KundeNr = this._avRoute.snapshot.params['ID'];
        }

        this.kundeForm = this._fb.group({
            KundeNr: 0,
            Navn: ['', [Validators.required]],
            Epost: ['', [Validators.required]],
            Sporsmal: ['', [Validators.required]],
        })
    }

    ngOnInit() {
        

        if (this.KundeNr > 0) {
            this.title = 'Edit';
            this._sporsmalService.GetKundeById(this.KundeNr)
                .subscribe((response: Kunde) => {
                    this.kundeForm.setValue(response);
                }, error => console.error(error));
        }
    }

    save() {

        if (!this.kundeForm.valid) {
            return;
        }

        if (this.title === 'Create') {
            this._sporsmalService.SaveKunde(this.kundeForm.value)
                .subscribe(() => {
                    // Feil navigate
                    this._router.navigate(['/FAQ']);
                }, error => console.error(error));
        } else if (this.title === 'Edit') {
            this._sporsmalService.UpdateKunde(this.kundeForm.value)
                .subscribe(() => {
                    // Feil navigate
                    this._router.navigate(['/FAQ']);
                }, error => console.error(error));
        }
    }

    get Navn() { return this.kundeForm.get('Navn'); }
    get Epost() { return this.kundeForm.get('Epost'); }
    get Sporsmal() { return this.kundeForm.get('Sporsmal'); }

}
