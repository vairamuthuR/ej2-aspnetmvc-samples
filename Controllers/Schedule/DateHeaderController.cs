﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult DateHeader()
        {
            ViewBag.datasource = new ScheduleData().GetScheduleData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}