using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MonsterDex.BusinessLayer;
using MonsterDex.ViewModel;
using MonsterDex.PresentationLayer;

namespace MonsterDex
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MonsterBusiness monsterBuisness = new MonsterBusiness();
			MonsterDexViewModel monsterDexViewModel = new MonsterDexViewModel(monsterBuisness);

			MonsterDexView monsterDexView = new MonsterDexView();
			monsterDexView.DataContext = monsterDexViewModel;
			monsterDexView.Show();
        }

    }
}
