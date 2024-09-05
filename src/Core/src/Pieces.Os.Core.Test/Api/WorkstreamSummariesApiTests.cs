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
    ///  Class for testing WorkstreamSummariesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkstreamSummariesApiTests : IDisposable
    {
        private WorkstreamSummariesApi instance;

        public WorkstreamSummariesApiTests()
        {
            instance = new WorkstreamSummariesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkstreamSummariesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkstreamSummariesApi
            //Assert.IsType<WorkstreamSummariesApi>(instance);
        }

        /// <summary>
        /// Test SearchWorkstreamSummaries
        /// </summary>
        [Fact]
        public void SearchWorkstreamSummariesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //SearchInput searchInput = null;
            //var response = instance.SearchWorkstreamSummaries(transferables, searchInput);
            //Assert.IsType<SearchedWorkstreamSummaries>(response);
        }

        /// <summary>
        /// Test WorkstreamSummariesCreateNewWorkstreamSummary
        /// </summary>
        [Fact]
        public void WorkstreamSummariesCreateNewWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //SeededWorkstreamSummary seededWorkstreamSummary = null;
            //var response = instance.WorkstreamSummariesCreateNewWorkstreamSummary(transferables, seededWorkstreamSummary);
            //Assert.IsType<WorkstreamSummary>(response);
        }

        /// <summary>
        /// Test WorkstreamSummariesDeleteSpecificWorkstreamSummary
        /// </summary>
        [Fact]
        public void WorkstreamSummariesDeleteSpecificWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //instance.WorkstreamSummariesDeleteSpecificWorkstreamSummary(workstreamSummary);
        }

        /// <summary>
        /// Test WorkstreamSummariesSnapshot
        /// </summary>
        [Fact]
        public void WorkstreamSummariesSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //var response = instance.WorkstreamSummariesSnapshot(transferables);
            //Assert.IsType<WorkstreamSummaries>(response);
        }
    }
}
