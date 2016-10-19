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

            CarroldDao cd = new CarroldDao();
            var carros = cd.Listar();
          



            var clientesviewmodeltela = new List<ClienteViewModelTelanCarro>();

            foreach (var carro in carros)
            {
               
                String desc = carro.descricao;
                String path1 = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/"+carro.caminho1);
                String path2 = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/"+carro.caminho2);
                Image imagem1 = Image.FromFile(path1);
                byte[] img1 = Converter.imageToByteArray(imagem1);
                Image imagem2 = Image.FromFile(path2);
                byte[] img2 = Converter.imageToByteArray(imagem2);

                ClienteViewModelTelanCarro cvmtc = new ClienteViewModelTelanCarro(img1,img2,desc);
              
                clientesviewmodeltela.Add(cvmtc);
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
        public ActionResult Inserir(clienteviewmodelnCarro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ncarro c = new ncarro();
            c.descricao = model.descricao;
            c.caminho1 = model.foto1.FileName.ToString();
            c.caminho2 = model.foto2.FileName.ToString();




            byte[] foto1asersalva = Converter.ImageToByteArray(model.foto1.InputStream);
            Image teste = Converter.ByteArrayToImage(foto1asersalva);
            string path = (System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/"));
            DiminuieSalvaimg.ComprimirImagem(teste, 20, path+model.foto1.FileName);

            byte[] foto2asersalva = Converter.ImageToByteArray(model.foto2.InputStream);
            Image teste1 = Converter.ByteArrayToImage(foto2asersalva);
            string path1 = (System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/"));
            DiminuieSalvaimg.ComprimirImagem(teste1, 20, path1 + model.foto2.FileName);


            CarroldDao cd = new CarroldDao();
            cd.gravarcarro(c);

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
       
      

        

    
