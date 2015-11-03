using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LL_LinkedIn.Models;

namespace LL_LinkedIn.Web.ViewModels
{
    public class UserViewModel
    {

        public static Expression<Func<User, UserViewModel>> ViewModel
        {
            get
            {
                return x => new UserViewModel()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    Summary = x.Summary,
                    ContactInfo = x.ContactInfo,
                    Fullname = x.Fullname,
                    AvatarUrl = x.AvatarUrl,
                    Certifications = x.Certifications
                    .AsQueryable()
                    .Select(CertificationViewModel.ViewModel)
                    
                };
            }
            
        }

        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Fullname { get; set; }

        public string AvatarUrl { get; set; }

        public string Summary { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public IEnumerable<CertificationViewModel> Certifications { get; set; }

       
       
    }
}