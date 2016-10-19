using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Model;
using DAL.Persistence;
using WebApplication2.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using WebApplication1.Metodo;
using WebApplication1.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Lista()
        {

            PessoaDAL pd = new PessoaDAL();
            var clientes = pd.Listar();
            var clientesviewmodeltela = new List<ClienteViewModelTela>();
            foreach (var cliente in clientes)
            {
                var clienteviewmodeltela = new ClienteViewModelTela(cliente);
                clientesviewmodeltela.Add(clienteviewmodeltela);
            }
            return View(clientesviewmodeltela);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Inserir()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Inserir(ClienteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Carro c = new Carro();
            c.Modelo = model.Modelo;
            c.Km = model.Km;
            c.Combustivel = model.Combustivel;
            c.Cambio = model.Cambio;
            c.FinalPlaca = model.FinalPlaca;
            c.Ano = model.Ano;
            c.Cor = model.Cor;
            c.Preco = model.Preco;
            c.Foto1 = Converter.ImageToByteArray(model.Foto1.InputStream);
            c.Foto2 = Converter.ImageToByteArray(model.Foto2.InputStream);
            c.Foto3 = Converter.ImageToByteArray(model.Foto3.InputStream);
            c.Foto4 = Converter.ImageToByteArray(model.Foto4.InputStream);
            c.Foto5 = Converter.ImageToByteArray(model.Foto5.InputStream);
            c.Foto6 = Converter.ImageToByteArray(model.Foto6.InputStream);

            String[] protecao = model.Opcao.Split(',');
            
            if(protecao.Length==6){
                c.opcao = model.Opcao;
            }else{
                return View(model);
            }

            PessoaDAL pd = new PessoaDAL();
            pd.gravar(c);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Login(ClienteLogin model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Nome == "Caique" && model.Senha == "123")
            {
                return RedirectToAction("Inserir");
            }
            else
            {
                return RedirectToAction("Loguin");

            }
        }
        [HttpGet]
        public ActionResult Deleta()
        {
            PessoaDAL pd = new PessoaDAL();
            var clientes = pd.Listar();
            var clientesviewmodeltela = new List<ClienteViewModelTela>();
            foreach (var cliente in clientes)
            {
                var clienteviewmodeltela = new ClienteViewModelTela(cliente);
                clientesviewmodeltela.Add(clienteviewmodeltela);
            }
            return View(clientesviewmodeltela);
        }
        [HttpPost]
        public ActionResult Deleta(String Codigo)
        {
            PessoaDAL pd = new PessoaDAL();
            int cod = Convert.ToInt32(Codigo);
            pd.Excluir(cod);
            return RedirectToAction("Index");
        }
    }
}
       
      

        

    
