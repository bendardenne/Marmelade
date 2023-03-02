using System.Net.Http;
using System.Threading;
using Splat;

namespace Marmelade;

public class LoggingHandler : MessageProcessingHandler, IEnableLogger
{
    public LoggingHandler(HttpMessageHandler innerHandler)
        : base(innerHandler)
    {
    }

    protected override HttpRequestMessage ProcessRequest(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (this.Log().IsDebugEnabled)
        {
            var readAsStringAsync = request.Content?.ReadAsStringAsync();
            readAsStringAsync?.Wait();
            this.Log().Debug("Request \n{} \n{}", request, readAsStringAsync?.Result ?? string.Empty);
        }

        return request;
    }

    protected override HttpResponseMessage ProcessResponse(HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        if (this.Log().IsDebugEnabled)
        {
            var readAsStringAsync = response.Content.ReadAsStringAsync();
            readAsStringAsync.Wait();
            this.Log().Debug("Response \n{} \n{}", response, readAsStringAsync.Result);
        }

        return response;
    }
}