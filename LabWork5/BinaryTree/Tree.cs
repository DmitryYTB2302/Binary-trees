using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree //Описание класса "Дерево"
    {
        public class TreeNode // вложенный класс "Поддерево"
        {
            public int Value; // значение ключа
            public int Count = 0; // количество одинаковых ключей
            public TreeNode Left; // левое поддерево
            public TreeNode Right; // правое поддерево
        }
        public TreeNode Node; // экземпляр класса "Поддерево"
        public enum BypassOptions // перечисление - объявленные константы для выбора
        {
            LNR,
            NLR,
            LRN,
            RNL,
            BFS
        }
        public void Add(int value)// добавление элемента - интерфейсный метод
        {
            AddChildren(ref Node, value);
        }
        public void Output(ref string s) // вывод данных в форму - интерфейсный метод
        {
            s = ""; // обнуляем строку
            OutputTree(Node, 0, ref s);
        }

        public void Bypass(BypassOptions option, ref string s)// обход дерева - интерфейсный метод
        {
            s = "";
            if (option == BypassOptions.LNR) LNR_bypass(Node, ref s);
            if (option == BypassOptions.NLR) NLR_bypass(Node, ref s);
            if (option == BypassOptions.LRN) LRN_bypass(Node, ref s);
            if (option == BypassOptions.RNL) RNL_bypass(Node, ref s);
            if (option == BypassOptions.BFS) BFS_bypass(Node, ref s);
            s += Environment.NewLine;
        }

        //Инкапсулированные методы
        //ref TreeNode Node - текущий "элемент дерева"
        private void AddChildren(ref TreeNode node, int val)
        {
            if (node == null)
            {
                node = new TreeNode();
                node.Value = val;
                node.Count = 1;
            }
            else
            {
                if (node.Value == val) node.Count++;
                else
                {
                    if (node.Value > val) AddChildren(ref node.Left, val);
                    else AddChildren(ref node.Right, val);
                }
            }
        }
        private void OutputTree(TreeNode root, int spaces, ref string s)
        {
            if (root != null)
            {
                for (int i = 0; i < root.Count; i++)
                {
                    for (int j = 0; j <= spaces; j++)
                        if (j == 0) s += "|";
                        else s += " -";
                    s += " ";
                    s += root.Value.ToString();
                    s += Environment.NewLine;
                }
                OutputTree(root.Left, spaces + 1, ref s);
                OutputTree(root.Right, spaces + 1, ref s);
            }
        }

        private void LNR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LNR_bypass(node.Left, ref s); // обойти левое поддерево
                s += node.Value.ToString() + " "; // записать данные
                LNR_bypass(node.Right, ref s); // обойти правое поддерево
            }
        }
        private void NLR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                s += node.Value.ToString() + " ";
                NLR_bypass(node.Left, ref s);
                NLR_bypass(node.Right, ref s);
            }
        }
        private void LRN_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LRN_bypass(node.Left, ref s);
                LRN_bypass(node.Right, ref s);
                s += node.Value.ToString() + " ";
            }
        }
        private void RNL_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                RNL_bypass(node.Right, ref s); // обойти правое поддерево
                s += node.Value.ToString() + " "; // запомнить текущее значение
                RNL_bypass(node.Left, ref s); // обойти левое поддерево
            }
        }

        private void BFS_bypass(TreeNode node, ref string s)
        {
            var tail = new Queue<TreeNode>(); // создание очереди, принцип FIFO
            tail.Enqueue(node);
            while (tail.Count != 0)
            {
                if (tail.Peek().Left != null)
                {
                    tail.Enqueue(tail.Peek().Left);
                }
                if (tail.Peek().Right != null)
                {
                    tail.Enqueue(tail.Peek().Right);
                }
                s += tail.Peek().Value.ToString() + " ";
                tail.Dequeue();
            }
        }
        private void NRL_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                s += node.Value.ToString() + " ";
                NRL_bypass(node.Right, ref s);
                NRL_bypass(node.Left, ref s);
            }
        }

        public void medianSearch(int[] arr, int beginIndex, int lastIndex, ref Tree tree)
        {

            if (beginIndex == lastIndex)
            {
                tree.Add(arr[beginIndex]);
                return;
            }

            int medianIndex = beginIndex + (lastIndex - beginIndex) / 2;
            tree.Add(arr[medianIndex]);


            int leftSideFirstIndex = beginIndex;
            int leftSideLastIndex = beginIndex + (lastIndex - beginIndex) / 2 - 1;
            if (leftSideFirstIndex != medianIndex)
            {
                medianSearch(arr, leftSideFirstIndex, leftSideLastIndex, ref tree);
            }

            int rightSideLastIndex = lastIndex;
            int rightSideFirstIndex = beginIndex + (lastIndex - beginIndex) / 2 + 1;
            if (rightSideLastIndex != medianIndex)
            {
                medianSearch(arr, rightSideFirstIndex, rightSideLastIndex, ref tree);
            }
        }
    }
}
