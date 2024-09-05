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
    ///  Class for testing HintApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HintApiTests : IDisposable
    {
        private HintApi instance;

        public HintApiTests()
        {
            instance = new HintApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HintApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HintApi
            //Assert.IsType<HintApi>(instance);
        }

        /// <summary>
        /// Test HintScoresIncrement
        /// </summary>
        [Fact]
        public void HintScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string hint = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.HintScoresIncrement(hint, seededScoreIncrement);
        }

        /// <summary>
        /// Test HintSpecificHintSnapshot
        /// </summary>
        [Fact]
        public void HintSpecificHintSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string hint = null;
            //var response = instance.HintSpecificHintSnapshot(hint);
            //Assert.IsType<Hint>(response);
        }

        /// <summary>
        /// Test HintUpdate
        /// </summary>
        [Fact]
        public void HintUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Hint hint = null;
            //var response = instance.HintUpdate(hint);
            //Assert.IsType<Hint>(response);
        }
    }
}
