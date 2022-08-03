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
// uncomment below to import models
//using FloatplaneAPIClientCSharp.Model;

namespace FloatplaneAPIClientCSharp.Test.Api
{
	/// <summary>
	///  Class for testing CDNV2Api
	/// </summary>
	/// <remarks>
	/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
	/// Please update the test case below to test the API endpoint.
	/// </remarks>
	public class CDNV2ApiTests : IDisposable
	{
		private CDNV2Api instance;

		public CDNV2ApiTests()
		{
			instance = new CDNV2Api();
			ApiTestHelper.SetStrictSerializerSettings(instance, instance.Client);
		}

		public void Dispose()
		{
			// Cleanup when everything is done.
		}

		/// <summary>
		/// Test an instance of CDNV2Api
		/// </summary>
		[Fact]
		public void InstanceTest()
		{
			// TODO uncomment below to test 'IsType' CDNV2Api
			//Assert.IsType<CDNV2Api>(instance);
		}

		/// <summary>
		/// Test GetDeliveryInfo
		/// </summary>
		[Fact]
		public void GetDeliveryInfoTest()
		{
			// TODO uncomment below to test the method and replace null with proper value
			//string type = null;
			//string? guid = null;
			//string? creator = null;
			//var response = instance.GetDeliveryInfo(type, guid, creator);
			//Assert.IsType<CdnDeliveryV2Response>(response);
		}
	}
}
