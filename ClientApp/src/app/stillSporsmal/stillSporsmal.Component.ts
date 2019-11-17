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
    KundeNr: number;
    errorMessage: any;

    constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute,
        private _sporsmalService: SporsmalService, private _router: Router) {
   

        this.kundeForm = this._fb.group({
            Navn: ['', [Validators.required]],
            Epost: ['', [Validators.required]],
            Sporsmal: ['', [Validators.required]],
        })
    }


    save() {
        if (!this.kundeForm.valid) {
            return;
        }
            this._sporsmalService.SaveKunde(this.kundeForm.value)
                .subscribe(() => {
                    // Feil navigate
                    this._router.navigate(['/nyeSporsmal']);
                }, error => console.error(error));
    }

    get Navn() { return this.kundeForm.get('Navn'); }
    get Epost() { return this.kundeForm.get('Epost'); }
    get Sporsmal() { return this.kundeForm.get('Sporsmal'); }

}
