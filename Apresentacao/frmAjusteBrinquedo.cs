﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class frmAjusteBrinquedo : Form
    {
        public frmAjusteBrinquedo()
        {
            InitializeComponent();
            //Importante colocar este parametro para que o grid não atualize de forma errada(desformatado se selecionado o evento click mais de uma vez)
            dataGridViewBrinquedo.AutoGenerateColumns = false;
            atualizarGrid();
        }

        public void atualizarGrid()
        {
            BrinquedoNegocio brinquedoNegocio = new BrinquedoNegocio();
            BrinquedoColecao brinquedoColecao = new BrinquedoColecao();

            //consulta
            brinquedoColecao = brinquedoNegocio.ConsultarNomeBrinquedo(txtBuscar.Text);
            //limpar grid
            dataGridViewBrinquedo.DataSource = null;
            //exibindo dados no grid
            dataGridViewBrinquedo.DataSource = brinquedoColecao;
            dataGridViewBrinquedo.Update();
            dataGridViewBrinquedo.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            if(dataGridViewBrinquedo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não foi selecionado nenhum brinquedo. \nFavor, selecione um brinquedo antes de clicar em ajustar.", "Selecione um brinquedo",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Brinquedo brinquedoSelecionado = (dataGridViewBrinquedo.SelectedRows[0].DataBoundItem as Brinquedo);
                FrmCadastroBrinquedo fcb = new FrmCadastroBrinquedo(EnumeradorBrinquedo.Alterar, brinquedoSelecionado);

                fcb.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastroBrinquedo fcb = new FrmCadastroBrinquedo(EnumeradorBrinquedo.Inserir, null);

            fcb.Show();
        }
    }        
}