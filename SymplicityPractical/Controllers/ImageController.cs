using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SymplicityPractical.Entities;

namespace SymplicityPractical.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            ViewBag.ImageId = Global.GetRandomImage;
            return View();
        }

        public ActionResult VoteHistory()
        {
            var context = Global.Context;
            var imageVotes = context.ImageVotes.Where(x => x.Session == this.Session.SessionID).ToList();
            ViewBag.ImageVotes = imageVotes;
            ViewBag.Session = this.Session.SessionID;
            return View();
        }

        public ActionResult VoteUp(int imageIndex)
        {
            var vote = new ImageVote
            {
                ImageIndex = imageIndex,
                Session = this.Session.SessionID,
                VoteUp = true
            };
            var context = Global.Context;
            context.ImageVotes.Add(vote);
            context.SaveChanges();
            return View("Index");
        }

        public ActionResult VoteDown(int imageIndex)
        {
            var vote = new ImageVote
            {
                ImageIndex = imageIndex,
                Session = this.Session.SessionID,
                VoteUp = false
            };
            var context = Global.Context;
            context.ImageVotes.Add(vote);
            context.SaveChanges();
            return View("Index");
        }

    }
}