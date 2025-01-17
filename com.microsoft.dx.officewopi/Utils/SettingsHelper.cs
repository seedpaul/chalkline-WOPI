﻿using System;
using System.Configuration;

namespace com.chalkline.wopi.Utils
{
    public class SettingsHelper
    {
        public static string ClientId
        {
            get { return ConfigurationManager.AppSettings["ida:ClientId"]; }
        }

        public static string ClientSecret
        {
            get { return ConfigurationManager.AppSettings["ida:ClientSecret"]; }
        }

        public static string AuthorizationUri = "https://login.microsoftonline.com";
        public static string Authority = String.Format("{0}/common", AuthorizationUri);
        public static string AADGraphResourceId = "https://graph.windows.net";
        public static string MicrosoftGraphResourceId = "https://graph.microsoft.com";
        public static string Audience = "https://officewopi.azurewebsites.net";
    }
}