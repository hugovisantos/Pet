using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Temp
{
    //EXEMPLO 1
    public class Notificacao 
    {
        public string Enviar()
        {
            //Forma de envio
            var mensagem = "enviado";
            return mensagem;
        }
    }
    public class UsarComando
    {
        public string Receber()
        {
            Notificacao notificacao = new Notificacao();
            var envio = notificacao.Enviar();
            return envio;
        }
    }

    public class UsarComandoInj
    {
        protected Notificacao _notificacao;

        public UsarComandoInj(Notificacao notificacao) //usar na classe 
        {
            _notificacao = notificacao;
        }

        public void Receber() //usar no metodo
        {
            _notificacao.Enviar();
        }
    }
    



    //EXEMPLO 2
    public interface INotificacao
    {
        string Enviar();
    }
    public class Notificacao1 : INotificacao
    {
        public string Enviar()
        {
            return "Enviado";
        }
    }
    public class Notificacao2 : INotificacao
    {
        public string Enviar()
        {
            return "Enviado com sucesso";
        }
    }
    public class UsarComandoInj1
    {
        protected INotificacao _notificacao1;

        public UsarComandoInj1(Notificacao1 notificacao)
        {
             _notificacao1 = notificacao;
            
        }
        
    }




    //EXEMPLO 3 
    public class Download
    {
        //Definição de download
    }
    public interface IDownBusiness
    {
        void SalvarDownloadBD(Download objDown);
    }    
    public interface IDownData
    {
        void ConexaoBanco();
    }
    

    public class DownController : Controller
    {
        private IDownBusiness iObjDownBusiness;
        public DownController(IDownBusiness _iObjDownBusiness)
        {
            iObjDownBusiness = _iObjDownBusiness;
        }

        public ActionResult NovoDownload(Download objDown)
        {
            iObjDownBusiness.SalvarDownloadBD(objDown);
            return View();
        }
    }

    public class DownBusiness : IDownBusiness
    {
        private IDownData iObjDownData;

        public DownBusiness(IDownData _iObjDownData)
        {
            this.iObjDownData = _iObjDownData;
        }

        public void SalvarDownloadBD(Download objDown)
        {
            iObjDownData.ConexaoBanco();

            //Salva no BD
        }
    }

    public class DownData : IDownData
    {
        public void ConexaoBanco()
        {
            //Conecta no banco de dados
        }
    }
}
