using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppHotelForms
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscarCep_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBuscarCep.Text))
            {
                MessageBox.Show("CAMPO EM BRANCO! DIGITE UM CEP...", "ERRO CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscarCep.Focus();
            }
            else
            {

                string urlJsonCep = $"https://viacep.com.br/ws/{txtBuscarCep.Text.Trim()}/json/";
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(urlJsonCep).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            ObjetosJsonCep objetosJson = JsonConvert.DeserializeObject<ObjetosJsonCep>(result);

                            txtBoxBairroCadastro.Text = objetosJson.Bairro;
                            txtBoxCidadeCadastro.Text = objetosJson.Localidade;
                            txtBoxEstadoCadastro.Text = objetosJson.Uf;
                            txtBoxRuaCadastro.Text = objetosJson.Logradouro;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void linkLabelTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlJsonCep = $"https://viacep.com.br/ws/{txtBuscarCep.Text.Trim()}/json/";
            System.Diagnostics.Process.Start(urlJsonCep);
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtBoxBairroCadastro.Clear();
            txtBoxCidadeCadastro.Clear();
            txtBoxEstadoCadastro.Clear();
            txtBoxRuaCadastro.Clear();
            txtBuscarCep.Clear();
            txtBuscarCep.Focus();

        }

        private void button2_Click(object sender, EventArgs e)//BtnCadastrar
        {
            if (string.IsNullOrWhiteSpace(txtBoxNomeCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmailCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCpfCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTelefoneCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSenhaCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxConfirmarSenhaCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEstadoCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCidadeCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBairroCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxRuaCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNumeroCasaCadastro.Text) ||
                txtBoxSenhaCadastro.Text != txtBoxConfirmarSenhaCadastro.Text)
            {
                MessageBox.Show("Existem informacões não preenchidas corretamente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-*******\\SQLEXPRESS;Initial Catalog=Hotel-*******;Integrated Security=True";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        //conn.Open();
                        //MessageBox.Show("Conexão com o SQL Server aberta com sucesso");
                        string sql = @"
                        INSERT INTO Usuarios
                        (Nome, Email, Cpf, Telefone, Senha, Cep, Estado, Cidade, Bairro, Rua, Numero)
                        VALUES
                        (@Nome, @Email, @Cpf, @Telefone, @Senha, @Cep, @Estado, @Cidade, @Bairro, @Rua, @Numero)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Nome", txtBoxNomeCadastro.Text);
                        cmd.Parameters.AddWithValue("@Email", txtBoxEmailCadastro.Text);
                        cmd.Parameters.AddWithValue("@Cpf", txtBoxCpfCadastro.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtBoxTelefoneCadastro.Text);
                        cmd.Parameters.AddWithValue("@Senha", txtBoxSenhaCadastro.Text);
                        cmd.Parameters.AddWithValue("@Cep", txtBuscarCep.Text);
                        cmd.Parameters.AddWithValue("@Estado", txtBoxEstadoCadastro.Text);
                        cmd.Parameters.AddWithValue("@Cidade", txtBoxCidadeCadastro.Text);
                        cmd.Parameters.AddWithValue("@Bairro", txtBoxBairroCadastro.Text);
                        cmd.Parameters.AddWithValue("@Rua", txtBoxRuaCadastro.Text);
                        cmd.Parameters.AddWithValue("@Numero", txtBoxNumeroCasaCadastro.Text);

                        conn.Open();
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso", "TUDO CERTO", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                



                
            }


        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
