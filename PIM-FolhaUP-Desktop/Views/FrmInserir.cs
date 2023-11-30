using PIM_FolhaUP_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PIM_FolhaUP_Desktop.Views;

namespace PIM_FolhaUP_Desktop
{
    public partial class FrmInserir : Form
    {
        //Declarando variáveis para acesso da API do Backend
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:3333/empresas";

        public FrmInserir()
        {
            InitializeComponent();
        }

        //Função para enviar a Requisição HTTP que retorna o URL e qual o método utilizado.
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Abrindo um novo formulário
            this.Hide();
            FrmEditar editar = new FrmEditar();
            editar.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Abrindo um novo formulário
            this.Hide();
            FrmExcluir excluir = new FrmExcluir();
            excluir.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Abrindo um novo formulário
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Criando uma caixa de diálogo para confirmação
            DialogResult dialogo = new DialogResult();
            dialogo = MessageBox.Show("Quer mesmo sair do FolhaUp?", "Alerta!", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
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
                InserirEmpresa();
                //Chamando o método LimparDados()
                LimparDados();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chamando o método LimparDados()
            LimparDados();
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

        private async void InserirEmpresa()
        {
            Empresa empresa = new Empresa();
            empresa.setCNPJ(Int64.Parse(txtCNPJ.Text.ToString()));
            empresa.setRazaoSocial(txtRazaoSocial.Text);
            empresa.setEndereco(txtEndereco.Text + ", " + txtNumero.Text + ", " + txtCidade.Text + ", " + cbUF.SelectedItem + ", " + txtCEP.Text);
            //empresa.setDataAbertura(txtDataAbertura.Text);
            empresa.setTelefone(txtTelefone.Text);
            empresa.setEmail(txtEmail.Text);
            empresa.setSenha(txtSenha.Text);
            empresa.setSituacaoCadastral(true);

            if (radioInativo.Checked)
            {
                empresa.setSituacaoCadastral(false);
            }

            if (DateTime.TryParseExact(txtDataAbertura.Text, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataFormatada))
            {
                //Criando Objeto JSON para enviar os dados do usuário para o Banco de Dados
                var usuarioData = new
                {
                    cnpj = empresa.getCNPJ(),
                    razaosocial = empresa.getRazaoSocial(),
                    endereco = empresa.getEndereco(),
                    dataabertura = dataFormatada.ToString("yyyy-MM-dd"), // Formatando para o formato que a API espera (exemplo: "yyyy-MM-dd")
                    situacaocadastral = empresa.getSituacaoCadastral(),
                    telefone = empresa.getTelefone(),
                    email = empresa.getEmail(),
                    senha = empresa.getSenha(),
                };

                //Convertendo Objeto para JSON
                var json = JsonConvert.SerializeObject(usuarioData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                //Enviando requisição com o método Post
                string resposta = await EnviarRequisicaoHTTP(apiUrl, HttpMethod.Post, content);


                //Verificando se foi enviado
                if (resposta != null)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!");
                    LimparDados();
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscar buscar = new FrmBuscar();
            buscar.Show();
        }
    }
}
