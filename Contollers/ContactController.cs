using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid) //Model veri türü doğruysa
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("bookapp34@gmail.com", "BookApp", System.Text.Encoding.UTF8);
                msg.To.Add("bookapp34@gmail.com");
                msg.Subject = model.Subject; //Modelden gelen konu
                msg.Body = "Ad-Soyad: " + model.NameSurname + "<br><br>" + model.Message + "<br><br> Eposta: " + model.Email; //Mail içeriği modelden gelen Ad-Soyad, mesaj ve kullanıcının girmiş olduğu mailden oluşuyor
                msg.IsBodyHtml = true;

                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("bookapp34@gmail.com", "@book.app"); // Mesajın gönderileceği eposta ve şifresi
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    try //Mesaj basarıyla gönderilirse
                    {
                        client.Send(msg);
                        TempData["Message"] = "Mesajınız iletilmiştir. En kısa sürede incelenecektir.";

                    }
                    catch (Exception ex)//Mesaj gönderilemezse
                    {
                        TempData["Message"] = "Mesaj gönderilemedi. Hata nedeni:" + ex.Message;
                    }
                }
                ModelState.Clear();
            }
            return View();
        }
    }
}
