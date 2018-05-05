﻿using Himall.Model;
using Himall.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Himall.Web.Areas.Web.Controllers
{
	public class TaoCanController : Controller
	{
		// GET: Web/TaoCan
		public ActionResult Index()
		{
			taocan_tcitemService taocanService = new taocan_tcitemService();
			List<taocan_tcmenu> taocanMenuList = taocanService.GetTaoCanMenus();
			ViewBag.taocanMenuList = taocanMenuList;
			return View();
		}


		public ActionResult TaoCanInfo(int id)
		{
            taocan_tcitemService ser = new taocan_tcitemService();
            taocan_tcitem item = ser.Gettaocan_tcitem(1);
			return View();
		}
	}
}