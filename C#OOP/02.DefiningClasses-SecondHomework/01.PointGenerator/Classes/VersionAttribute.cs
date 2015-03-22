using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGenerator.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class VersionAttribute : Attribute
    {
        public string VersionInfo
        { get; private set; }

        public VersionAttribute(string versionInfo)
        {
            this.VersionInfo = versionInfo;
        }
    }
}
