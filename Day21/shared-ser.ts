@Injectable({providedIn: 'root'})
export class SharedService {
  private msg = new Subject<string>();
  msg$ = this.msg.asObservable();
  sendMessage(data:string){ this.msg.next(data); }
}
