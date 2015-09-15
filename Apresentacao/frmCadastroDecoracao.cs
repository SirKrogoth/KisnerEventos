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
    public partial class frmCadastroDecoracao : Form
    {
        public frmCadastroDecoracao(EnumDecoracao acao, Decoracao decoracao)
        {
            InitializeComponent();

            if (acao == EnumDecoracao.Alterar)
            {
                this.Text = "Kisner Eventos - Ajuste de Decoracao";
                txtCodigo.Text = decoracao.codDecoracao.ToString();
                txtNomeDecoracao.Text = decoracao.nome;
                btnGravar.Text = "Alterar";
                btnNovo.Text = "Excluir";
                btnLimpar.Enabled = false;
                dateTimePickerCriacao.Value = decoracao.cadastro;
                if (decoracao.ativo == true)
                    cbSituacao.SelectedItem = "Ativo";
                else
                    cbSituacao.SelectedItem = "Inativo";
                txtValor.Text = decoracao.valor.ToString();
            }
            else
                dateTimePickerCriacao.Value = DateTime.Now;
        }

        private void novo()
        {
            txtNomeDecoracao.Text = "";
            cbSituacao.Text = "Selecione";
            dateTimePickerCriacao.Value = DateTime.Now;
        }

        private void excluirRegistro()
        {
            Decoracao decoracao = new Decoracao();

            decoracao.codDecoracao = Convert.ToInt32(txtCodigo.Text);
            decoracao.nome = txtNomeDecoracao.Text;
            decoracao.cadastro = Convert.ToDateTime(dateTimePickerCriacao.Value);
            decoracao.ativo = Convert.ToBoolean(cbSituacao.SelectedValue);

            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir esta decoração?","Excluir decoração",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
                return;
            else
            {
                DecoracaoNegocio decoracaoNegocio = new DecoracaoNegocio();

                string retorno = decoracaoNegocio.ExcluirDecoracao(decoracao);

                try
                {
                    int codDecoracao = Convert.ToInt32(retorno);
                    MessageBox.Show("Decoracao excluida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    novo();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir decoração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Excluir")
                excluirRegistro();
            else
                novo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeDecoracao.Text = "";
            cbSituacao.Text = "Selecione";
            dateTimePickerCriacao.Value = DateTime.Now;
        }

        private void gravarRegistro()
        {
            Decoracao d = new Decoracao();
            
            d.nome = txtNomeDecoracao.Text;
            d.cadastro = DateTime.Now;

            if (cbSituacao.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação da decoração cadastrada", "Erro ao cadastrar decoração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbSituacao.SelectedItem.ToString() == "Ativo")
                    d.ativo = true;
                else
                    d.ativo = false;
            }

            d.valor = Convert.ToDouble(txtValor.Text);

            DecoracaoNegocio dn = new DecoracaoNegocio();

            string retorno = dn.InserirDecoracao(d);

            try
            {
                int codBrinquedo = Convert.ToInt32(retorno);
                MessageBox.Show("Decoracao inserida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novo();
            }
            catch
            {
                MessageBox.Show("Não foi possível inserir nova decoração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarRegistro()
        {
            Decoracao decoracao = new Decoracao();

            decoracao.codDecoracao = Convert.ToInt32(txtCodigo.Text);
            decoracao.nome = txtNomeDecoracao.Text;
            decoracao.cadastro = dateTimePickerCriacao.Value;
            
            if(cbSituacao.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação desta decoração.","Situação inválida",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbSituacao.SelectedItem.ToString() == "Ativo")
                    decoracao.ativo = true;
                else
                    decoracao.ativo = false;
            }

            decoracao.valor = Convert.ToDouble(txtValor.Text);

            DecoracaoNegocio decoracaoNegocio = new DecoracaoNegocio();

            if(txtNomeDecoracao.Text == "")
            {
                MessageBox.Show("Favor, informe o nome da decoração.", "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string retorno = decoracaoNegocio.AlterarDecoracao(decoracao);

                try
                {
                    int codDecoracao = Convert.ToInt32(retorno);
                    MessageBox.Show("Decoração alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    novo();
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar decoração. Contate o Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Alterar" && btnNovo.Text == "Excluir")
                alterarRegistro();
            else
                gravarRegistro();                
        }
    }
}