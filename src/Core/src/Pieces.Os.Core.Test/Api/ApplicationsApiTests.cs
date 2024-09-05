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
    ///  Class for testing ApplicationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationsApiTests : IDisposable
    {
        private ApplicationsApi instance;

        public ApplicationsApiTests()
        {
            instance = new ApplicationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApplicationsApi
            //Assert.IsType<ApplicationsApi>(instance);
        }

        /// <summary>
        /// Test ApplicationsExternalRelated
        /// </summary>
        [Fact]
        public void ApplicationsExternalRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApplicationsExternalRelated();
            //Assert.IsType<DetectedExternalApplications>(response);
        }

        /// <summary>
        /// Test ApplicationsExternalSnapshot
        /// </summary>
        [Fact]
        public void ApplicationsExternalSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApplicationsExternalSnapshot();
            //Assert.IsType<DetectedExternalApplications>(response);
        }

        /// <summary>
        /// Test ApplicationsRegister
        /// </summary>
        [Fact]
        public void ApplicationsRegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Application application = null;
            //var response = instance.ApplicationsRegister(application);
            //Assert.IsType<Application>(response);
        }

        /// <summary>
        /// Test ApplicationsSessionClose
        /// </summary>
        [Fact]
        public void ApplicationsSessionCloseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? body = null;
            //var response = instance.ApplicationsSessionClose(body);
            //Assert.IsType<Session>(response);
        }

        /// <summary>
        /// Test ApplicationsSessionOpen
        /// </summary>
        [Fact]
        public void ApplicationsSessionOpenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApplicationsSessionOpen();
            //Assert.IsType<Session>(response);
        }

        /// <summary>
        /// Test ApplicationsSessionSnapshot
        /// </summary>
        [Fact]
        public void ApplicationsSessionSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string session = null;
            //var response = instance.ApplicationsSessionSnapshot(session);
            //Assert.IsType<Session>(response);
        }

        /// <summary>
        /// Test ApplicationsSnapshot
        /// </summary>
        [Fact]
        public void ApplicationsSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApplicationsSnapshot();
            //Assert.IsType<Applications>(response);
        }

        /// <summary>
        /// Test ApplicationsSpecificApplicationSnapshot
        /// </summary>
        [Fact]
        public void ApplicationsSpecificApplicationSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string application = null;
            //var response = instance.ApplicationsSpecificApplicationSnapshot(application);
            //Assert.IsType<Application>(response);
        }

        /// <summary>
        /// Test ApplicationsUsageEngagementInteraction
        /// </summary>
        [Fact]
        public void ApplicationsUsageEngagementInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeededTrackedInteractionEvent seededTrackedInteractionEvent = null;
            //var response = instance.ApplicationsUsageEngagementInteraction(seededTrackedInteractionEvent);
            //Assert.IsType<TrackedInteractionEvent>(response);
        }

        /// <summary>
        /// Test ApplicationsUsageEngagementKeyboard
        /// </summary>
        [Fact]
        public void ApplicationsUsageEngagementKeyboardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeededTrackedKeyboardEvent seededTrackedKeyboardEvent = null;
            //var response = instance.ApplicationsUsageEngagementKeyboard(seededTrackedKeyboardEvent);
            //Assert.IsType<TrackedKeyboardEvent>(response);
        }

        /// <summary>
        /// Test ApplicationsUsageInstallation
        /// </summary>
        [Fact]
        public void ApplicationsUsageInstallationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TrackedApplicationInstall trackedApplicationInstall = null;
            //instance.ApplicationsUsageInstallation(trackedApplicationInstall);
        }

        /// <summary>
        /// Test PostApplicationsUsageUpdated
        /// </summary>
        [Fact]
        public void PostApplicationsUsageUpdatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TrackedApplicationUpdate trackedApplicationUpdate = null;
            //instance.PostApplicationsUsageUpdated(trackedApplicationUpdate);
        }
    }
}
