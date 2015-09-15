using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmVisualizadorContrato : Form
    {
        string codEvento = null;
        public FrmVisualizadorContrato()
        {
            InitializeComponent();
        }

        public FrmVisualizadorContrato(string codEvento)
        {
            InitializeComponent();

            this.codEvento = codEvento;
        }

        private void FrmVisualizadorContrato_Load(object sender, EventArgs e)
        {
            //ReportDocument report = new ReportDocument();
            //report.Load("C:\\Users\\João\\Documents\\Video Aulas\\Canal Professor Drausion\\1° Temporada\\KISNER_EVENTOS\\Apresentacao\\Relatorios\\Contrato\\RelContrato.rpt");            
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //report.Load("\\Relatorios\\Contrato\\RelContrato.rpt");
            Relatorios.Contrato.RelContrato report = new Relatorios.Contrato.RelContrato();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = codEvento;
            crParameterFieldDefinitions = report.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ParCodEvento"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            //trabalhando com os brinquedos escolhidos pelo usuário! Usando DataSet
            /*Relatorios.Contrato.DsEventoBrinquedo eb = new Relatorios.Contrato.DsEventoBrinquedo();
            DataTable brinquedos = eb.Tables.Add("DtBrinquedo");

            brinquedos.Columns.Add("codBrinquedo", Type.GetType("System.Int32"));
            brinquedos.Columns.Add("nome", Type.GetType("System.String"));

            BrinquedoColecao bc = new BrinquedoColecao();
            */
            

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh(); 

        }
    }
}