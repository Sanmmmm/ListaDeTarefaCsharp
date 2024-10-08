﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.app
{
    public partial class Form1 : Form
    {
        private List<string> tarefas = new List<string>();
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string novaTarefa = text;
            if (!string.IsNullOrEmpty(novaTarefa))
            {
                tarefas.Add(novaTarefa);
                listBox1.Items.Add(novaTarefa);
                textBox1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox1.Text))
            {
                string novaDescricao = textBox1.Text;
                int indiceTarefa = listBox1.SelectedIndex;

                tarefas[indiceTarefa] = novaDescricao;
                listBox1.Items[indiceTarefa] = novaDescricao;
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tarefa e digite uma nova descrição.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                tarefas.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tarefas.Clear();
            listBox1.Items.Clear();
        }
    }
}
