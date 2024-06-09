import { TestBed } from '@angular/core/testing';

import { JurosCompostosServiceService } from './juros-compostos-service.service';

describe('JurosCompostosServiceService', () => {
  let service: JurosCompostosServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JurosCompostosServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
