// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Snip.Controllers {
    public partial class SnippetController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SnippetController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SnippetController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Delete() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Display() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Display);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Edit() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult IsAvailable() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.IsAvailable);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SnippetController Actions { get { return Mvc.Snippet; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "snippet";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Add = ("Add").ToLowerInvariant();
            public readonly string Delete = ("Delete").ToLowerInvariant();
            public readonly string Display = ("Display").ToLowerInvariant();
            public readonly string Edit = ("Edit").ToLowerInvariant();
            public readonly string IsAvailable = ("IsAvailable").ToLowerInvariant();
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Add = "~/Views/Snippet/Add.cshtml";
            public readonly string Display = "~/Views/Snippet/Display.cshtml";
            public readonly string Edit = "~/Views/Snippet/Edit.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_SnippetController: Snip.Controllers.SnippetController {
        public T4MVC_SnippetController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Add() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Add);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Add(Snip.Models.Snippet snippet) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Add);
            callInfo.RouteValueDictionary.Add("snippet", snippet);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Delete(string id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Delete);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Display(string id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Display);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(string id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(Snip.Models.Snippet modifiedSnippet) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("modifiedSnippet", modifiedSnippet);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult IsAvailable(string id) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.IsAvailable);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591