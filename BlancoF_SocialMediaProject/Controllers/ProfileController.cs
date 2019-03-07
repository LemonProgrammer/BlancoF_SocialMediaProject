using ProfileService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlancoF_SocialMediaProject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        ProfileModel currentProfile = new ProfileModel();

        public ActionResult ProfilePage()
        {
            var model = currentProfile;
            return View(model);
        }

        public ActionResult Gallery()
        {

            return View(currentProfile);
        }

    }
}