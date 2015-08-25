using System;
using System.Collections.Generic;
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

namespace CodeBasedEntity
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DbContexto contexto = new DbContexto("Data Source=localhost;Initial Catalog=Teste;Persist Security Info=True;User ID=sa;Password=just@me2014");
            contexto.pessoas.Add(new Pessoa(){
                Nome = "Nero"
            });
            contexto.SaveChanges();
        }
    }
}
