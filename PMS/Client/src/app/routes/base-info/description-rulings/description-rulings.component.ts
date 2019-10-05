import { Component, OnInit, ViewChild, HostListener, ElementRef } from '@angular/core';
import { NzInputDirective } from 'ng-zorro-antd';

@Component({
  selector: 'app-description-rulings',
  templateUrl: './description-rulings.component.html',
  styleUrls: ['./description-rulings.component.less'],
})
export class DescriptionRulingsComponent implements OnInit {
  i = 0;
  editSerial: string | null;
  editDescription: string | null;
  listOfData: any[] = [];
  @ViewChild(NzInputDirective, { static: false, read: ElementRef }) inputElement: ElementRef;

  @HostListener('window:click', ['$event'])
  handleClick(e: MouseEvent): void {
    if (this.editDescription && this.inputElement && this.inputElement.nativeElement !== e.target) {
      this.editDescription = null;
    }
  }

  addRow(): void {
    this.listOfData = [
      ...this.listOfData,
      {
        id: `${this.i}`,
        serial: `987345-21365`,
        description: `شرح حکم جدید`,
      },
    ];
    this.i++;
  }

  deleteRow(id: string): void {
    this.listOfData = this.listOfData.filter(d => d.id !== id);
  }

  startEdit(id: string, event: MouseEvent): void {
    event.preventDefault();
    event.stopPropagation();
    this.editDescription = id;
  }

  ngOnInit(): void {}
}
