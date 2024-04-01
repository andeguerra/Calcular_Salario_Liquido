using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Salario_Liquido
{
    public partial class Form1 : Form
    {
        List<ClassCalculos> lista = new List<ClassCalculos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {             
            string nome = txt_nome.Text;
            double slb = double.Parse(txt_slb.Text);
            double outros_desc = double.Parse(txt_desc.Text);
            double dep = int.Parse(txt_dep.Text) * 189.59;
            double inss = ClassSalarios.CalcularINSS(slb);

            double saldoSL = slb - inss - dep;

            double irrf = ClassSalarios.CalcularIRRF(saldoSL);
            double sll = slb - inss - irrf - outros_desc;

            txt_inss.Text = inss.ToString("c");
            txt_irrf.Text = irrf.ToString("c");
            txt_sliq.Text = sll.ToString("c");

            lista.Add(new ClassCalculos(nome, slb, outros_desc, dep, inss, irrf, sll));
        }

        public void Limpar()
        {
            txt_nome.Clear();
            txt_slb.Clear();
            txt_sliq.Clear();
            txt_inss.Clear();
            txt_irrf.Clear();
            txt_desc.Text = "0";
            txt_dep.Text = "0";
        }

        private void btn_exibirLista_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            foreach (ClassCalculos item in lista) 
            {
                dgvLista.Rows.Insert(0, item.nome, item.inss, item.irrf, item.outros_desc, item.dep, item.sll);
            }
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            string n = txt_buscar.Text;
            List<ClassCalculos> listaBuscar = lista.FindAll(i => i.nome == n);
            if(listaBuscar.Count > 0)
            {
                dgvLista.Rows.Clear();
                foreach (ClassCalculos obj in listaBuscar)
                {
                    dgvLista.Rows.Insert(0, obj.nome, obj.inss, obj.irrf, obj.outros_desc, obj.dep, obj.sll);
                }
            }
            else
            {
                dgvLista.Rows.Clear();
                MessageBox.Show("Não encontrado!");
            }
            

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
