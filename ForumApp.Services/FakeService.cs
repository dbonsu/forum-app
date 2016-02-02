using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    public class FakeHandler : DelegatingHandler
    {
        public HttpResponseMessage Response { get; set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                               CancellationToken cancellationToken)
        {
            if (Response == null)
            {
                return base.SendAsync(request, cancellationToken);
            }

            return Task.Factory.StartNew(() => Response);
        }
    }

    public class FakeService : IFakeService
    {
        private HttpClient _client;

        public FakeService(HttpClient client)
        {
            _client = client;
        }

        public string GrabAFakeModel()
        {
            var request = new HttpRequestMessage { RequestUri = new Uri("http://localhost:50834/api/values/testfake") };

            request.Method = HttpMethod.Get;
            HttpResponseMessage response = _client.SendAsync(request).Result;

            var result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}