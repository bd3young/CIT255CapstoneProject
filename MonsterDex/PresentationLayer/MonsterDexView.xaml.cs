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
using System.Windows.Shapes;

namespace MonsterDex.PresentationLayer
{
    /// <summary>
    /// Interaction logic for MonsterDexView.xaml
    /// </summary>
    public partial class MonsterDexView : Window
    {
		public MonsterDexViewModel _monsterDexViewModel;

		public MonsterDexView(MonsterDexViewModel monsterDexViewModel)
		{
			_monsterDexViewModel = monsterDexViewModel;
			InitializeComponent();
		}


	}
}
