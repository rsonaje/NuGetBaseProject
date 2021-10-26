using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetBaseProject
{
    public class BaseLibrary
    {
        public string VersionInfo
        {
            get { return "This is default version: 1.0.0"; }
        }

        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}
