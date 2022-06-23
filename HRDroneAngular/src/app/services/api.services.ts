import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class ApiService {
    public static APIUrl: string = 'https://localhost:7154/';

    constructor(private http: HttpClient, private router: Router) { }

    public GET(path: string): Observable<any> {
        console.log(`${ApiService.APIUrl}${path}`);
        return this.http.get(`${ApiService.APIUrl}${path}`, { headers: this.getCustomHeader() })
            .pipe(catchError(err => {
                if (err.status === 403) {
                    console.log(err);
                }
                return err;
            })
            );
    }

    public POST(path: string, body: any): Observable<any> {
        console.log(`${ApiService.APIUrl}${path}`);
        return this.http.post(`${ApiService.APIUrl}${path}`,
            JSON.stringify(body), { headers: this.getCustomHeader() });
    }

    private getCustomHeader() {
        let headers = new HttpHeaders();
        // headers.set('Content-Type', 'application/json');
        // headers.set('Authorization', 'Basic HRDroneAPI:HRD#2022');
        headers = headers.append('Content-Type', 'application/json');

        // headers = headers.append('Accept', 'application/json');
        // headers = headers.append('Access-Control-Allow-Headers', 'Content-Type');
        // headers = headers.append('Access-Control-Allow-Origin', '*');
        // headers = headers.append('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');
        // headers = headers.append('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
        // headers = headers.append('Access-Control-Allow-Credentials', 'true');

        // headers = headers.append('Authorization', 'Basic HRDroneAPI:HRD#2022');
        // headers = headers.append('Authorization', 'Basic ' + base64encode('HRDroneAPI:HRD#2022'));
        
        return headers;
    }

}
