import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { API_URL } from 'src/shared/api';
import { AddItemDTO, CatalogItem } from 'src/shared/types/catalogTypes';

@Injectable({
  providedIn: 'root'
})
export class CatalogService {

  constructor(private http: HttpClient) { }

  getAvailableItems(searchRequest: any): Observable<CatalogItem[]> {
    return this.http
      .post<CatalogItem[]>(API_URL + '/catalog', searchRequest);
  }

  getItemsByCompanyId(id: number) {
    return of(catalogItems);
  }

  getItemById(id: number) {
    return of(catalogItems.find(el => el.id === id))
  }

  addItem(companyId: number, item: AddItemDTO) {
    const newItem: CatalogItem = {
      id: 123,
      model: {
        id: Math.floor(Math.random() * 10000),
        ...item.model
      },
      price: item.price,
      supplier: item.supplier,
    }

    catalogItems.push(newItem);
  }
}


const catalogItems: CatalogItem[] = [
  {
      id: 1,
      model: {
          id: 101,
          name: 'Sedan X',
          power: 200,
          gear: 'Automatic',
          doorCount: 4,
          company: 'Ford',
          seatCount: 5,
          engine: 'V6',
          imageUrl: 'https://example.com/sedan-x-image.jpg',
          color: 'red'
      },
      price: 35000,
      supplier: 'Supplier'
  },
  {
      id: 2,
      model: {
          id: 102,
          name: 'SUV Y',
          power: 250,
          gear: 'Manual',
          company: 'Ford',
          doorCount: 5,
          seatCount: 7,
          engine: 'V8',
          imageUrl: 'https://example.com/suv-y-image.jpg',
          color: 'green'
      },
      price: 45000,
      supplier: 'Supplier'
  },
  {
    id: 3,
    model: {
        id: 102,
        name: 'SUV Z',
        power: 250,
        gear: 'Manual',
        company: 'Ford',
        doorCount: 5,
        seatCount: 7,
        engine: 'V8',
        imageUrl: 'https://example.com/suv-y-image.jpg',
        color: 'blue'
    },
    price: 55000,
    supplier: 'Supplier'
  },
  {
    id: 6,
    model: {
        id: 102,
        name: 'SUV Z',
        power: 250,
        company: 'Ford',
        gear: 'Manual',
        doorCount: 5,
        seatCount: 7,
        engine: 'V8',
        imageUrl: 'https://example.com/suv-y-image.jpg',
        color: 'blue'
    },
    price: 55000,
    supplier: 'Supplier'
  },
  {
    id: 4,
    model: {
        id: 102,
        name: 'SUV Z',
        power: 250,
        gear: 'Manual',
        company: 'Ford',
        doorCount: 5,
        seatCount: 7,
        engine: 'V8',
        imageUrl: 'https://example.com/suv-y-image.jpg',
        color: 'blue'
    },
    price: 55000,
    supplier: 'Supplier'
  },
  {
    id: 5,
    model: {
        id: 102,
        name: 'SUV Z',
        company: 'Ford',
        power: 250,
        gear: 'Manual',
        doorCount: 5,
        seatCount: 7,
        engine: 'V8',
        imageUrl: 'https://example.com/suv-y-image.jpg',
        color: 'blue'
    },
    price: 55000,
    supplier: 'Supplier'
  },
];
