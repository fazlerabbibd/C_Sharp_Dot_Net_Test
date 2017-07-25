public static class TaskExtensions
{
    public static Task<T> TaskResult<T>(this T source) => Task.FromResult(source);

}
