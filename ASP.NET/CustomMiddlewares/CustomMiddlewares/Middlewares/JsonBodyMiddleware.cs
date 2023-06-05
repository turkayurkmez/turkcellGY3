namespace CustomMiddlewares.Middlewares
{
    public class JsonBodyMiddleware
    {
        //amaç: bir request'in POST olduğunu ve JSON data içerdiğini anlamak

        private readonly RequestDelegate _next;

        public JsonBodyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == "POST" && context.Request.ContentType.StartsWith("application/json"))
            {
                using var streamReader = new StreamReader(context.Request.Body);
                var jsonBody = await streamReader.ReadToEndAsync();
                context.Items["JsonBody"] = jsonBody;

            }
            await _next(context);
        }
    }
}
