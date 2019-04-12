using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infraestructure
{
	using ViewModels;
	class InstanceLocator
    {
		#region properties
		public MainViewModel Main
		{
			get;
			set;
		}
		#endregion

		#region constructors
		//Página login conectada a MainViewModel
		public InstanceLocator()
		{
			this.Main = new MainViewModel();
		}

		#endregion
	}
}
