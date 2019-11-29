using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ConsumindoWebApiCadastroPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoPessoa = 1;

        private void BtnObterPessoa_Click(object sender, EventArgs e)
        {
            GetAllPessoas();
        }

        private void BtnPessoaPorCate_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoPessoa != -1)
            {
                GetPessoaById(codigoPessoa);
            }
        }

        private void BtnIncluirPessoa_Click(object sender, EventArgs e)
        {
            AddPessoa();
        }

        private void BtnAtualizaPessoa_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoPessoa != -1)
            {
                UpdatePessoa(codigoPessoa);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoPessoa != -1)
            {
                DeletePessoa(codigoPessoa);
            }
        }

        private void InputBox()
        {
            string Prompt = "Informe o código do Produto.";
            string Titulo = "www.macoratti.net";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (Resultado != "")
            {
                codigoPessoa = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoPessoa = -1;
            }
        }

        private async void GetAllPessoas()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        
                        var PessoaJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Pessoa[]>(PessoaJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetPessoaById(int codPessoa)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + codPessoa.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var PessoaJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Pessoa>(PessoaJsonString);
                    dgvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o pessoa : " + response.StatusCode);
                }
            }
        }

        private async void AddPessoa()
        {
            URI = txtURI.Text;
            Pessoa pess = new Pessoa();
            //pess.Id = codPessoa;
            pess.Categoria = "Pessoa Física";
            pess.Nome = "João Pedro";
            pess.Endereco = "Avenida x 234";
            pess.Bairro = "Aldeota";
            pess.Cidade = "Fortaleza";
            pess.Estado = "Ceará";
            pess.Telefone = "998895478";
            pess.Email = "pessoay@gmail.com";

            using (var client = new HttpClient())
            {
                var serializedPessoa = JsonConvert.SerializeObject(pess);
                var content = new StringContent(serializedPessoa, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllPessoas();
        }

        private async void UpdatePessoa(int codPessoa)
        {
            URI = txtURI.Text;
            Pessoa pess = new Pessoa();
            //pess.Id = codPessoa;
            pess.Id = codPessoa;
            pess.Categoria = "Pessoa Física";
            pess.Nome = "Pedro Paulo";
            pess.Endereco = "Avenida i 234";
            pess.Bairro = "Aldeota";
            pess.Cidade = "Fortaleza";
            pess.Estado = "Ceará";
            pess.Telefone = "998895452";
            pess.Email = "pessoapp@gmail.com";// atualizando o preço do produto

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + pess.Id, pess);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pessoa atualizada");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o pessoa : " + responseMessage.StatusCode);
                }
            }
            GetAllPessoas();
        }


        private async void DeletePessoa(int codPessoa)
        {
            URI = txtURI.Text;
            int PessoaID = codPessoa;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, PessoaID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pessoa excluída com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir pessoa  : " + responseMessage.StatusCode);
                }
            }
            GetAllPessoas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
