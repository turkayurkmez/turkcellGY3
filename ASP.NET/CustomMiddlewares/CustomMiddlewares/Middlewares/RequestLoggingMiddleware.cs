namespace CustomMiddlewares.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            /*
        * Bu middleware'in amacı; API'ye gelen her request'i yakalamak ve bilgi vermektir.
        * 
        */

            // Gelen isteğin bilgilerini loglamak için ILogger kullanılıyor.
            _logger.LogInformation($"{DateTime.Now} anında Gelen request metodu: {httpContext.Request.Method}. Talebin gönderildiği adres: {httpContext.Request.Path}.");

            var responseBodyStream = httpContext.Response.Body;

            // Yanıtın bir kopyasını tutmak için yeni bir bellek akışı oluşturuluyor.
            var responseStream = new MemoryStream();

            // Yanıt akışı, oluşturulan bellek akışına yönlendiriliyor.
            httpContext.Response.Body = responseStream;

            // Sonraki middleware'i çağırmak ve işlem zincirinin devamını sağlamak için await kullanılıyor.
            await _next(httpContext);

            // Bellek akışını başa sararak yanıtın okunabilir hale getirilmesi sağlanıyor.
            responseStream.Seek(0, SeekOrigin.Begin);

            // Yanıtın içeriğini okumak için bir StreamReader kullanılıyor.
            var responseBody = new StreamReader(responseStream).ReadToEnd();

            _logger.LogInformation($"{DateTime.Now} anında Response oluştu....");
            _logger.LogInformation($"Oluşan response: {httpContext.Response.StatusCode} -> {responseBody} ");

            // Bellek akışını başa sararak yanıtın orijinal akışa kopyalanması sağlanıyor.
            responseStream.Seek(0, SeekOrigin.Begin);

            await responseStream.CopyToAsync(responseBodyStream);

        }
    }
}
