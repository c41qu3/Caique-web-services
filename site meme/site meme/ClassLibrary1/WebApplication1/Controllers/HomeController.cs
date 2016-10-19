using DAL.Model;
using DAL.Persistence;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Metodo;
using WebApplication1.Models;
using WebApplication2.Models;

public class HomeController : Controller
{

    public ActionResult Lista()
{
    List<ncavalo> c = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo cavalo in c)
    {
        if (cavalo.cod_tipo == 1)
        {
            string descricao = cavalo.descricao;
            ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + cavalo.caminho1))), descricao);
            list.Add(item);
        }
    }
    return View(list);
}

public ActionResult ListaGaranhao()
{
    List<ncavalo> arg_10_0 = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo current in arg_10_0)
    {
        if (current.cod_tipo == 2)
        {
            string descricao = current.descricao;
            ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + current.caminho1))), descricao);
            list.Add(item);
        }
    }
    return base.View(list);
}

public ActionResult ListaTreinamentos()
{
    List<ncavalo> arg_10_0 = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo current in arg_10_0)
    {
        if (current.cod_tipo == 3)
        {
            string descricao = current.descricao;
            ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + current.caminho1))), descricao);
            list.Add(item);
        }
    }
    return base.View(list);
}

public ActionResult ListarEventos()
{
    List<ncavalo> arg_10_0 = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo current in arg_10_0)
    {
        if (current.cod_tipo == 4)
        {
            string descricao = current.descricao;
            ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + current.caminho1))), descricao);
            list.Add(item);
        }
    }
    return base.View(list);
}

public ActionResult ListarVendas()
{
    List<ncavalo> arg_10_0 = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo current in arg_10_0)
    {
        if (current.cod_tipo == 5)
        {
            string descricao = current.descricao;
            ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + current.caminho1))), descricao);
            list.Add(item);
        }
    }
    return base.View(list);
}

public ActionResult Index()
{
    return base.View();
}

public ActionResult About()
{
    return base.View();
}

public ActionResult Contact()
{
   
    return base.View();
}

[HttpGet]
public ActionResult Inserir()
{
    return base.View();
}

[HttpPost]
public ActionResult Inserir(clienteviewmodelnCarro model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    ncavalo ncavalo = new ncavalo();
    ncavalo.descricao = model.descricao;
    ncavalo.caminho1 = model.foto1.FileName.ToString();
    ncavalo.cod_tipo = 1;
    Image arg_82_0 = Converter.ByteArrayToImage(Converter.ImageToByteArray(model.foto1.InputStream));
    string str = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/");
    DiminuieSalvaimg.ComprimirImagem(arg_82_0, 80L, str + model.foto1.FileName);
    new Cavalodal().gravarcavalo(ncavalo);
    return base.RedirectToAction("Index");
}

[HttpGet]
public ActionResult InserirGaranhao()
{
    return base.View();
}

[HttpPost]
public ActionResult InserirGaranhao(clienteviewmodelnCarro model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    ncavalo ncavalo = new ncavalo();
    ncavalo.descricao = model.descricao;
    ncavalo.caminho1 = model.foto1.FileName.ToString();
    ncavalo.cod_tipo = 2;
    Image arg_82_0 = Converter.ByteArrayToImage(Converter.ImageToByteArray(model.foto1.InputStream));
    string str = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/");
    DiminuieSalvaimg.ComprimirImagem(arg_82_0, 80L, str + model.foto1.FileName);
    new Cavalodal().gravarcavalo(ncavalo);
    return base.RedirectToAction("Index");
}

public ActionResult InserirTreinamento()
{
    return base.View();
}

[HttpPost]
public ActionResult InserirTreinamento(clienteviewmodelnCarro model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    ncavalo ncavalo = new ncavalo();
    ncavalo.descricao = model.descricao;
    ncavalo.caminho1 = model.foto1.FileName.ToString();
    ncavalo.cod_tipo = 3;
    Image arg_82_0 = Converter.ByteArrayToImage(Converter.ImageToByteArray(model.foto1.InputStream));
    string str = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/");
    DiminuieSalvaimg.ComprimirImagem(arg_82_0, 80L, str + model.foto1.FileName);
    new Cavalodal().gravarcavalo(ncavalo);
    return base.RedirectToAction("Index");
}

public ActionResult InserirEventos()
{
    return base.View();
}

[HttpPost]
public ActionResult InserirEventos(clienteviewmodelnCarro model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    ncavalo ncavalo = new ncavalo();
    ncavalo.descricao = model.descricao;
    ncavalo.caminho1 = model.foto1.FileName.ToString();
    ncavalo.cod_tipo = 4;
    Image arg_82_0 = Converter.ByteArrayToImage(Converter.ImageToByteArray(model.foto1.InputStream));
    string str = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/");
    DiminuieSalvaimg.ComprimirImagem(arg_82_0, 80L, str + model.foto1.FileName);
    new Cavalodal().gravarcavalo(ncavalo);
    return base.RedirectToAction("Index");
}

public ActionResult InserirVenda()
{
    return base.View();
}

[HttpPost]
public ActionResult InserirVenda(clienteviewmodelnCarro model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    ncavalo ncavalo = new ncavalo();
    ncavalo.descricao = model.descricao;
    ncavalo.caminho1 = model.foto1.FileName.ToString();
    ncavalo.cod_tipo = 5;
    Image arg_82_0 = Converter.ByteArrayToImage(Converter.ImageToByteArray(model.foto1.InputStream));
    string str = System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/");
    DiminuieSalvaimg.ComprimirImagem(arg_82_0, 80L, str + model.foto1.FileName);
    new Cavalodal().gravarcavalo(ncavalo);
    return base.RedirectToAction("Index");
}

[HttpGet]
public ActionResult Login()
{
    return base.View();
}

[HttpPost]
public ActionResult Login(ClienteLogin model)
{
    if (!base.ModelState.IsValid)
    {
        return base.View(model);
    }
    if (model.Nome == "Caique" && model.Senha == "123")
    {
        return base.RedirectToAction("Opcoes");
    }
    return base.RedirectToAction("Loguin");
}

[HttpGet]
public ActionResult Deleta()
{
    List<ncavalo> arg_10_0 = new Cavalodal().Listar();
    List<ClienteViewModelTelanCarro> list = new List<ClienteViewModelTelanCarro>();
    foreach (ncavalo current in arg_10_0)
    {
        string desc = current.cod.ToString();
        ClienteViewModelTelanCarro item = new ClienteViewModelTelanCarro(Converter.imageToByteArray(Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout/" + current.caminho1))), desc);
        list.Add(item);
    }
    return base.View(list);
}

[HttpPost]
public ActionResult Deleta(string Codigo)
{
    Cavalodal arg_0D_0 = new Cavalodal();
    int cod = Convert.ToInt32(Codigo);
    arg_0D_0.Excluir(cod);
    return base.RedirectToAction("Index");
}

[HttpGet]
public ActionResult Opcoes()
{
    return base.View();
}
	
}
