using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using FloatplaneAPIClientCSharp.Client;

namespace FloatplaneAPIClientCSharp.Test
{
	internal class ApiTestHelper
	{
		/// <summary>
		/// A contract resolver that treats all model properties as
		/// `[JsonObject(ItemRequired=Required.Always)]` so that
		/// an error is thrown if the JSON is missing a property.
		/// </summary>
		public class RequireObjectPropertiesContractResolver : DefaultContractResolver
		{
			protected override JsonObjectContract CreateObjectContract(Type objectType)
			{
				var contract = base.CreateObjectContract(objectType);
				contract.ItemRequired = Required.AllowNull;
				return contract;
			}

			protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
			{
				var property = base.CreateProperty(member, memberSerialization);
				property.Required = Required.AllowNull;
				return property;
			}
		}

		protected static readonly IContractResolver RequireObjectPropertiesContractResolverInstance = new RequireObjectPropertiesContractResolver();

		protected static readonly JsonSerializerSettings StrictSerializerSettings = new JsonSerializerSettings
		{
			// Throw errors if the JSON is missing a Model's property.
			ContractResolver = ApiTestHelper.RequireObjectPropertiesContractResolverInstance,
			// Use DateTimeOffset over DateTime.
			DateParseHandling = DateParseHandling.DateTimeOffset,
			DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
			// FP's specific date time offset format.
			DateFormatString = "yyyy-MM-dd'T'HH:mm:ss.SSSZ",
			// Always write properties to JSON even if they're a default value.
			DefaultValueHandling = DefaultValueHandling.Include,
			// Throw erros if the JSON has extra properties not in the Model.
			MissingMemberHandling = MissingMemberHandling.Error,
		};


		public static void SetStrictSerializerSettings(IApiAccessor api, ISynchronousClient client)
		{
			// Get the ApiClient for modifications below.
			var apiClient = client as ApiClient;
			if (apiClient == null)
			{
				throw new Exception("The client is not an ApiClient");
			}

			// Set the strict serializer for all operations.
			apiClient.SerializerSettings = ApiTestHelper.StrictSerializerSettings;

			// Set the `sails.sid` Cookie for authenticated requests from the environment.
			var sailsSid = System.Environment.GetEnvironmentVariable("sailssid");
			if (string.IsNullOrEmpty(sailsSid))
			{
				throw new Exception("The `sailssid` environment variable is not set.");
			}
			api.Configuration.ApiKey["sails.sid"] = sailsSid;

			// Set the User-Agent header to identify traffic.
			// The CFNetwork at the tail end of the user agent is to mark this traffic as coming
			// from non-browser clients, and bypass some captcha checks.
			api.Configuration.DefaultHeaders["User-Agent"] = "Floatplane API Docs Integration and Regression Tests, CFNetwork";
		}
	}

}