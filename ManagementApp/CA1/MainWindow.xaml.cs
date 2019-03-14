using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ObservableCollection<Member> members = new ObservableCollection<Member>();

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MemberLst.ItemsSource = members;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(membertxtbx.Text != "")
            {
                Member added = new Member(membertxtbx.Text);
                members.Add(added);

                membertxtbx.Text = "";
            }

        }

        private void RemoveMembtn_Click(object sender, RoutedEventArgs e)
        {
            if (MemberLst.SelectedItem != null)
            {
                for(int i = 0; i < members.Count; i++)
                {
                    if(MemberLst.SelectedItem.ToString() == members[i].Name)
                    {
                        members.Remove(members[i]);
                    }

                    MemberLst.ItemsSource = null;

                    MemberLst.ItemsSource = members;
                }

                MemberLst.SelectedItem = null;
            }
        }

        private void TskButton_Click(object sender, RoutedEventArgs e)
        {
            if(MemberLst.SelectedItem != null)
            {
                if(TasknameTxtbx.Text != null)
                {
                    Task added = new Task(TasknameTxtbx.Text, "");

                    foreach(Member M in members)
                    {
                        if(M.Name == MemberLst.SelectedItem.ToString())
                        {
                            M.AddTask(added);

                            Tasklst.ItemsSource = M.tasks;
                        }
                    }

                    
                }
            }
        }
    }
}
