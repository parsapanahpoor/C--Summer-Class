using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Jalaseye20.Controllers
{
    public class AccountController : Controller
    {

        #region Actions


        public IActionResult Register()
        {


            return View();
        }



        #endregion



        #region Utilities

        //Utilities
        private void DateConvertor()
        {

            PersianCalendar persian = new PersianCalendar();
         
        }

        #endregion

    }
}
