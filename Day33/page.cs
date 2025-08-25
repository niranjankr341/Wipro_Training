public class IndexModel: PageModel {
    public string Message {get;set;} = "Hello Razor!";
}
< h2 > @Model.Message </ h2 >
@await Html.PartialAsync("_Menu")

