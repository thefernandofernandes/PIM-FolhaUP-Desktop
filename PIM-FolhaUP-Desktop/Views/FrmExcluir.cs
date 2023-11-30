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

namespace PIM_FolhaUP_Desktop.Views
{
    public partial class FrmExcluir : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:3333/empresas";

        public FrmExcluir()
        {
            InitializeComponent();
        }

        private void FrmExcluir_Load(object sender, EventArgs e)
        {

        }

        private async void btnDeletarEmpresa_Click(object sender, EventArgs e)
        {
            // Validação dos dados
            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                MessageBox.Show("CNPJ é um campo obrigatório.");
                return;
            }
            else
            {
                long cnpj = Int64.Parse(txtCNPJ.Text);
                string resposta = await EnviarRequisicaoHTTP(apiUrl + "/" + cnpj, HttpMethod.Delete);

                if (resposta != null)
                {
                    MessageBox.Show("Empresa excluída com sucesso!");
                }
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscar buscar = new FrmBuscar();
            buscar.Show();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }
    }
}
