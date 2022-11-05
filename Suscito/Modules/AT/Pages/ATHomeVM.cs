using SolerSoft.Maui.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlbyStyleInfo = Suscito.Modules.AT.StyleInfo<Suscito.Modules.AT.BowlbyStyle>;

namespace Suscito.Modules.AT
{
    public class ATHomeVM : ViewModel
    {
		private BowlbyStyle _bowlbyStyle;
        private List<BowlbyStyle> _bowlbyStyles;
        private BowlbyStyleInfo _bowlbyStyleInfo;

        public ATHomeVM()
		{
			_bowlbyStyles = Enum.GetValues(typeof(BowlbyStyle)).Cast<BowlbyStyle>().ToList();
			_bowlbyStyleInfo = new BowlbyStyleInfo(BowlbyStyle.Unknown);
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
			get { return _bowlbyStyle; }
			set
			{
				if (SetProperty(ref _bowlbyStyle, value))
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
			get { return _bowlbyStyleInfo; }
			set { SetProperty(ref _bowlbyStyleInfo, value); }
		}
	}
}
