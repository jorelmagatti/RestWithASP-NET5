using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RestWithAspNet2.Util
{
    public static class VersionUtil
    {
        public static string GetVersionString()
        {
            //AssemblyVersion
            var version1 = Assembly.GetEntryAssembly().GetName().Version;

            //AssemblyFileVersion
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version2 = fvi.FileVersion;


            return $"AssemblyVersion => {version1} ; AssemblyFileVersion => {version2}"; ;
        }
    }
}
