using SolerSoft.Maui.Mvvm;
using Suscito.Modules.AT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlbyStyleInfo = Suscito.Modules.AT.Entities.StyleInfo<Suscito.Modules.AT.Entities.BowlbyStyle>;

namespace Suscito.Modules.AT.Pages
{
    public class ATHomeVM : ViewModel
    {
        private BowlbyStyle bowlbyStyle;
        private List<BowlbyStyle> _bowlbyStyles;
        private BowlbyStyleInfo bowlbyStyleInfo;

        public ATHomeVM()
		{
			BowlbyStyles = Enum.GetValues(typeof(BowlbyStyle)).Cast<BowlbyStyle>().ToList();
			BowlbyStyleInfo = new BowlbyStyleInfo(BowlbyStyle.Unknown);
		}

		/// <summary>
		/// Gets or sets the fieldName of the <see cref="ATHomeVM"/>.
		/// </summary>
		/// <value>
		/// The fieldName of the <c>ATHomeVM</c>.
		/// </value>
		public List<BowlbyStyle> BowlbyStyles
        {
			get { return _bowlbyStyles; }
			set { SetProperty(ref _bowlbyStyles, value); }
		}

		/// <summary>
		/// Gets or sets the bowlbyStyle of the <see cref="ATHomeVM"/>.
		/// </summary>
		/// <value>
		/// The bowlbyStyle of the <c>ATHomeVM</c>.
		/// </value>
		public BowlbyStyle BowlbyStyle
		{
			get { return bowlbyStyle; }
			set
			{
				if (SetProperty(ref bowlbyStyle, value))
				{
					BowlbyStyleInfo = new BowlbyStyleInfo(value);
				}
			}
		}

		/// <summary>
		/// Gets or sets the bowlbyStyleInfo of the <see cref="ATHomeVM"/>.
		/// </summary>
		/// <value>
		/// The bowlbyStyleInfo of the <c>ATHomeVM</c>.
		/// </value>
		public BowlbyStyleInfo BowlbyStyleInfo
		{
			get { return bowlbyStyleInfo; }
			set { SetProperty(ref bowlbyStyleInfo, value); }
		}
	}
}
