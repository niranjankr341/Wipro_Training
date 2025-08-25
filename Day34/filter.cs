public class LogFilter: ActionFilterAttribute {
    public override void OnActionExecuting(ActionExecutingContext context) {
        Console.WriteLine("Action starting...");
    }
}
