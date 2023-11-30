using Newtonsoft.Json;
using PIM_FolhaUP_Desktop.Models;
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
    public partial class FrmPrincipal : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string apiUrl = "http://localhost:3333/quantidadeempresas"; 

        public FrmPrincipal()
        {
            InitializeComponent();
            ObterContagemDados();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditar editar = new FrmEditar();
            editar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInserir inserir = new FrmInserir();
            inserir.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExcluir excluir = new FrmExcluir();
            excluir.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscar buscar = new FrmBuscar();
            buscar.Show();
        }

        private void pnlEmpresas_Click(object sender, PaintEventArgs e)
        {
            
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpresas empresas = new FrmEmpresas();
            empresas.Show();
        }

        private void btnVerRelatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRelatorios relatorios = new FrmRelatorios();
            relatorios.Show();
        }

        private void btnVerSobreNos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSobreNos sobreNos = new FrmSobreNos();
            sobreNos.Show();
        }


        private async void ObterContagemDados()
        {
            try
            {
                string resposta = await EnviarRequisicaoHTTP(apiUrl, HttpMethod.Get, null);
                // Validar se a resposta é um número inteiro
                lblNumero.Text = resposta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter a contagem de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVerManualUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmManualUsuario manualUsuario = new FrmManualUsuario();
            manualUsuario.Show();
        }
    }
}
