﻿using System.Web.Mvc;

namespace LL_LinkedIn.Web.App_Start
{
    public static class ViewEnginesConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection viewEngines)
        {
            viewEngines.Clear();
            viewEngines.Add(new RazorViewEngine());
        }
    }
}