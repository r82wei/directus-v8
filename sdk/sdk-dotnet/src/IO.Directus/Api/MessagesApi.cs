/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Directus.Client;
using IO.Directus.Model;

namespace IO.Directus.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns specific message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>GetMessage</returns>
        GetMessage GetMessage (int? messageId);

        /// <summary>
        /// Returns specific message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>ApiResponse of GetMessage</returns>
        ApiResponse<GetMessage> GetMessageWithHttpInfo (int? messageId);
        /// <summary>
        /// Returns messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetMessages</returns>
        GetMessages GetMessages ();

        /// <summary>
        /// Returns messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetMessages</returns>
        ApiResponse<GetMessages> GetMessagesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns specific message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>Task of GetMessage</returns>
        System.Threading.Tasks.Task<GetMessage> GetMessageAsync (int? messageId);

        /// <summary>
        /// Returns specific message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>Task of ApiResponse (GetMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMessage>> GetMessageAsyncWithHttpInfo (int? messageId);
        /// <summary>
        /// Returns messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetMessages</returns>
        System.Threading.Tasks.Task<GetMessages> GetMessagesAsync ();

        /// <summary>
        /// Returns messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetMessages)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMessages>> GetMessagesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagesApi : IMessagesApi
    {
        private IO.Directus.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Directus.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Directus.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Directus.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns specific message 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>GetMessage</returns>
        public GetMessage GetMessage (int? messageId)
        {
             ApiResponse<GetMessage> localVarResponse = GetMessageWithHttpInfo(messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns specific message 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>ApiResponse of GetMessage</returns>
        public ApiResponse< GetMessage > GetMessageWithHttpInfo (int? messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagesApi->GetMessage");

            var localVarPath = "/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMessage)));
        }

        /// <summary>
        /// Returns specific message 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>Task of GetMessage</returns>
        public async System.Threading.Tasks.Task<GetMessage> GetMessageAsync (int? messageId)
        {
             ApiResponse<GetMessage> localVarResponse = await GetMessageAsyncWithHttpInfo(messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns specific message 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">ID of message to return</param>
        /// <returns>Task of ApiResponse (GetMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMessage>> GetMessageAsyncWithHttpInfo (int? messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagesApi->GetMessage");

            var localVarPath = "/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMessage)));
        }

        /// <summary>
        /// Returns messages 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetMessages</returns>
        public GetMessages GetMessages ()
        {
             ApiResponse<GetMessages> localVarResponse = GetMessagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns messages 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetMessages</returns>
        public ApiResponse< GetMessages > GetMessagesWithHttpInfo ()
        {

            var localVarPath = "/messages/self";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMessages)));
        }

        /// <summary>
        /// Returns messages 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetMessages</returns>
        public async System.Threading.Tasks.Task<GetMessages> GetMessagesAsync ()
        {
             ApiResponse<GetMessages> localVarResponse = await GetMessagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns messages 
        /// </summary>
        /// <exception cref="IO.Directus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetMessages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMessages>> GetMessagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/messages/self";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMessages)));
        }

    }
}