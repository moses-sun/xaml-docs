using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region gridview-style-selectors-overview_0
public class SampleStyleSelector : StyleSelector
        {
           public override Style SelectStyle( object item, DependencyObject container )           {               if ( item is League )
                   return this.LeagueStyle;
               else if ( item is Division )
                   return this.DivisionStyle;
               else if ( item is Team )
                   return this.TeamStyle;
               return null;
           }
           public Style LeagueStyle
           {
               get;
               set;
           }
           public Style DivisionStyle
           {
               get;
               set;
           }
           public Style TeamStyle
           {
               get;
               set;
           }
        }
#endregion
}
