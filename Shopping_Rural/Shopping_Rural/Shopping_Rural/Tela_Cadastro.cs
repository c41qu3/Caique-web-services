using Newtonsoft.Json;
using ShoppingRural.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using Xamarin.Forms;
namespace Shopping_Rural
{
    public class Tela_Cadastro : ContentPage
    {
        public Entry txtNome;
        public Entry txtS_Nome;
        public Entry txtCPF;
        public Entry txtEmail;
        public Entry txtTelefone;
        public Entry txtSenha1;
        public Entry txtSenha2;
        public Entry txtUsuario;
        public Button btnCadastra;

        public Tela_Cadastro()
        {


            txtNome = new Entry
            {
                Placeholder = "Digite o seu nome",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };
            txtS_Nome = new Entry
            {
                Placeholder = "Digite o seu sobrenome",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            txtUsuario = new Entry
            {
                Placeholder = "Digite um nome de usuário",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            txtCPF = new Entry
            {
                Placeholder = "Digite seu CPF",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            txtEmail = new Entry
            {
                Placeholder = "Digite o seu Email",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            txtTelefone = new Entry
            {
                Placeholder = "Digite o seu telefone - ddd xxxx xxxx",
                Keyboard = Keyboard.Telephone,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            txtSenha1 = new Entry
            {
                Placeholder = "Digite sua senha",
                IsPassword = true,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };


            txtSenha2 = new Entry
            {
                Placeholder = "Confirme sua senha",
                IsPassword = true,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };


            btnCadastra = new Button
            {
                Text = "Cadastrar-se",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("#4169E1"),
                TextColor = Color.White
            };

            this.BackgroundColor = Color.White;
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            StackLayout s = new StackLayout
            {
                Children = {
                    txtNome,txtS_Nome,txtUsuario,txtCPF,txtEmail,txtEmail,txtTelefone, txtSenha1,txtSenha2,btnCadastra
                }
            };

            this.Title = "cadastro do vendedor";

            this.Content = new ScrollView { Content = s };
            btnCadastra.Clicked += Go_Cadastro;

        }
        public void Go_Cadastro(object sender, EventArgs e)
        {

            Usuario u = new Usuario();
            u.Nome = txtNome.Text.ToString();

            u.Sobrenome = txtS_Nome.Text.ToString();
            u.Cpf = txtCPF.Text.ToString();
            u.Email = txtEmail.Text.ToString();
            u.Telefone = txtTelefone.Text.ToString();
            u.Senha = txtSenha1.Text.ToString();
            u.DataCadastro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:");
            u.Administrador = false;

            //Post_Cadastro_usuario(u);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Usuario));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, u);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();


            var dados = Encoding.UTF8.GetBytes(jsonString);
            var requisicaoWeb = WebRequest.CreateHttp("http://192.168.0.103/ShoppingRural/API/USUARIO/Post");
            requisicaoWeb.Method = "POST";
            requisicaoWeb.ContentType = "application/x-www-form-urlencoded";
            requisicaoWeb.ContentLength = dados.Length;
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";
            //precisamos escrever os dados post para o stream
            using (var stream = requisicaoWeb.GetRequestStream())
            {
                stream.Write(dados, 0, dados.Length);
                stream.Close();
            }
            //ler e exibir a resposta
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                var post = JsonConvert.DeserializeObject<Usuario>(objResponse.ToString());
                Console.WriteLine(post.Nome);
                streamDados.Close();
                resposta.Close();
            }
            Console.ReadLine();

        }

        public static void Post_Cadastro_usuario(Usuario u)
        {

        }


    }
}


