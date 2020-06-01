using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;


namespace Bot_Badoo
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("http://badoo.com/signin/?f=top");

            IWebElement searchInputLogin = Browser.FindElement(By.Name("email"));
            searchInputLogin.SendKeys(Convert.ToString(textBox1.Text));
            IWebElement searchInputPass = Browser.FindElement(By.Name("password"));
            searchInputPass.SendKeys(Convert.ToString(textBox2.Text) + OpenQA.Selenium.Keys.Enter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        async private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(textBox3.Text); i++)
            {
                IWebElement buttonLike = Browser.FindElement(By.CssSelector(".encounters-actions_item.encounters-actions_item--yes"));

                buttonLike.Click();
                await Task.Delay(3000);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
