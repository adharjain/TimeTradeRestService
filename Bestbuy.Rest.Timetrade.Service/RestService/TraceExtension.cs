using System;
using System.IO;
using System.Web.Services.Protocols;
using System.Xml;

namespace Bestbuy.Rest.Timetrade.Service
{
    /// <summary>
    /// SOAP Extension that traces the SOAP request and
    /// SOAP response for the PayPal SOAP API Web service. 
    /// </summary>
    public class TraceExtension : SoapExtension
    {
        private Stream oldStream;
        private Stream newStream;

        private static XmlDocument xmlRequest;
        /// <summary>
        /// Gets the outgoing XML request sent to PayPal
        /// </summary>
        public static XmlDocument XmlRequest
        {
            get { return xmlRequest; }
        }

        private static XmlDocument xmlResponse;
        /// <summary>
        /// Gets the incoming XML response sent from PayPal
        /// </summary>
        public static XmlDocument XmlResponse
        {
            get { return xmlResponse; }
        }

        /// <summary>
        /// Save the Stream representing the SOAP request
        /// or SOAP response into a local memory buffer. 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public override Stream ChainStream(Stream stream)
        {
            oldStream = stream;
            newStream = new MemoryStream();
            return newStream;
        }

        /// <summary>
        /// If the SoapMessageStage is such that the SoapRequest or
        /// SoapResponse is still in the SOAP format to be sent or received,
        /// save it to the xmlRequest or xmlResponse property.
        /// </summary>
        /// <param name="message"></param>
        public override void ProcessMessage(SoapMessage message)
        {
            switch (message.Stage)
            {
                case SoapMessageStage.BeforeSerialize:
                    break;
                case SoapMessageStage.AfterSerialize:
                    xmlRequest = GetSoapEnvelope(newStream);
                    CopyStream(newStream, oldStream);
                    break;
                case SoapMessageStage.BeforeDeserialize:
                    CopyStream(oldStream, newStream);
                    xmlResponse = GetSoapEnvelope(newStream);
                    break;
                case SoapMessageStage.AfterDeserialize:
                    break;
            }
        }

        /// <summary>
        /// Returns the XML representation of the Soap Envelope in the supplied stream.
        /// Resets the position of stream to zero.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private XmlDocument GetSoapEnvelope(Stream stream)
        {
            XmlDocument xml = new XmlDocument();
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            xml.LoadXml(reader.ReadToEnd());
            stream.Position = 0;
            return xml;
        }

        /// <summary>
        /// Copies a stream.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void CopyStream(Stream from, Stream to)
        {
            TextReader reader = new StreamReader(from);
            TextWriter writer = new StreamWriter(to);
            writer.WriteLine(reader.ReadToEnd());
            writer.Flush();
        }
        #region NoOp
        /// <summary>
        /// Included only because it must be implemented.
        /// </summary>
        /// <param name="methodInfo"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public override object GetInitializer(LogicalMethodInfo methodInfo,
            SoapExtensionAttribute attribute)
        {
            return null;
        }

        /// <summary>
        /// Included only because it must be implemented.
        /// </summary>
        /// <param name="WebServiceType"></param>
        /// <returns></returns>
        public override object GetInitializer(Type WebServiceType)
        {
            return null;
        }

        /// <summary>
        /// Included only because it must be implemented.
        /// </summary>
        /// <param name="initializer"></param>
        public override void Initialize(object initializer)
        {
        }
        #endregion NoOp
    }
}