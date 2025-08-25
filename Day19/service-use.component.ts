constructor(private dataService: DataService) {}
ngOnInit(){ console.log(this.dataService.getMessage()); }
