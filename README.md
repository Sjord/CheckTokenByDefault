Example project that goes with [this article](https://www.sjoerdlangkemper.nl/2016/12/22/csrf-protection-by-default-in-asp-net-mvc/).

Check the CSRF token on all POST requests. This is implemented as a custom [filter](CheckTokenByDefault/ValidateAntiForgeryTokenOnPost.cs) that is registered in the [FilterConfig](CheckTokenByDefault/App_Start/FilterConfig.cs).


