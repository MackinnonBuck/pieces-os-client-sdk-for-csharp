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
    ///  Class for testing PersonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PersonApiTests : IDisposable
    {
        private PersonApi instance;

        public PersonApiTests()
        {
            instance = new PersonApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PersonApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PersonApi
            //Assert.IsType<PersonApi>(instance);
        }

        /// <summary>
        /// Test PersonAssociateAnchor
        /// </summary>
        [Fact]
        public void PersonAssociateAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string anchor = null;
            //instance.PersonAssociateAnchor(person, anchor);
        }

        /// <summary>
        /// Test PersonAssociateAsset
        /// </summary>
        [Fact]
        public void PersonAssociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //Guid asset = null;
            //instance.PersonAssociateAsset(person, asset);
        }

        /// <summary>
        /// Test PersonAssociateTag
        /// </summary>
        [Fact]
        public void PersonAssociateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string tag = null;
            //instance.PersonAssociateTag(person, tag);
        }

        /// <summary>
        /// Test PersonAssociateWebsite
        /// </summary>
        [Fact]
        public void PersonAssociateWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string website = null;
            //instance.PersonAssociateWebsite(person, website);
        }

        /// <summary>
        /// Test PersonAssociateWorkstreamSummary
        /// </summary>
        [Fact]
        public void PersonAssociateWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string workstreamSummary = null;
            //instance.PersonAssociateWorkstreamSummary(person, workstreamSummary);
        }

        /// <summary>
        /// Test PersonDisassociateAnchor
        /// </summary>
        [Fact]
        public void PersonDisassociateAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string anchor = null;
            //instance.PersonDisassociateAnchor(person, anchor);
        }

        /// <summary>
        /// Test PersonDisassociateAsset
        /// </summary>
        [Fact]
        public void PersonDisassociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //Guid asset = null;
            //instance.PersonDisassociateAsset(person, asset);
        }

        /// <summary>
        /// Test PersonDisassociateTag
        /// </summary>
        [Fact]
        public void PersonDisassociateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string tag = null;
            //instance.PersonDisassociateTag(person, tag);
        }

        /// <summary>
        /// Test PersonDisassociateWebsite
        /// </summary>
        [Fact]
        public void PersonDisassociateWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string website = null;
            //instance.PersonDisassociateWebsite(person, website);
        }

        /// <summary>
        /// Test PersonDisassociateWorkstreamSummary
        /// </summary>
        [Fact]
        public void PersonDisassociateWorkstreamSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //string workstreamSummary = null;
            //instance.PersonDisassociateWorkstreamSummary(person, workstreamSummary);
        }

        /// <summary>
        /// Test PersonScoresIncrement
        /// </summary>
        [Fact]
        public void PersonScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.PersonScoresIncrement(person, seededScoreIncrement);
        }

        /// <summary>
        /// Test PersonSnapshot
        /// </summary>
        [Fact]
        public void PersonSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string person = null;
            //bool? transferables = null;
            //var response = instance.PersonSnapshot(person, transferables);
            //Assert.IsType<Person>(response);
        }

        /// <summary>
        /// Test UpdatePerson
        /// </summary>
        [Fact]
        public void UpdatePersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //Person person = null;
            //var response = instance.UpdatePerson(transferables, person);
            //Assert.IsType<Person>(response);
        }
    }
}
