﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ET43_MaestroDetalle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaPrincipal : MasterDetailPage
	{
		public PaginaPrincipal ()
		{
			InitializeComponent ();
		}
	}
}