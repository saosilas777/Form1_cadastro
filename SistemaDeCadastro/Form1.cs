using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaDeCadastro.Entities;

    
namespace SistemaDeCadastro
{
    public partial class Cadastro : Form
    {
        List<Pessoas> pessoa;
        public Cadastro()
        {
            InitializeComponent();
            pessoa = new List<Pessoas>();

            status1.Items.Add("Solteiro(a)");
            status1.Items.Add("Casado(a)");
            status1.Items.Add("Viúvo(a)");
            status1.Items.Add("Divorciado(a)");
            status1.SelectedIndex = 0;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach(Pessoas x in pessoa)
            {
                if(x.Name == Box1.Text)
                {
                    index = pessoa.IndexOf(x);
                }
            }

            if(Box1.Text == "")
            {
                MessageBox.Show("Preencha o campo nome");
                Box1.Focus();
                return;
            }
            if(Phone1.Text == "(  )     -")
            {
                MessageBox.Show("Preencha o telefone");
                Phone1.Focus();
                return;
            }

            char sexo;

            if (Masculino.Checked)
            {
                sexo = 'M';
            }
            else if (Feminino.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            

            Pessoas p = new Pessoas();
            p.Name = Box1.Text;
            p.BirthDate = DateTime.Parse(date1.Text);
            p.Phone = Phone1.Text;
            p.Status = status1.SelectedItem.ToString();
            p.Casa = casa1.Checked;
            p.Veiculo = veiculo1.Checked;
            p.Sexo = sexo;

            if(index < 0)
            {
                pessoa.Add(p);
            }
            else
            {
                pessoa[index] = p;
            }

            btnlimpar_Click(btnlimpar, EventArgs.Empty);
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = listaDeCadastros.SelectedIndex;
            pessoa.RemoveAt(indice);
            Listar();
           
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Box1.Text = "";
            date1.Text = "";
            status1.SelectedIndex = 0;
            Phone1.Text = "";
            casa1.Checked = false;
            veiculo1.Checked = false;
            Masculino.Checked = true;
            Box1.Focus();
        }

        private void Listar()
        {
            listaDeCadastros.Items.Clear();

            foreach(Pessoas x in pessoa)
            {
                listaDeCadastros.Items.Add(x.ToString());
            }
        }

        private void listaDeCadastros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listaDeCadastros.SelectedIndex;
            Pessoas p = pessoa[indice];

            Box1.Text = p.Name;
            date1.Text = p.BirthDate.ToString();
            status1.SelectedItem = p.Status;
            Phone1.Text = p.Phone;
            casa1.Checked = p.Casa;
            veiculo1.Checked = p.Veiculo;

            if(p.Sexo == 'M')
            {
                Masculino.Checked = true;
            }
            else if(p.Sexo == 'F')
            {
                Feminino.Checked = true;
            }
            else
            {
                OutroSexo.Checked = true;
            }


        }
    }
}
