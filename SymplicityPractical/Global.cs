using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using SymplicityPractical.Context;

namespace SymplicityPractical
{
    public static class Global
    {
        private static Random _rnd;
        private static int GetNumberImages => Directory.GetFiles(HttpRuntime.AppDomainAppPath + "\\Images").Length;

        public static int GetRandomImage
        {
            get
            {
                if (_rnd == null)
                    _rnd = new Random();
                return _rnd.Next(1, GetNumberImages + 1);
            }
        }

        public static string GetImagePath(int imageIndex)
        {
            return "../Images/" + imageIndex.ToString() + ".jpg";
        }

        public static MyContext Context = new MyContext();

    }
}