using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Dto;
using MailKit.Net.Smtp;
using MimeKit;
using SportsonView.API.Data.Entities;
namespace SportsonView.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupportController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SupportController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendSupportMessage([FromBody] SupportRequest request)
        {
            try
            {
                string departmentEmail = request.Department.ToLower();
                //All support messages are sent to the same email for now, but this can be easily changed in the future if needed
                switch (departmentEmail)
                {
                    case "IT":
                        departmentEmail = "kevin.spehling@iths.se";
                        break;
                    case "Marknadsföring":
                        departmentEmail = "kevin.spehling@iths.se";
                        break;
                    case "Inköp":
                        departmentEmail = "kevin.spehling@iths.se";
                        break;
                    case "Övrigt":
                        departmentEmail = "kevin.spehling@iths.se";
                        break;

                }
                    var email = new MimeMessage();
                        email.From.Add(new MailboxAddress("Support", request.FromEmail));
                        email.To.Add(new MailboxAddress("Support", departmentEmail));
                        email.Subject = "[" + request.Name + "] - " + request.Message.Substring(0, Math.Min(50, request.Message.Length)) + "...";
                        email.Body = new TextPart("plain") { Text = "Från: " + request.Name + " <" + request.Store + ">\n\n" + request.Message };

                        using var client = new SmtpClient();
                        await client.ConnectAsync("sandbox.smtp.mailtrap.io", 2525, false);
                        await client.AuthenticateAsync("95f4c15d799fe0", "2abe3ac403bcec");
                        await client.SendAsync(email);
                        await client.DisconnectAsync(true);

                        return Ok(new { message = "Supportmeddelandet har skickats framgångsrikt." });
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                return StatusCode(500, "Ett fel inträffade när supportmeddelandet skulle skickas. " + ex.Message);
            }
        }
    }

}