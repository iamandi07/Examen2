import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {

  public persons: Person[];
  public inspectionPlans: InspectionPlan[];
  public equipments: Equipment[];

  public name: string = "test";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadPersons();
    this.loadInspectionPlans();
    this.loadEquipments();
    }

  loadPersons() {
    this.http.get<Person[]>(this.baseUrl + 'api/Persons').subscribe(result => {
      this.persons = result;
      console.log(this.persons);
    }, error => console.error(error));
  }

  loadInspectionPlans() {
    this.http.get<InspectionPlan[]>(this.baseUrl + 'api/InspectionPlans').subscribe(result => {
      this.inspectionPlans = result;
      console.log(this.inspectionPlans);
    }, error => console.error(error));
  }

  loadEquipments() {
    this.http.get<Equipment[]>(this.baseUrl + 'api/Equipments').subscribe(result => {
      this.equipments = result;
      console.log(this.equipments);
    }, error => console.error(error));
  }
}

interface Person {
  name: string;
  surname: string;
  phoneNumber: string;
  email: string;
}
interface InspectionPlan {
  description: string;
  temperature: Int16Array;
  humidity: Int16Array;
  pressure: Int16Array;
  person: Person;
}
interface Equipment {
  description: string;
  equipementType: string;
  model: string;
  serialNumber: string;
  personId: Int16Array;
  person: Person;
  inspectionPlanId: Int16Array;
  inspectionPlan: InspectionPlan;
  calibrationDate: Date;
}
