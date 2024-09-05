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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.Client.Auth;
using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeAnalysesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeAnalyses</returns>
        CodeAnalyses CodeAnalysesSnapshot(int operationIndex = 0);

        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeAnalyses</returns>
        ApiResponse<CodeAnalyses> CodeAnalysesSnapshotWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeAnalysesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeAnalyses</returns>
        System.Threading.Tasks.Task<CodeAnalyses> CodeAnalysesSnapshotAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeAnalyses)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodeAnalyses>> CodeAnalysesSnapshotWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeAnalysesApi : ICodeAnalysesApiSync, ICodeAnalysesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CodeAnalysesApi : ICodeAnalysesApi
    {
        private Pieces.Os.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeAnalysesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodeAnalysesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeAnalysesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodeAnalysesApi(string basePath)
        {
            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                new Pieces.Os.Core.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeAnalysesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CodeAnalysesApi(Pieces.Os.Core.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeAnalysesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CodeAnalysesApi(Pieces.Os.Core.Client.ISynchronousClient client, Pieces.Os.Core.Client.IAsynchronousClient asyncClient, Pieces.Os.Core.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Pieces.Os.Core.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Pieces.Os.Core.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Pieces.Os.Core.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Pieces.Os.Core.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Your GET endpoint This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeAnalyses</returns>
        public CodeAnalyses CodeAnalysesSnapshot(int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<CodeAnalyses> localVarResponse = CodeAnalysesSnapshotWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Your GET endpoint This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeAnalyses</returns>
        public Pieces.Os.Core.Client.ApiResponse<CodeAnalyses> CodeAnalysesSnapshotWithHttpInfo(int operationIndex = 0)
        {
            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "CodeAnalysesApi.CodeAnalysesSnapshot";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<CodeAnalyses>("/code_analyses", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeAnalysesSnapshot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Your GET endpoint This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeAnalyses</returns>
        public async System.Threading.Tasks.Task<CodeAnalyses> CodeAnalysesSnapshotAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<CodeAnalyses> localVarResponse = await CodeAnalysesSnapshotWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Your GET endpoint This will get a snapshot of all of your code analyses, a code analysis is attached to an analysis.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeAnalyses)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<CodeAnalyses>> CodeAnalysesSnapshotWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "CodeAnalysesApi.CodeAnalysesSnapshot";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CodeAnalyses>("/code_analyses", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeAnalysesSnapshot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
