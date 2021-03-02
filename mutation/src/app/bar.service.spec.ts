import { TestBed } from '@angular/core/testing';

import { BarService } from './bar.service';

describe('BarService', () => {
  let service: BarService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BarService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  describe('isPersonOldEnough', () => {
    it('should return true when age is greater than or equal to 18', () => {
      var isOldEnough = service.isPersonOldEnough(20);

      expect(isOldEnough).toBeTruthy();
    });

    // it('should return true when age is greater than 18', () => {
    //   var isOldEnough = service.isPersonOldEnough(20);

    //   expect(isOldEnough).toBeTruthy();
    // });

    // it('should return false when age is less than 18', () => {
    //   var isOldEnough = service.isPersonOldEnough(12);

    //   expect(isOldEnough).toBeFalsy();
    // });

    // it('should return true when age is equal to 18', () => {
    //   var isOldEnough = service.isPersonOldEnough(18);

    //   expect(isOldEnough).toBeTruthy();
    // });
  });
});
