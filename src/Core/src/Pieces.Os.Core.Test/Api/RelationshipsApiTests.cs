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
    ///  Class for testing RelationshipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RelationshipsApiTests : IDisposable
    {
        private RelationshipsApi instance;

        public RelationshipsApiTests()
        {
            instance = new RelationshipsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RelationshipsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RelationshipsApi
            //Assert.IsType<RelationshipsApi>(instance);
        }

        /// <summary>
        /// Test RelationshipsSnapshot
        /// </summary>
        [Fact]
        public void RelationshipsSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RelationshipsSnapshot();
            //Assert.IsType<Relationships>(response);
        }
    }
}
