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
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

namespace PIM_FolhaUP_Desktop
{
    public partial class FrmRelatorios : Form
    {
        private readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:3333/";

        public FrmRelatorios()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();
            dialogo = MessageBox.Show("Quer mesmo sair do FolhaUp?", "Alerta!", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscar buscar = new FrmBuscar();
            buscar.Show();
        }

        private async void btnRelatoriosEmpresas_Click(object sender, EventArgs e)
        {

            try
            {
                string resposta = await EnviarRequisicaoHTTP(apiUrl + "empresas", HttpMethod.Get);

                if (resposta != null)
                {
                    // Converte a resposta JSON para uma lista de objetos
                    var empresas = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(resposta);

                    // Obtém o caminho para a área de trabalho do usuário
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // Cria o caminho completo do arquivo PDF na área de trabalho
                    string filePath = Path.Combine(desktopPath, "lista_empresas.pdf");

                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);

                            // Adiciona os dados das empresas ao PDF
                            foreach (var empresa in empresas)
                            {
                                foreach (var entry in empresa)
                                {
                                    document.Add(new Paragraph($"{entry.Key}: {entry.Value}"));
                                }
                                document.Add(new AreaBreak());
                            }

                            // Fecha o documento PDF
                            document.Close();
                        }
                    }

                    MessageBox.Show("Lista de empresas salva em PDF. Verifique na sua Área de Trabalho. ", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar empresas e salvar em PDF: " + ex.Message);
            }
        }

    }
}
