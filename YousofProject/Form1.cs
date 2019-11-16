using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YousofProject
{
    public partial class Form1 : Form
    {
        IWebDriver webDriver;
        public Form1()
        {
            InitializeComponent();
            txtUserName.Text = "Yousef5050";
            txtPassword.Text = "Mahabad1368";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdioChrome.Checked == true)
                webDriver = new ChromeDriver();
            else
                webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("https://www.woonnetrijnmond.nl");
            webDriver.FindElement(By.ClassName("header-secondary__btn--login")).Click();

            webDriver.FindElement(By.Id("username")).SendKeys(txtUserName.Text);
            webDriver.FindElement(By.Id("password")).SendKeys(txtPassword.Text);
            webDriver.FindElement(By.ClassName("inloggen-btn")).Click();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            webDriver.Navigate().GoToUrl(txtUrl.Text);
            var element= webDriver.FindElement(By.CssSelector("a[class='obj-detail-vragen__link  obj-detail-vragen__link--reageren']"));
            element.Click();
        }
    }
}
