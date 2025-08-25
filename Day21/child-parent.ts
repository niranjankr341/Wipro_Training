@Output() notify = new EventEmitter<string>();
<button (click)="notify.emit('Hi Parent')">Click Me</button>
