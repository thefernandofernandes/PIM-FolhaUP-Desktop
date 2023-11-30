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

namespace PIM_FolhaUP_Desktop
{
    public partial class FrmBuscar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:3333/dados-empresa";
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInserir inserir = new FrmInserir();
            inserir.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditar editar = new FrmEditar();
            editar.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExcluir excluir = new FrmExcluir();
            excluir.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {

        }


        private async void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            // Validação dos dados
            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                MessageBox.Show("CNPJ é um campo obrigatório.");
                return;
            }
            else
            {
                try
                {
                    long cnpj = Int64.Parse(txtCNPJ.Text);
                    string resposta = await EnviarRequisicaoHTTP(apiUrl + "/" + cnpj, HttpMethod.Get);

                    if (resposta != null)
                    {
                        // Converte a resposta JSON para um objeto ou dicionário
                        var dadosEmpresa = JsonConvert.DeserializeObject<Dictionary<string, string>>(resposta);

                        // Verifica se a resposta contém os atributos necessários
                        if (dadosEmpresa.ContainsKey("cnpj") && dadosEmpresa.ContainsKey("razaosocial")
                            && dadosEmpresa.ContainsKey("endereco") && dadosEmpresa.ContainsKey("dataabertura")
                            && dadosEmpresa.ContainsKey("situacaocadastral") && dadosEmpresa.ContainsKey("telefone")
                            && dadosEmpresa.ContainsKey("email") && dadosEmpresa.ContainsKey("senha"))
                        {
                            // Exibe os atributos separadamente
                            // Monta a mensagem com todas as informações
                            string mensagem = $"CNPJ: {dadosEmpresa["cnpj"]}\n" +
                                              $"Razão Social: {dadosEmpresa["razaosocial"]}\n" +
                                              $"Endereço: {dadosEmpresa["endereco"]}\n" +
                                              $"Data de Abertura: {dadosEmpresa["dataabertura"]}\n" +
                                              $"Situação Cadastral: {dadosEmpresa["situacaocadastral"]}\n" +
                                              $"Telefone: {dadosEmpresa["telefone"]}\n" +
                                              $"Email: {dadosEmpresa["email"]}\n" +
                                              $"Senha: {dadosEmpresa["senha"]}";

                            // Exibe todas as informações em um único MessageBox
                            MessageBox.Show(mensagem, "Detalhes da Empresa");
                        }
                        else
                        {
                            MessageBox.Show("Resposta inválida da API");
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido para o CNPJ. Certifique-se de inserir apenas números.");
                }
            }
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
                    // Se a solicitação for bem-sucedida, retornar o conteúdo da resposta
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
