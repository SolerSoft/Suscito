using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

using ProviderTest = System.Func<Suscito.Modules.AT.IATProfileProvider, bool>;

namespace Suscito.Modules.AT
{
	/// <summary>
	/// Provides information for a short query.
	/// </summary>
	internal class ShortQuery
	{
		/// <summary>
		/// Gets or sets the test to evaluate.
		/// </summary>
		public ProviderTest Test { get; set; }

		/// <summary>
		/// The title to use for the shortcut.
		/// </summary>
		public string? Title { get; set; }
	}

	/// <summary>
	/// A test implementation of the <see cref="IATProfileProvider" /> service.
	/// </summary>
	public class TestATProfileProvider : IATProfileProvider, IATQueryProvider
	{
		static private ParsingConfig _parsingConfig;
		static private Dictionary<string, ShortQuery> _shortQueries;

		static TestATProfileProvider()
		{
			_parsingConfig = new ParsingConfig();
			_parsingConfig.ResolveTypesBySimpleName = true;

			// Create short queries
			_shortQueries = new Dictionary<string, ShortQuery>();

			_shortQueries["PartnerAvoidant"] = new ShortQuery()
			{
				Test = (p => p.Partner.BowlbyStyle == BowlbyStyle.Avoidant),
				Title = "Because your partner identified as avoidant",
			};

			_shortQueries["UserAnxious"] = new ShortQuery()
			{
				Test = (p => p.User.BowlbyStyle == BowlbyStyle.Anxious),
				Title = "Because you identified as anxious",
			};
        }

		#region Private Fields

		private ATProfile partner;
		private ATProfile user;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Initializes the <see cref="TestATProfileProvider" />.
		/// </summary>
		public TestATProfileProvider()
		{
			partner = new ATProfile()
			{
				BowlbyStyle = BowlbyStyle.Avoidant
			};
			user = new ATProfile()
			{
				BowlbyStyle = BowlbyStyle.Anxious
			};
		}

		#endregion Public Constructors

		#region Public Methods
		/// <inheritdoc />
		public string? GetTitle(string query)
		{
			// See if we have a shortcut
			ShortQuery? sq;
			if (_shortQueries.TryGetValue(query, out sq))
			{
				// Yes, run it
				return sq.Title;
			}

			// No title
			return null;
		}

		/// <inheritdoc />
		public bool IsTrue(string query)
		{
			// See if we have a shortcut
			ShortQuery? sq;
			if (_shortQueries.TryGetValue(query, out sq)) 
			{
				// Yes, run it
				return sq.Test(this);
			}

			// Nope, need to do long query

			var exp = DynamicExpressionParser.ParseLambda<IATProfileProvider, bool>(_parsingConfig, true, query);

			var func = exp.Compile();

			bool result = func(this);

			return result;
		}

		#endregion Public Methods

		#region Public Properties

		/// <inheritdoc />
		public ATProfile Partner => partner;

		/// <inheritdoc />
		public ATProfile User => user;

		#endregion Public Properties
	}
}