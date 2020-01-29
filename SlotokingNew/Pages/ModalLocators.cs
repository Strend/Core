using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotokingNew.Pages
{
    class ModalLocators
    {


        public IWebElement ModalInputLogin => Driver.WaitUntilVisible(By.Id("desktop_modules_players_models_ModalLoginForm_login"));
        public IWebElement ModalInputPasswordLogin => Driver.WaitUntilVisible(By.Id("desktop_modules_players_models_ModalLoginForm_password"));

        public IWebElement ModalInputButtonSubmit => Driver.WaitUntilVisible(By.Id("login"));




        public IWebElement ModalInputremaind => Driver.WaitUntilVisible(By.Id("desktop_modules_players_models_RemindPasswordForm_login"));
        public IWebElement ModalInputButtonremaind => Driver.WaitUntilVisible(By.Id("remind"));


        
            
        public void InputRandom()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 9999999);
                                
            ModalInputPasswordLogin.SendKeys("495" + randomNumber.ToString());
        }


        public void InputRandomRemaind()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 99999999);

            ModalInputremaind.SendKeys(randomNumber.ToString() + "@gmail.com");
        }


    }
}
