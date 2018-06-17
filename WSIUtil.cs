/*
	IBM grants you a nonexclusive copyright license to use all programming code 
	examples from which you can generate similar function tailored to your own 
	specific needs.

	All sample code is provided by IBM for illustrative purposes only.
	These examples have not been thoroughly tested under all conditions. IBM, 
	therefore cannot guarantee or imply reliability, serviceability, or function of 
	these programs.

	All Programs or code component contained herein are provided to you "AS IS" 
	without any warranties of any kind.
	The implied warranties of non-infringement, merchantability and fitness for a 
	particular purpose are expressly disclaimed.

	© Copyright IBM Corporation 2007, 2008, ALL RIGHTS RESERVED.
 */

using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using CEWebClientCS.CEWSI;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace CEWebClientCS
{
    public class WSIUtil
    {
        private static Localization _localization;
        private static FNCEWS40PortTypeClient _port;

        public static FNCEWS40PortTypeClient ConfigureBinding(String user, String domain, String password, String uri)
        {
            BindingElementCollection bec = new BindingElementCollection();

            // Everything gets treated as if it is username credentials until
            //  right at the point of serialization.
            TransportSecurityBindingElement sbe = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            sbe.IncludeTimestamp = false;
            sbe.AllowInsecureTransport = true;
            bec.Add(sbe);

            if (uri.IndexOf("SOAP") != -1)
            {
                // using the SOAP endpoint
                TextMessageEncodingBindingElement tme = new TextMessageEncodingBindingElement();
                tme.MessageVersion = MessageVersion.Soap11;
                tme.ReaderQuotas.MaxDepth = 1024;
                tme.ReaderQuotas.MaxStringContentLength = 1024 * 1024;
                bec.Add(tme);
            }
            else
            {
                MtomMessageEncodingBindingElement mme = new MtomMessageEncodingBindingElement();
                mme.MessageVersion = MessageVersion.Soap12;
                mme.ReaderQuotas.MaxDepth = 1024;
                mme.ReaderQuotas.MaxStringContentLength = 1024 * 1024;
                mme.MaxBufferSize = 2147483647;
                bec.Add(mme);
            }

            if (uri.IndexOf("https") != -1)
            {
                HttpsTransportBindingElement tbe = new HttpsTransportBindingElement();
                tbe.MaxReceivedMessageSize = 2147483647;
                tbe.MaxBufferSize = 2147483647;
                bec.Add(tbe);
            }
            else
            {
                HttpTransportBindingElement httptbe = new HttpTransportBindingElement();
                httptbe.MaxReceivedMessageSize = 2147483647;
                httptbe.MaxBufferSize = 2147483647;
                bec.Add(httptbe);
            }

            /*HttpsTransportBindingElement tbe = new HttpsTransportBindingElement();
            tbe.MaxReceivedMessageSize = 2147483647;
            tbe.MaxBufferSize = 2147483647;
            bec.Add(tbe);*/

            CustomBinding binding = new CustomBinding(bec);
            binding.ReceiveTimeout = new TimeSpan(TimeSpan.TicksPerDay);    // 100 nanonsecond units, make it 1 day
            binding.SendTimeout = binding.ReceiveTimeout;

            EndpointAddress endpoint = new EndpointAddress(uri);

            _port = new FNCEWS40PortTypeClient(binding, endpoint);

            _port.ClientCredentials.UserName.UserName = user;
            _port.ClientCredentials.UserName.Password = password;

            // set up the Localization header, minus the locale. We assume
            //  the timezone cannot change between calls, but that the locale
            //  may.
            _localization = new Localization();
            _localization.Timezone = GetTimezone();

            return _port;
        }

        public static Localization GetLocalization()
        {
            return _localization;
        }

        private static string GetTimezone()
        {
            System.TimeZone tz = System.TimeZone.CurrentTimeZone;
            System.TimeSpan tspan = tz.GetUtcOffset(System.DateTime.Now);

            // TimeZone.  Format should be '+|-HH:MM' (e.g., -07:00).
            String tzformat;
            if (tspan.Hours >= 0)
            {
                tzformat = String.Format("+{0}:{1}", tspan.Hours.ToString("D2"), tspan.Minutes.ToString("D2"));
            }
            else
            {
                tzformat = String.Format("{0}:{1}", tspan.Hours.ToString("D2"), tspan.Minutes.ToString("D2"));
            }
            return tzformat;
        } 
    }
}


