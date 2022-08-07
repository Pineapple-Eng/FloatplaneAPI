/*
 * Floatplane REST API
 *
 * The version of the OpenAPI document: 3.9.9
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FloatplaneAPIClientCSharp.Client;
using FloatplaneAPIClientCSharp.Api;
using FloatplaneAPIClientCSharp.Model;

namespace FloatplaneAPIClientCSharp.Test.Api
{
	/// <summary>
	///  Class for testing UserV3Api
	/// </summary>
	/// <remarks>
	/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
	/// Please update the test case below to test the API endpoint.
	/// </remarks>
	public class UserV3ApiTests : IDisposable
	{
		private UserV3Api instance;

		public UserV3ApiTests()
		{
			instance = new UserV3Api();
			ApiTestHelper.SetStrictSerializerSettings(instance, instance.Client);
		}

		public void Dispose()
		{
			// Cleanup when everything is done.
		}

		/// <summary>
		/// Test an instance of UserV3Api
		/// </summary>
		[Fact]
		public void InstanceTest()
		{
			// TODO uncomment below to test 'IsType' UserV3Api
			//Assert.IsType<UserV3Api>(instance);
		}

		/// <summary>
		/// Test GetActivityFeedV3
		/// </summary>
		[Fact]
		public void GetActivityFeedV3Test()
		{
			string id = ApiTestSampleData.SampleUserId;
			var response = instance.GetActivityFeedV3WithHttpInfo(id);
			Assert.Null(response.ErrorText);
			Assert.IsType<UserActivityV3Response>(response.Data);
			Assert.NotEmpty(response.Data?.Activity);
		}

		/// <summary>
		/// Test GetExternalLinksV3
		/// </summary>
		[Fact]
		public void GetExternalLinksV3Test()
		{
			string id = ApiTestSampleData.SampleUserId;
			var response = instance.GetExternalLinksV3WithHttpInfo(id);
			Assert.Null(response.ErrorText);
			Assert.IsType<Dictionary<string, UserLinksV3ResponseValue>>(response.Data);
			Assert.NotEmpty(response.Data);
		}

		/// <summary>
		/// Test GetSelf
		/// </summary>
		[Fact]
		public void GetSelfTest()
		{
			var response = instance.GetSelfWithHttpInfo();
			Assert.Null(response.ErrorText);
			Assert.IsType<UserSelfV3Response>(response.Data);
		}

		/// <summary>
		/// Test GetUserNotificationSettingsV3
		/// </summary>
		[Fact]
		public void GetUserNotificationSettingsV3Test()
		{
			var response = instance.GetUserNotificationSettingsV3WithHttpInfo();
			Assert.Null(response.ErrorText);
			Assert.IsType<List<UserNotificationModel>>(response.Data);
		}

		/// <summary>
		/// Test UpdateUserNotificationSettingsV3
		/// </summary>
		[Fact]
		public void UpdateUserNotificationSettingsV3Test()
		{
			// TODO uncomment below to test the method and replace null with proper value
			//UserNotificationUpdateV3PostRequest userNotificationUpdateV3PostRequest = null;
			//var response = instance.UpdateUserNotificationSettingsV3(userNotificationUpdateV3PostRequest);
			//Assert.IsType<bool>(response);
		}
	}
}