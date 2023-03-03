using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity05 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }

		public Activity05 ()
		{
			InitializeComponent ();
			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Jello Mangune", Position = "President", profileImage="profile1.png" });
                employees.Add(new employee { DisplayName = "Calvin Pamandanan", Position = "Vice President", profileImage = "profile2.jpg" });
                employees.Add(new employee { DisplayName = "Marcko Cruz", Position = "Secretary", profileImage = "https://media.tenor.com/_bTaLmoLSc4AAAAM/troll-pilled.gif" });

            }
		}
	}
}