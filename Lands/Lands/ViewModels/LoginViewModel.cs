﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Lands.ViewModels
{
	using System.Windows.Input;

	class LoginViewModel
    {
		#region properties
		public String Email { get; set; }
		public String Password { get; set; }
		public bool IsRunning { get; set; }
		public bool IsRemembered { get; set; }
		#endregion

		#region constructors
		public LoginViewModel()
		{
			this.IsRemembered = true;
		}
		#endregion

		#region commands
		public ICommand LoginCommand { get; set; }
		#endregion
	}
}
