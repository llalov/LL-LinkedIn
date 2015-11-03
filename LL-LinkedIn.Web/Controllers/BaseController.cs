﻿using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using LL_LinkedIn.Data;
using LL_LinkedIn.Models;

namespace LL_LinkedIn.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        private ILL_LinkedInData data;
        private User userProfile;

        protected BaseController(ILL_LinkedInData data)
        {
            this.data = data;
        }

        protected BaseController(ILL_LinkedInData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        protected ILL_LinkedInData Data { get; private set; }

        protected User UserProfile { get; private set; }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All().FirstOrDefault(u => u.UserName == username);
                this.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}