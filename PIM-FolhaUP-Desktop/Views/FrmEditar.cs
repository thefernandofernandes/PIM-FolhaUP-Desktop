using Newtonsoft.Json;
using PIM_FolhaUP_Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIM_FolhaUP_Desktop
{
    public partial class FrmEditar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:3333/empresas";

        public FrmEditar()
        {
            InitializeComponent();
        }

        private async Task<string> EnviarRequisicaoHTTP(string url, HttpMethod metodo, HttpContent content = null)
        {
            try
            {
                var requisicao = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = metodo,
                    Content = content
                };

                requisicao.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var resposta = await client.SendAsync(requisicao);

                if (resposta.IsSuccessStatusCode)
                {
                    return await resposta.Content.ReadAsStringAsync();
                }
                else
                {
                    string errorMessage = "Erro na solicitação HTTP: " + resposta.StatusCode;
                    MessageBox.Show(errorMessage);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação HTTP: " + ex.Message);
                return null;
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExcluir excluir = new FrmExcluir();
            excluir.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInserir inserir = new FrmInserir();
            inserir.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnEnviarEdicao_Click(object sender, EventArgs e)
        {
            // Validação dos dados
            if (string.IsNullOrWhiteSpace(txtCNPJ.Text) || string.IsNullOrWhiteSpace(txtRazaoSocial.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) || string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(cbUF.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Todos os campos são campos obrigatórios.");
                return;
            }
            else
            {
                //Chamando o método InserirEmpresa()
                EditarEmpresa();
                //Chamando o método LimparDados()
                LimparDados();
            }
        }

        private void LimparDados()
        {
            // Limpando os dados do formulário
            txtCNPJ.Clear();
            txtRazaoSocial.Clear();
            txtDataAbertura.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            cbUF.SelectedItem = 0;
            txtTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

        }

        private async void EditarEmpresa()
        {
            //Declarando variáveis
            long cnpj;
            string razaosocial, endereco, telefone, email, senha;
            Boolean situacaocadastral = true;

            //Inserindo os valores dos TextBox's nas variáveis
            cnpj = Int64.Parse(txtCNPJ.Text.ToString());
            razaosocial = txtRazaoSocial.Text;
            endereco = (txtEndereco.Text + ", " + txtNumero.Text + ", " + txtCidade.Text + ", " + cbUF.SelectedItem + ", " + txtCEP.Text);
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;

            if (radioInativo.Checked)
            {
                situacaocadastral = false;
            }
            if (DateTime.TryParseExact(txtDataAbertura.Text, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataFormatada))
            {
                //Criando Objeto JSON para enviar os dados do usuário para o Banco de Dados
                var usuarioData = new
                {
                    razaosocial,
                    endereco,
                    dataabertura = dataFormatada.ToString("yyyy-MM-dd"), // Formatando para o formato que a API espera (exemplo: "yyyy-MM-dd")
                    situacaocadastral,
                    telefone,
                    email,
                    senha
                };

                var json = JsonConvert.SerializeObject(usuarioData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string resposta = await EnviarRequisicaoHTTP(apiUrl + "/" + cnpj, HttpMethod.Put, content);

                if (resposta != null)
                {
                    MessageBox.Show("Empresa atualizada com sucesso!");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();
            dialogo = MessageBox.Show("Quer mesmo sair do FolhaUp?", "Alerta!", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
