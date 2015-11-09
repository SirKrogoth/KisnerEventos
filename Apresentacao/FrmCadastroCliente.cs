using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importando componentes
using Negocio;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente(EnumeradorCliente acao, Cliente cliente)
        {
            InitializeComponent();
            
            if(acao == EnumeradorCliente.Alterar)
            {
                //dados principais do cliente
                this.Text = "Kisner Eventos - Ajuste de cliente";
                txtCodigo.Text = cliente.codCliente.ToString();
                txtNome.Text = cliente.nome;
                dateTimePickerNascimento.Value = cliente.nascimento;
                if (cliente.sexo == "Masculino")
                    radioButtonMasculino.Checked = true;
                else
                    radioButtonFeminino.Checked = true;
                txtRg.Text = cliente.rg;
                mTxtCpf.Text = cliente.cpf;
                mTxtResidencial.Text = cliente.telefone_residencial;
                if (cliente.operadora_celular == "Selecione" || cliente.operadora_celular == "Nao informado")
                    checkBoxInformaCelular.Checked = false;
                else
                {
                    checkBoxInformaCelular.Checked = true;
                    mTxtCelular.Text = cliente.telefone_celular;
                    comboBoxOperadora.Text = cliente.operadora_celular;
                }                  
                //dados de endereço do cliente
                txtRua.Text = cliente.rua;
                txtNumero.Text = cliente.numero.ToString();
                txtBairro.Text = cliente.bairro;
                txtCidade.Text = cliente.cidade;
                comboBoxEstados.Text = cliente.estado;
                mTxtCep.Text = cliente.cep;
                //dados complementares do cliente
                txtEmail.Text = cliente.email;
                txtObservacoes.Text = cliente.observacao;
                dateTimePickerDataCadastro.Value = cliente.cadastro;
                dateTimePickerDataCadastro.Enabled = false;
                if (cliente.ativo == true)
                    comboBoxSituacao.Text = "Ativo";
                else
                    comboBoxSituacao.Text = "Inativo";
                btnGravar.Text = "Alterar";
                btnLimpar.Visible = false;
                btnNovo.Text = "Excluir";
            }
            else            
                dateTimePickerDataCadastro.Value = DateTime.Now;            
        }

        public void gravarRegistro()
        {

             Cliente cliente = new Cliente();

             if (txtNome.Text == "")
             {
                 MessageBox.Show("Favor, informe o nome do cliente.", "Erro ao gravar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else
             {
                 //***Pegando dados do cliente
                 cliente.nome = txtNome.Text;
                 cliente.nascimento = dateTimePickerNascimento.Value;
                 //pegando sexo do cliente
                 if (radioButtonMasculino.Checked == true)
                     cliente.sexo = "Masculino";
                 else
                     cliente.sexo = "Feminino";
                 cliente.rg = txtRg.Text;
                 cliente.cpf = mTxtCpf.Text.ToString();
                 cliente.telefone_residencial = mTxtResidencial.Text.ToString();
                 //pegando celular se checkbox estiver marcada
                 if (checkBoxInformaCelular.Checked == true)
                 {
                     cliente.telefone_celular = mTxtCelular.Text.ToString();
                     cliente.operadora_celular = comboBoxOperadora.SelectedItem.ToString();
                 }
                 cliente.email = txtEmail.Text;
                 cliente.observacao = txtObservacoes.Text;
                 cliente.cadastro = dateTimePickerDataCadastro.Value;
                 if (comboBoxSituacao.Text == "Ativo")
                     cliente.ativo = true;
                 else
                     cliente.ativo = false;
                 //***Pegando dados de endereço do cliente
                 cliente.rua = txtRua.Text;
                 if (txtNumero.Text == "")
                     cliente.numero = 0;
                 else
                     cliente.numero = Convert.ToInt32(txtNumero.Text);
                 cliente.bairro = txtBairro.Text;
                 cliente.cidade = txtCidade.Text;
                 if (comboBoxEstados.Text == "Selecione")
                 {
                     MessageBox.Show("Informe o estado do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 cliente.estado = comboBoxEstados.SelectedItem.ToString();
                 cliente.cep = mTxtCep.Text.ToString();
                 
                 ClienteNegocio clienteNegocio = new ClienteNegocio();
                 string retorno = clienteNegocio.InserirCliente(cliente);

                 try
                 {
                     int converter = Convert.ToInt32(retorno);
                     MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     novoRegistro();
                  }
                 catch
                 {
                     MessageBox.Show("Erro ao inserir cliente.\nContate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }                   
            }       
        }
        //método para alterar um registro

        public void alterarRegistro()
        {
            Cliente cliente = new Cliente();

            if (txtNome.Text == "")
            {
                MessageBox.Show("Favor, informe o nome do cliente.", "Erro ao gravar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //***Pegando dados do cliente
                cliente.codCliente = Convert.ToInt32(txtCodigo.Text);
                cliente.nome = txtNome.Text;
                cliente.nascimento = dateTimePickerNascimento.Value;
                //pegando sexo do cliente
                if (radioButtonMasculino.Checked == true)
                    cliente.sexo = "Masculino";
                else
                    cliente.sexo = "Feminino";
                cliente.rg = txtRg.Text;
                cliente.cpf = mTxtCpf.Text.ToString();
                cliente.telefone_residencial = mTxtResidencial.Text.ToString();
                //pegando celular se checkbox estiver marcada
                if (checkBoxInformaCelular.Checked == true)
                {
                    cliente.telefone_celular = mTxtCelular.Text.ToString();
                    cliente.operadora_celular = comboBoxOperadora.SelectedItem.ToString();
                }
                cliente.email = txtEmail.Text;
                cliente.observacao = txtObservacoes.Text;
                cliente.cadastro = dateTimePickerDataCadastro.Value;
                if (comboBoxSituacao.Text == "Ativo")
                    cliente.ativo = true;
                else
                    cliente.ativo = false;
                //***Pegando dados de endereço do cliente
                cliente.rua = txtRua.Text;
                if (txtNumero.Text == "")
                    cliente.numero = 0;
                else
                    cliente.numero = Convert.ToInt32(txtNumero.Text);
                cliente.bairro = txtBairro.Text;
                cliente.cidade = txtCidade.Text;
                if (comboBoxEstados.Text == "Selecione")
                {
                    MessageBox.Show("Informe o estado do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cliente.estado = comboBoxEstados.SelectedItem.ToString();
                cliente.cep = mTxtCep.Text.ToString();

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                string retorno = clienteNegocio.AlterarCliente(cliente);

                try
                {
                    int converter = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar cliente.\nContate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBoxInformaCelular_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxInformaCelular.Checked == true)
            {
                labelCelular.Visible = true;
                mTxtCelular.Visible = true;
                labelOperadora.Visible = true;
                comboBoxOperadora.Visible = true;
            }
            else
            {
                labelCelular.Visible = false;
                mTxtCelular.Visible = false;
                labelOperadora.Visible = false;
                comboBoxOperadora.Visible = false;
            }
        }

        public void novoRegistro()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            dateTimePickerNascimento.Value = DateTime.Now;
            radioButtonMasculino.Checked = true;
            txtRg.Text = "";
            mTxtCpf.Text = "";
            mTxtResidencial.Text = "";
            checkBoxInformaCelular.Checked = false;
            mTxtCelular.Text = "";
            comboBoxOperadora.Text = "Selecione";
            comboBoxSituacao.Text = "Ativo";
            txtEmail.Text = "";
            txtObservacoes.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            comboBoxEstados.Text = "RS";
            mTxtCep.Text = "";
        }

        public void excluirRegistro()
        {
            DialogResult dialogo = MessageBox.Show("Você tem certeza que quer excluir este cliente?","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(DialogResult.Yes == dialogo)
            {
                Cliente cliente = new Cliente();
                cliente.codCliente = Convert.ToInt32(txtCodigo.Text);

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                string codCliente = clienteNegocio.ExcluirCliente(cliente);

                try
                {
                    int codClienteTeste = Convert.ToInt32(codCliente);
                    MessageBox.Show("Cliente excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    novoRegistro();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir cliente. Contate o Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar" && btnNovo.Text == "Novo")
                gravarRegistro();
            else
                alterarRegistro();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar" && btnNovo.Text == "Novo")
                novoRegistro();
            else
                excluirRegistro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            novoRegistro();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dateTimePickerNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void radioButtonMasculino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void radioButtonFeminino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mTxtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mTxtResidencial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void checkBoxInformaCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mTxtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void comboBoxOperadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtObservacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dateTimePickerDataCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void comboBoxSituacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtRua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void comboBoxEstados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mTxtCep_KeyDown(object sender, KeyEventArgs e)
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