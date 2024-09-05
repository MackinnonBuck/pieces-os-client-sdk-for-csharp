/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
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

using Pieces.Os.Core.Client;
using Pieces.Os.Core.Api;
// uncomment below to import models
//using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Test.Api
{
    /// <summary>
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test AuthenticateFromOauthToken
        /// </summary>
        [Fact]
        public void AuthenticateFromOauthTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OAuthToken oAuthToken = null;
            //var response = instance.AuthenticateFromOauthToken(oAuthToken);
            //Assert.IsType<UserProfile>(response);
        }

        /// <summary>
        /// Test UsersDisconnectUser
        /// </summary>
        [Fact]
        public void UsersDisconnectUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string user = null;
            //var response = instance.UsersDisconnectUser(user);
            //Assert.IsType<Users>(response);
        }

        /// <summary>
        /// Test UsersSnapshot
        /// </summary>
        [Fact]
        public void UsersSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersSnapshot();
            //Assert.IsType<Users>(response);
        }

        /// <summary>
        /// Test UsersSpecificUserSnapshot
        /// </summary>
        [Fact]
        public void UsersSpecificUserSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid user = null;
            //var response = instance.UsersSpecificUserSnapshot(user);
            //Assert.IsType<UserProfile>(response);
        }
    }
}
