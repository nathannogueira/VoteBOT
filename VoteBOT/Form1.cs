using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace VoteBOT
{

    public partial class Form1 : Form
    {
        public CookieContainer cookieJar = new CookieContainer();
        public WebProxy myProxy = new WebProxy();
        static readonly HttpClient client = new HttpClient();

        string email = "";
        string name = "";
        string cpf = "";
        string phone = "";
        string cpf_login = "";
        string login_password = "";
        string id = "2081";

        bool Cadastrado = false;
        bool Logado = false;
        bool Votado = false;
        bool Deslogado = true;

        int Contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //########################################################################################################################

        //GERAR NOME
        public static string GerarNome()
        {
            var result = "";
            var resultnome = "";
            var nomes = new[] { "Maria", "Fabio", "Jose", "Julia", "Francisco", "Luiz", "Rafael", "Daniel" };
            var sobrenomes = new[] { "Silva", "Cavalcante", "Oliveira", "Souza", "Lima", "Costa", "Pereira", "Ferreira", "Monteiro", "Chagas" };
            var nomeInRandomOrder = nomes.OrderBy(i => Guid.NewGuid());
            var sobrenomeInRandomOrder = sobrenomes.OrderBy(i => Guid.NewGuid());

            foreach (var nome in nomeInRandomOrder)
            {
                resultnome = nome;
            }

            foreach (var sobrenome in sobrenomeInRandomOrder)
            {
                result = resultnome + " " + sobrenome;
            }

            return result;
        }

        //########################################################################################################################

        //GERAR EMAIL HOTMAIL
        public static string GerarEmail()
        {
            var chars = "abcdefghijklmnopqrstuvxywz";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 12)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result + "@hotmail.com";
        }

        //########################################################################################################################

        //GERAR TELEFONE
        public static string GerarPhone()
        {
            var chars = "1234567890";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return Convert.ToUInt64(result).ToString(@"(11) 90000\-0000");
        }

        //########################################################################################################################

        //GERAR CPF VÁLIDO
        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;

            return Convert.ToUInt64(semente).ToString(@"000\.000\.000\-00");
        }

        //########################################################################################################################

        //GERA UM FORMULÁRIO PARA CADASTRO
        public async Task GerarDadosNovos()
        {
            cpf = GerarCpf();
            email = GerarEmail();
            phone = GerarPhone();
            name = GerarNome();
        }

        //########################################################################################################################

        async public void Looping()
        {
            GerarDadosNovos();
            await Task.Delay(1000);
            if (Cadastrado == false && Logado == false && Votado == false && Deslogado == true)
            {
                SubmitCadastrar();
            }
            if (Cadastrado == true && Logado == false && Votado == false && Deslogado == true)
            {
                SubmitLogar();
            }
            if (Cadastrado == true && Logado == true && Votado == false && Deslogado == false)
            {
                SubmitVotar();
            }
            if (Cadastrado == true && Logado == true && Votado == true && Deslogado == false)
            {
                SubmitDeslogar();
                Cadastrado = false;
                Logado = false;
                Votado = false;
                Deslogado = true;
            }
        }

        //########################################################################################################################

        //ENVIAR REQUISIÇÃO DE CADASTRO
        async public void SubmitCadastrar()
        {
            try
            {

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "email=" + email + "&name=" + name + "&cpf=" + cpf + "&phone=" + phone + "&cpf_login=" + cpf_login + "&login_password=" + login_password;
                byte[] data = encoding.GetBytes(postData);

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://valorizeseutalento.com.br/votacao/criar");
                myWebRequest.Method = "POST";
                myWebRequest.ContentType = "application/x-www-form-urlencoded";
                myWebRequest.ContentLength = data.Length;

                Stream stream = myWebRequest.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                stream = myWebResponse.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                Cadastrado = true;
                LabelStatus.Text = "Efetuado cadastro com sucesso!";
                bunifuProgressBar1.Value = 30;

                sr.Close();
                stream.Close();
            }
            catch (WebException ex)
            {
                LabelStatus.Text = "Erro ao cadastrar: " + ex.Message;
                SubmitDeslogar();
            }
        }

        //########################################################################################################################

        //ENVIAR REQUISIÇÃO DE LOGON
        async public void SubmitLogar()
        {
            try
            {

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "email=" + email + "&cpf=" + cpf;
                byte[] data = encoding.GetBytes(postData);

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://valorizeseutalento.com.br/votacao/login");
                myWebRequest.Method = "POST";
                myWebRequest.CookieContainer = cookieJar;
                myWebRequest.ContentType = "application/x-www-form-urlencoded";
                myWebRequest.ContentLength = data.Length;

                Stream stream = myWebRequest.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                stream = myWebResponse.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                Logado = true;
                Deslogado = false;
                LabelStatus.Text = "Efetuado login!";
                bunifuProgressBar1.Value = 60;

                sr.Close();
                stream.Close();

                //Adicionar cookies ao CookieJar (Cookie Container)
                foreach (Cookie cookie in myWebResponse.Cookies)
                {
                    cookieJar.Add(new Cookie(cookie.Name.Trim(), cookie.Value.Trim(), cookie.Path, cookie.Domain));
                }
            }
            catch (WebException ex)
            {
                LabelStatus.Text = "Erro ao efetuar login: " + ex.Message + "\n";
            }
        }

        //########################################################################################################################

        //ENVIAR REQUISIÇÃO DE VOTAR
        async public void SubmitVotar()
        {
            try
            {

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "id=" + id;
                byte[] data = encoding.GetBytes(postData);

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://valorizeseutalento.com.br/votacao/votar");
                myWebRequest.Method = "POST";
                myWebRequest.CookieContainer = cookieJar;
                myWebRequest.ContentType = "application/x-www-form-urlencoded";
                myWebRequest.ContentLength = data.Length;

                Stream stream = myWebRequest.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                stream = myWebResponse.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                Votado = true;
                LabelStatus.Text = "Voto enviado com sucesso!";
                bunifuProgressBar1.Value = 100;
                Contador++;
                Looping();

                sr.Close();
                stream.Close();
            }
            catch (WebException ex)
            {
                LabelStatus.Text = "Tentando enviar voto novamente...";
                await Task.Delay(10000);
                SubmitVotar();
            }
        }

        //########################################################################################################################

        //ENVIAR REQUISIÇÃO DE DESLOGAR
        async public void SubmitDeslogar()
        {
            try
            {
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://valorizeseutalento.com.br/logout");
                myWebRequest.Method = "GET";
                myWebRequest.CookieContainer = cookieJar;

                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Console.WriteLine(((HttpWebResponse)myWebResponse).StatusDescription);

                using (Stream stream = myWebResponse.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    Deslogado = true;
                }

                //LIMPAR COOKIES
                var cookies = cookieJar.GetCookies(new Uri("https://valorizeseutalento.com.br/"));
                foreach (Cookie cookieJar in cookies)
                {
                    cookieJar.Expires = DateTime.Now.Subtract(TimeSpan.FromDays(1));
                }

                myWebResponse.Close();
                Looping();
            }
            catch (WebException ex)
            {
                LabelStatus.Text = "Erro ao deslogar: " + ex.Message;
            }
        }

        //########################################################################################################################

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //########################################################################################################################

        //TIMER CONTADOR DE VOTOS
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelContador.Text = Convert.ToString(Contador);
        }

        //########################################################################################################################

        //BOTÃO DE FECHAR
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //########################################################################################################################

        //ACESSAR FACEBOOK
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/NathanNogueiraR");
        }

        //########################################################################################################################

        //ACESSAR WHATSAPP
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=+5522998792925");
        }

        //########################################################################################################################

        //ACESSAR LINKEDIN
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/nathannogueirar");
        }

        //########################################################################################################################

        //LIGAR BOT
        private void buttonLigar_Click(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.animated = true;
            bunifuCircleProgressbar1.Value = 20;
            Looping();
        }

        //########################################################################################################################

        //DESLIGAR BOT
        private void buttonDesligar_Click(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.animated = false;
            bunifuCircleProgressbar1.Value = 0;
            Application.Restart();

        }

    }
}
