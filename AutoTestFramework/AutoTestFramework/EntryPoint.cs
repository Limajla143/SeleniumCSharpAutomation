﻿
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    //[TestFixture]
    public class EntryPoint
    {
       // IAlert alert;

        static void Main()
        {
            //Menu menu = new Menu();

            //Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            //menu.Selectors.Click();

            ////******************NAVIGATION************************////

            //Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            //NavigateTo.LoginFormThroughTheMenu();

            //Thread.Sleep(500);

            //Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            //NavigateTo.LoginFormThroughThenPost();

            //Thread.Sleep(500);

            //Driver.driver.Quit();

            ////****************************************************////

            ////************************ACTIONS********************////
            //Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            //NavigateTo.LoginFormThroughTheMenu();
            //Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            ////**************************************************////
        }

        //[SetUp]
        //public void Initialize()
        //{
        //    Actions.InitializeDriver(5);
        //}

        //[Test]
        //public void ValidLogin(IWebDriver driver)
        //{
        //    NavigateTo.LoginFormThroughTheMenu(driver);
        //    Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, driver);

        //    alert = driver.SwitchTo().Alert();

        //    Thread.Sleep(1000);

        //    Assert.AreEqual(Config.AlertMessages.SuccessfullLogin, alert.Text);

        //    alert.Accept();
        //}

        //[TearDown]
        //public void CleanUp(IWebDriver driver)
        //{
        //   driver.Quit();
        //}
    }
}
