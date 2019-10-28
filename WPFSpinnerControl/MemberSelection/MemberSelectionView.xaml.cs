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

namespace WPFSpinnerControl.MemberSelection
{
    /// <summary>
    /// Interaction logic for MemberSelectionView.xaml
    /// </summary>
    public partial class MemberSelectionView : UserControl
    {
        public MemberSelectionView()
        {
            InitializeComponent();
            MemberSelectionViewModel memberSelectionViewModel = new MemberSelectionViewModel();
            this.DataContext = memberSelectionViewModel;
        }
    }
}
