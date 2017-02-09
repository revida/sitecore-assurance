﻿using Autofac;

namespace Revida.Sitecore.Assurance.PageCheckers
{
    public class PageCheckersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HttpWebRequestFactory>().As<IHttpWebRequestFactory>();
            builder.RegisterType<PageHttpResponseChecker>().AsSelf();
        }
    }
}