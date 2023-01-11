using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static MyStore.Pages.Client.IndexModel;

namespace MyStore.Pages.Client
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = "";
        public string sucessMessage = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            clientInfo.name = Request.Form["name"];
            clientInfo.email = Request.Form["email"];
            clientInfo.phone = Request.Form["phone"];
            clientInfo.adress = Request.Form["adress"];

            if(clientInfo.name.Length == 0 || clientInfo.email.Length == 0 || 
                clientInfo.phone.Length == 0 || clientInfo.adress.Length == 0)
            {
                errorMessage = "Todos os campos precisam ser preenchidos!";
                return;
            }

            clientInfo.name = "";clientInfo.email = "";
            clientInfo.phone = "";clientInfo.adress = "";
            sucessMessage = "Novo cliente adicionado!";
        }
    }
}
