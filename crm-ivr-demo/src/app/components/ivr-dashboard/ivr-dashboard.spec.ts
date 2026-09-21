import { ComponentFixture, TestBed } from '@angular/core/testing';
import { IvrDashboard } from './ivr-dashboard';

describe('IvrDashboard', () => {
  let component: IvrDashboard;
  let fixture: ComponentFixture<IvrDashboard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [IvrDashboard],
    }).compileComponents();

    fixture = TestBed.createComponent(IvrDashboard);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
