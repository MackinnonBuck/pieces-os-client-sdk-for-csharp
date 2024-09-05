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
    ///  Class for testing AnchorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnchorApiTests : IDisposable
    {
        private AnchorApi instance;

        public AnchorApiTests()
        {
            instance = new AnchorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnchorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AnchorApi
            //Assert.IsType<AnchorApi>(instance);
        }

        /// <summary>
        /// Test AnchorAssociateAsset
        /// </summary>
        [Fact]
        public void AnchorAssociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //Guid asset = null;
            //instance.AnchorAssociateAsset(anchor, asset);
        }

        /// <summary>
        /// Test AnchorAssociateConversation
        /// </summary>
        [Fact]
        public void AnchorAssociateConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string conversation = null;
            //instance.AnchorAssociateConversation(anchor, conversation);
        }

        /// <summary>
        /// Test AnchorAssociatePerson
        /// </summary>
        [Fact]
        public void AnchorAssociatePersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string person = null;
            //instance.AnchorAssociatePerson(anchor, person);
        }

        /// <summary>
        /// Test AnchorAssociateWorkstreamSummary
        /// </summary>
        [Fact]
        public void AnchorAssociateWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string workstreamSummary = null;
            //instance.AnchorAssociateWorkstreamSummary(anchor, workstreamSummary);
        }

        /// <summary>
        /// Test AnchorDisassociateAsset
        /// </summary>
        [Fact]
        public void AnchorDisassociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //Guid asset = null;
            //instance.AnchorDisassociateAsset(anchor, asset);
        }

        /// <summary>
        /// Test AnchorDisassociateConversation
        /// </summary>
        [Fact]
        public void AnchorDisassociateConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string conversation = null;
            //instance.AnchorDisassociateConversation(anchor, conversation);
        }

        /// <summary>
        /// Test AnchorDisassociatePerson
        /// </summary>
        [Fact]
        public void AnchorDisassociatePersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string person = null;
            //instance.AnchorDisassociatePerson(anchor, person);
        }

        /// <summary>
        /// Test AnchorDisassociateWorkstreamSummary
        /// </summary>
        [Fact]
        public void AnchorDisassociateWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //string workstreamSummary = null;
            //instance.AnchorDisassociateWorkstreamSummary(anchor, workstreamSummary);
        }

        /// <summary>
        /// Test AnchorRename
        /// </summary>
        [Fact]
        public void AnchorRenameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //bool? transferables = null;
            //var response = instance.AnchorRename(anchor, transferables);
            //Assert.IsType<Anchor>(response);
        }

        /// <summary>
        /// Test AnchorScoresIncrement
        /// </summary>
        [Fact]
        public void AnchorScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.AnchorScoresIncrement(anchor, seededScoreIncrement);
        }

        /// <summary>
        /// Test AnchorSpecificAnchorSnapshot
        /// </summary>
        [Fact]
        public void AnchorSpecificAnchorSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string anchor = null;
            //bool? transferables = null;
            //var response = instance.AnchorSpecificAnchorSnapshot(anchor, transferables);
            //Assert.IsType<Anchor>(response);
        }

        /// <summary>
        /// Test AnchorUpdate
        /// </summary>
        [Fact]
        public void AnchorUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //Anchor anchor = null;
            //var response = instance.AnchorUpdate(transferables, anchor);
            //Assert.IsType<Anchor>(response);
        }
    }
}
