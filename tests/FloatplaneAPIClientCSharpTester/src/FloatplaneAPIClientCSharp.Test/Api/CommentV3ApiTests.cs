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
	///  Class for testing CommentV3Api
	/// </summary>
	/// <remarks>
	/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
	/// Please update the test case below to test the API endpoint.
	/// </remarks>
	public class CommentV3ApiTests : IDisposable
	{
		private CommentV3Api instance;

		public CommentV3ApiTests()
		{
			instance = new CommentV3Api();
			ApiTestHelper.SetStrictSerializerSettings(instance, instance.Client);
		}

		public void Dispose()
		{
			// Cleanup when everything is done.
		}

		/// <summary>
		/// Test an instance of CommentV3Api
		/// </summary>
		[Fact]
		public void InstanceTest()
		{
			// TODO uncomment below to test 'IsType' CommentV3Api
			//Assert.IsType<CommentV3Api>(instance);
		}

		/// <summary>
		/// Test DislikeComment
		/// </summary>
		[Fact]
		public void DislikeCommentTest()
		{
			// TODO uncomment below to test the method and replace null with proper value
			//CommentLikeV3PostRequest commentLikeV3PostRequest = null;
			//var response = instance.DislikeComment(commentLikeV3PostRequest);
			//Assert.IsType<string>(response);
		}

		/// <summary>
		/// Test GetCommentReplies
		/// </summary>
		[Fact]
		public void GetCommentRepliesTest()
		{
			string comment = "62e3cb806cc3ba2fd032a06a";
			string blogPost = "wM0UfP1R8g";
			int limit = 3;
			string rid = "62e3e9e68a798648e70499c8";
			var response = instance.GetCommentRepliesWithHttpInfo(comment, blogPost, limit, rid);
			Assert.Null(response.ErrorText);
			Assert.IsType<List<CommentReplyModel>>(response.Data);
			Assert.True(response.Data?.Any());
		}

		[Fact]
		public void GetCommentRepliesNonExistentCommentTest()
		{
			var apiException = Assert.Throws<ApiException>(() => {
				string comment = ApiTestSampleData.NonExistentIdentifer;
				string blogPost = "wM0UfP1R8g";
				int limit = 3;
				string rid = "62e3e9e68a798648e70499c8";
				var response = instance.GetCommentRepliesWithHttpInfo(comment, blogPost, limit, rid);
			});
			Assert.NotNull(apiException.ErrorContent);
			Assert.Equal((int)System.Net.HttpStatusCode.BadRequest, apiException.ErrorCode);

			ApiTestHelper.ValidateErrorModel(ApiTestHelper.GetErrorModel(apiException));
		}

		[Fact]
		public void GetCommentRepliesNonExistentBlogPostTest()
		{
			var apiException = Assert.Throws<ApiException>(() => {
				string comment = "62e3cb806cc3ba2fd032a06a";
				string blogPost = ApiTestSampleData.NonExistentIdentifer;
				int limit = 3;
				string rid = "62e3e9e68a798648e70499c8";
				var response = instance.GetCommentRepliesWithHttpInfo(comment, blogPost, limit, rid);
			});
			Assert.NotNull(apiException.ErrorContent);
			Assert.Equal((int)System.Net.HttpStatusCode.Forbidden, apiException.ErrorCode);

			ApiTestHelper.ValidateErrorModel(ApiTestHelper.GetErrorModel(apiException));
		}

		/// <summary>
		/// Test GetComments
		/// </summary>
		[Fact]
		public void GetCommentsTest()
		{
			string blogPost = ApiTestSampleData.Post_Video_Old;
			int limit = 20;
			string? fetchAfter = null;
			var response = instance.GetCommentsWithHttpInfo(blogPost, limit, fetchAfter);
			Assert.Null(response.ErrorText);
			Assert.IsType<List<CommentModel>>(response.Data);
			Assert.True(response.Data?.Any());

			var last = response.Data?.LastOrDefault();
			if (last != null)
			{
				fetchAfter = last.Id;
				response = instance.GetCommentsWithHttpInfo(blogPost, limit, fetchAfter);
				Assert.Null(response.ErrorText);
				Assert.IsType<List<CommentModel>>(response.Data);
				Assert.True(response.Data?.Any());
			}
		}

		[Fact]
		public void GetCommentsNonExistentBlogPostTest()
		{
			var apiException = Assert.Throws<ApiException>(() => {
				string blogPost = ApiTestSampleData.NonExistentIdentifer;
				int limit = 20;
				string? fetchAfter = null;
				var response = instance.GetCommentsWithHttpInfo(blogPost, limit, fetchAfter);
			});
			Assert.NotNull(apiException.ErrorContent);
			Assert.Equal((int)System.Net.HttpStatusCode.Forbidden, apiException.ErrorCode);

			ApiTestHelper.ValidateErrorModel(ApiTestHelper.GetErrorModel(apiException));
		}

		/// <summary>
		/// Test LikeComment
		/// </summary>
		[Fact]
		public void LikeCommentTest()
		{
			// TODO uncomment below to test the method and replace null with proper value
			//CommentLikeV3PostRequest commentLikeV3PostRequest = null;
			//var response = instance.LikeComment(commentLikeV3PostRequest);
			//Assert.IsType<string>(response);
		}

		/// <summary>
		/// Test PostComment
		/// </summary>
		[Fact]
		public void PostCommentTest()
		{
			// TODO uncomment below to test the method and replace null with proper value
			//CommentV3PostRequest commentV3PostRequest = null;
			//var response = instance.PostComment(commentV3PostRequest);
			//Assert.IsType<CommentV3PostResponse>(response);
		}
	}
}
