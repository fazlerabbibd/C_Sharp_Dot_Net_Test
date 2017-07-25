public class MyController : ApiController
{
  public string Get()
  {
    var usersJsonTask = GetUsersJsonAsync(...);
    return usersJsonTask.Result.ToString();
  }
}

public static async Task<JObject> GetUsersJsonAsync(Uri uri)
{
  var response = await HttpClient.GetAsync(uri);   // REST API CALL
  return JObject.Parse(response);
}

