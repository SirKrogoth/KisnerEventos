﻿using System;
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
    public partial class FrmCadastroServico : Form
    {
        public FrmCadastroServico(EnumeradorServico acao, Servico servico)
        {
            InitializeComponent();

            if(EnumeradorServico.Alterar == acao)
            {
                this.Text = "Kisner Eventos - Ajuste de Serviço";
                txtCodigo.Text = servico.codServico.ToString(); ;
                txtNome.Text = servico.descricao;
                txtValor.Text = servico.valor.ToString();
                dtpCriacao.Value = servico.cadastro;
                if (servico.ativo == true)
                    cmSituaco.SelectedItem = "Ativo";
                else
                    cmSituaco.SelectedItem = "Inativo";
                btnGravar.Text = "Alterar";
                btnNovo.Text = "Excluir";
                btnLimpar.Visible = false;
            }
            else
                dtpCriacao.Value = DateTime.Now;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar" && btnNovo.Text == "Novo" && btnLimpar.Text == "Limpar")
                gravarRegistro();
            else
                alterarRegistro();
        }

        public void alterarRegistro()
        {
            Servico servico = new Servico();
            ServicoNegocio servicoNegocio = new ServicoNegocio();

            servico.codServico = Convert.ToInt32(txtCodigo.Text);
            servico.descricao = txtNome.Text;
            servico.valor = Convert.ToDouble(txtValor.Text);

            if (cmSituaco.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação do serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                
            else
            {
                if (cmSituaco.SelectedItem.ToString() == "Ativo")
                    servico.ativo = true;
                else
                    servico.ativo = false;
            }

            string retorno = servicoNegocio.AlterarServico(servico);
            //teste
            try
            {
                int converter = Convert.ToInt32(retorno);
                MessageBox.Show("Registro alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possível alterar registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gravarRegistro()
        {
            Servico servico = new Servico();

            servico.descricao = txtNome.Text;
            servico.valor = Convert.ToDouble(txtValor.Text);
            if(cmSituaco.Text == "Selecione")
            {
                MessageBox.Show("Favor, informe a situação do serviço cadastrado.", "Erro ao cadastrar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cmSituaco.SelectedItem.ToString() == "Ativo")
                    servico.ativo = true;
                else
                    servico.ativo = false;
            }            
            servico.cadastro = Convert.ToDateTime(dtpCriacao.Value);

            ServicoNegocio servicoNegocio = new ServicoNegocio();

            string codServico = servicoNegocio.InserirServico(servico);

            try
            {
                int testeCodigoServico = Convert.ToInt32(codServico);
                MessageBox.Show("Serviço inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novoRegistro();
            }
            catch
            {
                MessageBox.Show("Erro ao inserir registro.\nContate o Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void excluirRegistro()
        {
            Servico servico = new Servico();
            ServicoNegocio servicoNegocio = new ServicoNegocio();

            servico.codServico = Convert.ToInt32(txtCodigo.Text);

            DialogResult dialogo = MessageBox.Show("Você tem certeza que deseja excluir este serviço?","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult.Yes == dialogo)
            {
                string retorno = servicoNegocio.DeletarServico(servico);

                try
                {
                    int testeRetorno = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }                            
        }

        public void novoRegistro()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtValor.Text = "";
            cmSituaco.Text = "Selecione";
            dtpCriacao.Value = DateTime.Now;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar" && btnNovo.Text == "Novo" && btnLimpar.Text == "Limpar")
                novoRegistro();
            else
                excluirRegistro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            novoRegistro();
        }
    }
}