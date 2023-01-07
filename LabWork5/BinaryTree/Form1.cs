using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
	public partial class Form1 : Form
	{
		private Tree osinka;
		private Tree klen;
		public Form1()
		{
			InitializeComponent();
		}
		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void Load_Click(object sender, EventArgs e)
		{
			textBoxTree.Clear();
			textBoxBypass.Clear();
			textBoxSearch.Clear();
            int[] arr = new int[10000];
			int i = 0;
			/*try
			{*/
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					osinka = new Tree();// создать новое дерево
					textBoxTree.Clear();
					using (var file = new System.IO.StreamReader(openFileDialog1.FileName))
					{
						while (file.Peek() >= 0)
						{
							string currentElement = file.ReadLine();
							if (currentElement != null)
                                arr[i] = Convert.ToInt32(currentElement);
								i++;
								osinka.Add(int.Parse(currentElement));
						}
						i--;
						arr = rez(arr, i);
					}
					string results = "";
					osinka.Output(ref results);
					textBoxTree.Text = results;
					klen = new Tree();
					klen.medianSearch(arr, 0, arr.Length-1, ref klen);
					klen.Output(ref results);
				textBoxTree.Text += "\n\nМедианный обход\n\n";
				textBoxTree.Text += results;

				}
			/*}
			catch
			{*//*
				MessageBox.Show("Ошибка ввода", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
			*//*}*/

		}
		private int[] rez(int[] arr, int i)
        {
			int[] arr1 = new int[i];
			for (int i1 = 0; i1 < arr1.Length; i1++) 
			{ 
				arr1[i1] = arr[i1]; 
			}
			return arr1;
		}
		private void LNR_Click(object sender, EventArgs e)
		{
			string bypass = "";
			osinka.Bypass(Tree.BypassOptions.LNR, ref bypass);
			textBoxBypass.Text += @"Симметричный метод LNR: " + bypass;
		}
		private void NLR_Click(object sender, EventArgs e)
		{
			string bypass = "";
			osinka.Bypass(Tree.BypassOptions.NLR, ref bypass);
			textBoxBypass.Text += @"Прямой метод NLR: " + bypass;
		}
		private void LRN_Click(object sender, EventArgs e)
		{
			string bypass = "";
			osinka.Bypass(Tree.BypassOptions.LRN, ref bypass);
			textBoxBypass.Text += @"Обратный метод LRN: " + bypass;
		}
		private void RNL_Click(object sender, EventArgs e)
		{
			string bypass = "";
			osinka.Bypass(Tree.BypassOptions.RNL, ref bypass);
			textBoxBypass.Text += @"Справа налево RNL: " + bypass;
		}
		private void BFS_Click(object sender, EventArgs e)
		{
			string bypass = "";
			osinka.Bypass(Tree.BypassOptions.BFS, ref bypass);
			textBoxBypass.Text += @"Обход в ширину BFS: " + bypass;
		}
		private void All_Click(object sender, EventArgs e)
		{
			textBoxBypass.Clear();
			LNR_Click(sender, e);
			NLR_Click(sender, e);
			LRN_Click(sender, e);
			RNL_Click(sender, e);
			BFS_Click(sender, e);
		}
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string results = "";
			char key = Convert.ToChar(textBoxKey.Text);
			int depth = 0;
			//osinka.KeySearch(ref results, key, ref depth);
			if (results != "")
				textBoxSearch.Text += @"найден элемент " + results + @"уровень " + depth +
			   Environment.NewLine;
			else textBoxSearch.Text += @"элемент " + key + @" не найден " +
		   Environment.NewLine;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBoxKey.Clear();
			textBoxSearch.Clear();
		}

        private void textBoxTree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}