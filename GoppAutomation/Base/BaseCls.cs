using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GoppAutomation.Base
{
    public class BaseCls
    {
        public IWebDriver _driver = new FirefoxDriver();
        //private NgWebDriver ngDriver;
        public static String GenRandomString()
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var length = 10;

            var chars = new char[length];
            var rd = new Random();

            for (var i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new String(chars);
        }



    }
    }

