import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { Config } from 'protractor';


@Injectable()
export class ConfigComponent {
    configService: ConfigService;
    config: any;
    showConfig() {
        this.configService.getConfig()
          .subscribe((data: Config) => this.config = {
              heroesUrl: data.heroesUrl,
              textfile:  data.textfile,
              date: data.date,
          });
      }

  constructor(private http: HttpClient) { }
}