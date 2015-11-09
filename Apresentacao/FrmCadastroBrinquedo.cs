using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocio;

namespace Apresentacao
{
    public partial class FrmCadastroBrinquedo : Form
    {
        public FrmCadastroBrinquedo(EnumeradorBrinquedo acao, Brinquedo brinquedo)
        {
            InitializeComponent();
            
            if(acao == EnumeradorBrinquedo.Alterar)
            {
                this.Text = "Kisner Eventos - Ajuste de brinquedo";
                txtCodigo.Text = brinquedo.codBrinquedo.ToString();
                btnGravar.Text = "Alterar";
                btnNovo.Text = "Excluir";
                btnLimpar.Enabled = false;
                txtNomeBrinquedo.Text = brinquedo.nome;
                if (brinquedo.ativo == true)
                    cbSituacao.SelectedItem = "Ativo";
                else
                    cbSituacao.SelectedItem = "Inativo";
                dateTimePickerBrinquedo.Value = brinquedo.cadastro;
                txtValor.Text = brinquedo.valor.ToString();

            }
            else
                dateTimePickerBrinquedo.Value = DateTime.Now;
        }

        private void GravarRegistro()
        {
            Brinquedo brinquedo = new Brinquedo();

            brinquedo.nome = txtNomeBrinquedo.Text;
            brinquedo.cadastro = DateTime.Now;

            if (cbSituacao.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação do brinquedo.", "Error ao cadastrar brinquedo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbSituacao.SelectedItem.ToString() == "Ativo")
                    brinquedo.ativo = true;
                else
                    brinquedo.ativo = false;
            }

            brinquedo.valor = Convert.ToDouble(txtValor.Text);

            BrinquedoNegocio brinquedoNegocio = new BrinquedoNegocio();
            if (txtNomeBrinquedo.Text == "")
            {
                MessageBox.Show("Favor, informe o nome do brinquedo.", "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Inserindo dados no banco
                string retorno = brinquedoNegocio.InserirBrinquedo(brinquedo);

                try
                {
                    int codBrinquedo = Convert.ToInt32(retorno);
                    MessageBox.Show("Brinquedo inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    novo();
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir brinquedo. Contate o Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void AlterarRegistro()
        {
            Brinquedo brinquedo = new Brinquedo();

            brinquedo.codBrinquedo = Convert.ToInt32(txtCodigo.Text);
            brinquedo.nome = txtNomeBrinquedo.Text;
            brinquedo.cadastro = DateTime.Now;

            if (cbSituacao.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação do brinquedo.", "Situação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbSituacao.SelectedItem.ToString() == "Ativo")
                    brinquedo.ativo = true;
                else
                    brinquedo.ativo = false;
            }

            brinquedo.valor = Convert.ToDouble(txtValor.Text);

            BrinquedoNegocio brinquedoNegocio = new BrinquedoNegocio();
            if (txtNomeBrinquedo.Text == "")
            {
                MessageBox.Show("Favor, informe o nome do brinquedo.", "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Inserindo dados no banco
                string retorno = brinquedoNegocio.AlterarBrinquedo(brinquedo);

                try
                {
                    int codBrinquedo = Convert.ToInt32(retorno);
                    MessageBox.Show("Brinquedo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar brinquedo. Contate o Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Alterar" && btnNovo.Text == "Excluir")
                AlterarRegistro();
            else
                GravarRegistro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeBrinquedo.Text = "";
            cbSituacao.Text = "Ativo";
        }
        //Evento novo e evento excluir
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Excluir")
            {
                Brinquedo b = new Brinquedo();

                b.codBrinquedo = Convert.ToInt32(txtCodigo.Text);
                b.nome = txtNomeBrinquedo.ToString();
                b.cadastro = Convert.ToDateTime(dateTimePickerBrinquedo.Value);
                b.ativo = Convert.ToBoolean(cbSituacao.SelectedValue);

                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este brinquedo?", "Excluir brinquedo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else
                {
                    BrinquedoNegocio bn = new BrinquedoNegocio();

                    string retorno = bn.ExcluirBrinquerdo(b);

                    try
                    {
                        int converteInteiro = Convert.ToInt32(retorno);
                        MessageBox.Show("Brinquedo excluido com sucesso.", "Excluido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        novo();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir brinquedo. \nContate o Administrador.", "Erro ao excluir brinquedo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                novo();
            
        }

        private void novo()
        {
            txtNomeBrinquedo.Text = "";
            cbSituacao.Text = "Ativo";
            txtValor.Text = "0,00";
            dateTimePickerBrinquedo.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBrinquedo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeBrinquedo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dateTimePickerBrinquedo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cbSituacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnGravar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}