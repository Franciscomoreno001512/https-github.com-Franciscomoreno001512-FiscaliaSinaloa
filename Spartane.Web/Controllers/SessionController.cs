using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Spartane.Web.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class SessionController : BaseController
    {
        public ActionResult GetRemainingSessionTimeout()
        {
            if (!Request.IsAjaxRequest())
            {
                return Content("Not an Ajax call.");
            }

            var remainingSessionTimeout = 0;
            if (Session["_LastAccessTime"] != null)
            {
                var lastAccessTime = (DateTime)Session["_LastAccessTime"];
                var timeSpan = DateTime.Now.Subtract(lastAccessTime);
                remainingSessionTimeout = Session.Timeout - timeSpan.Minutes;
            }

            return Json(new { RemainingSessionTimeout = remainingSessionTimeout }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult KeepSessionAlive()
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
