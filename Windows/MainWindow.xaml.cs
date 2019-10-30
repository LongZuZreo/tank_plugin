using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace tank_plugin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Loaded();
        }
        private void Window_Loaded()
        { 
            DefinitionNode dNode = new DefinitionNode()
            {
                Name = "一级",
                Children = new List<DefinitionNode>()
                {
                    new DefinitionNode()
                    {
                        Name = "二级",
                        Children = new List<DefinitionNode>()
                        {
                            new DefinitionNode() {Name = "三级" },
                            new DefinitionNode() {Name = "三级" }
                        }
                    }
                }
            };

            DefinitionNode dNode2 = new DefinitionNode()
            {
                Name = "一级",
                Children = new List<DefinitionNode>()
                {
                    new DefinitionNode { Name = "二级" },
                    new DefinitionNode {Name = "二级" }
                }
            };
            List<DefinitionNode> list = new List<DefinitionNode> { dNode, dNode2 };
            treeView.ItemsSource = list;
        }
        void button_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dnmd，这个功能还没开发，等着！");
            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dnmd，这个功能还没开发，等着！");
            //显示“关于”界
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dnmd，这个功能还没开发，等着！");
        }

        private void Defined_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dnmd，这个功能还没开发，等着！");
        }
       
       
    }
}