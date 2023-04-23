using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

using ProviderTest = System.Func<Suscito.Modules.AT.IATProfileProvider, bool>;

namespace Suscito.Modules.AT
{
	/// <summary>
	/// A test implementation of the <see cref="IATProfileProvider" /> service.
	/// </summary>
	public class TestATProfileProvider : IATProfileProvider, IATQueryProvider
	{
		static private ParsingConfig _parsingConfig;
		static private Dictionary<string, ProviderTest> _shortQueries;

		static TestATProfileProvider()
		{
			_parsingConfig = new ParsingConfig();
			_parsingConfig.ResolveTypesBySimpleName = true;

			// Create short queries
			_shortQueries = new Dictionary<string, ProviderTest>();

			_shortQueries["PartnerAvoidant"] = (p => p.Partner.BowlbyStyle == BowlbyStyle.Avoidant);
            _shortQueries["UserAnxious"] = (p => p.User.BowlbyStyle == BowlbyStyle.Anxious);
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
		public bool IsTrue(string query)
		{
			// See if we have a shortcut
			ProviderTest? test;
			if (_shortQueries.TryGetValue(query, out test)) 
			{
				// Yes, run it
				return test(this);
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