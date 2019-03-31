import { TestBed } from '@angular/core/testing';

import { PolicesService } from './polices.service';

describe('PolicesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PolicesService = TestBed.get(PolicesService);
    expect(service).toBeTruthy();
  });
});
