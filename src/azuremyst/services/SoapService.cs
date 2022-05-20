using azuremyst.models.options;
using azuremyst.services.interfaces;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace azuremyst.services
{
    public class SoapService : ISoapService
    {
        readonly IHttpClientFactory _httpClientFactory;

        public SoapService(
            IHttpClientFactory httpClientFactory
        )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> TestAsync()
        {

            var envelope = EnvelopeSOAPCommand(string.Format("server shutdown 5\n"));
            //using var stringWriter = new StringWriter();
            //using var xmlWriter = XmlWriter.Create(stringWriter);
            //envelope.WriteTo(xmlWriter);
            //xmlWriter.Flush();
            //var builder = stringWriter.GetStringBuilder();
            //var content = builder.ToString();
            // can we just use OuterXml here instead of all these disposables?
            var httpClient = _httpClientFactory.CreateClient(Assembly.GetExecutingAssembly().GetName().Name);
            var result = await httpClient.PostAsync(string.Empty, new StringContent(envelope.OuterXml, Encoding.UTF8, Application.Xml));
            if (result.IsSuccessStatusCode)
            {
                using var reader = new StreamReader(await result.Content.ReadAsStreamAsync());
                return await reader.ReadToEndAsync();
            }
            return string.Empty;
        }

        //public async Task<string> MailAsync(string name, int id)
        //{

        //    var envelope = EnvelopeSOAPCommand(string.Format($"send items {name} \"azuremy.st\" \" - the letter glows faintly...\" {id}\n"));
        //    var soapClient = CreateSOAPClient(_mangosOptions.Username!, _mangosOptions.Password!);
        //    InsertSoapEnvelopeIntoWebRequest(envelope, soapClient);

        //    var result = await soapClient.GetAsync("");
        //    if (result.IsSuccessStatusCode)
        //    {
        //        using var reader = new StreamReader(await result.Content.ReadAsStreamAsync());
        //        return await reader.ReadToEndAsync();
        //    }
        //    return string.Empty;
        //}

        XmlDocument EnvelopeSOAPCommand(string command)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(string.Format(@"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:SOAP-ENC=""http://schemas.xmlsoap.org/soap/encoding/"" xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/1999/XMLSchema"" xmlns:ns1=""urn:MaNGOS""><SOAP-ENV:Body><ns1:executeCommand><command>{0}</command></ns1:executeCommand></SOAP-ENV:Body></SOAP-ENV:Envelope> ", command));
            return soapEnvelopeDocument;
        }
    }
}
