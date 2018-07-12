/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Square.Connect.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrdersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// BatchRetrieveOrders
        /// </summary>
        /// <remarks>
        /// Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>BatchRetrieveOrdersResponse</returns>
        BatchRetrieveOrdersResponse BatchRetrieveOrders (string locationId, BatchRetrieveOrdersRequest body);

        /// <summary>
        /// BatchRetrieveOrders
        /// </summary>
        /// <remarks>
        /// Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of BatchRetrieveOrdersResponse</returns>
        ApiResponse<BatchRetrieveOrdersResponse> BatchRetrieveOrdersWithHttpInfo (string locationId, BatchRetrieveOrdersRequest body);
        /// <summary>
        /// CreateOrder
        /// </summary>
        /// <remarks>
        /// Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateOrderResponse</returns>
        CreateOrderResponse CreateOrder (string locationId, CreateOrderRequest body);

        /// <summary>
        /// CreateOrder
        /// </summary>
        /// <remarks>
        /// Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateOrderResponse</returns>
        ApiResponse<CreateOrderResponse> CreateOrderWithHttpInfo (string locationId, CreateOrderRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// BatchRetrieveOrders
        /// </summary>
        /// <remarks>
        /// Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of BatchRetrieveOrdersResponse</returns>
        System.Threading.Tasks.Task<BatchRetrieveOrdersResponse> BatchRetrieveOrdersAsync (string locationId, BatchRetrieveOrdersRequest body);

        /// <summary>
        /// BatchRetrieveOrders
        /// </summary>
        /// <remarks>
        /// Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (BatchRetrieveOrdersResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchRetrieveOrdersResponse>> BatchRetrieveOrdersAsyncWithHttpInfo (string locationId, BatchRetrieveOrdersRequest body);
        /// <summary>
        /// CreateOrder
        /// </summary>
        /// <remarks>
        /// Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateOrderResponse</returns>
        System.Threading.Tasks.Task<CreateOrderResponse> CreateOrderAsync (string locationId, CreateOrderRequest body);

        /// <summary>
        /// CreateOrder
        /// </summary>
        /// <remarks>
        /// Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateOrderResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateOrderResponse>> CreateOrderAsyncWithHttpInfo (string locationId, CreateOrderRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrdersApi : IOrdersApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrdersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Square.Connect.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// BatchRetrieveOrders Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>BatchRetrieveOrdersResponse</returns>
        public BatchRetrieveOrdersResponse BatchRetrieveOrders (string locationId, BatchRetrieveOrdersRequest body)
        {
             ApiResponse<BatchRetrieveOrdersResponse> localVarResponse = BatchRetrieveOrdersWithHttpInfo(locationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// BatchRetrieveOrders Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of BatchRetrieveOrdersResponse</returns>
        public ApiResponse< BatchRetrieveOrdersResponse > BatchRetrieveOrdersWithHttpInfo (string locationId, BatchRetrieveOrdersRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling OrdersApi->BatchRetrieveOrders");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrdersApi->BatchRetrieveOrders");

            var localVarPath = "/v2/locations/{location_id}/orders/batch-retrieve";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2018-07-12");
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchRetrieveOrders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BatchRetrieveOrdersResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BatchRetrieveOrdersResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchRetrieveOrdersResponse)));
            
        }

        /// <summary>
        /// BatchRetrieveOrders Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of BatchRetrieveOrdersResponse</returns>
        public async System.Threading.Tasks.Task<BatchRetrieveOrdersResponse> BatchRetrieveOrdersAsync (string locationId, BatchRetrieveOrdersRequest body)
        {
             ApiResponse<BatchRetrieveOrdersResponse> localVarResponse = await BatchRetrieveOrdersAsyncWithHttpInfo(locationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// BatchRetrieveOrders Retrieves a set of [Order](#type-order)s by their IDs.  If a given Order ID does not exist, the ID is ignored instead of generating an error.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the orders&#39; associated location.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (BatchRetrieveOrdersResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BatchRetrieveOrdersResponse>> BatchRetrieveOrdersAsyncWithHttpInfo (string locationId, BatchRetrieveOrdersRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling OrdersApi->BatchRetrieveOrders");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrdersApi->BatchRetrieveOrders");

            var localVarPath = "/v2/locations/{location_id}/orders/batch-retrieve";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchRetrieveOrders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BatchRetrieveOrdersResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BatchRetrieveOrdersResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchRetrieveOrdersResponse)));
            
        }

        /// <summary>
        /// CreateOrder Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>CreateOrderResponse</returns>
        public CreateOrderResponse CreateOrder (string locationId, CreateOrderRequest body)
        {
             ApiResponse<CreateOrderResponse> localVarResponse = CreateOrderWithHttpInfo(locationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateOrder Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateOrderResponse</returns>
        public ApiResponse< CreateOrderResponse > CreateOrderWithHttpInfo (string locationId, CreateOrderRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling OrdersApi->CreateOrder");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrdersApi->CreateOrder");

            var localVarPath = "/v2/locations/{location_id}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            localVarHeaderParams.Add("Square-Version", "2018-07-12");
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateOrderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateOrderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateOrderResponse)));
            
        }

        /// <summary>
        /// CreateOrder Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of CreateOrderResponse</returns>
        public async System.Threading.Tasks.Task<CreateOrderResponse> CreateOrderAsync (string locationId, CreateOrderRequest body)
        {
             ApiResponse<CreateOrderResponse> localVarResponse = await CreateOrderAsyncWithHttpInfo(locationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateOrder Creates an [Order](#type-order) that can then be referenced as &#x60;order_id&#x60; in a request to the [Charge](#endpoint-charge) endpoint. Orders specify products for purchase, along with discounts, taxes, and other settings to apply to the purchase.  To associate a created order with a request to the Charge endpoint, provide the order&#39;s &#x60;id&#x60; in the &#x60;order_id&#x60; field of your request.  You cannot modify an order after you create it. If you need to modify an order, instead create a new order with modified details.  To learn more about the Orders API, see the [Orders API Overview](https://docs.connect.squareup.com/articles/orders-api-overview).
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">The ID of the business location to associate the order with.</param>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateOrderResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateOrderResponse>> CreateOrderAsyncWithHttpInfo (string locationId, CreateOrderRequest body)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling OrdersApi->CreateOrder");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrdersApi->CreateOrder");

            var localVarPath = "/v2/locations/{location_id}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateOrderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateOrderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateOrderResponse)));
            
        }

    }
}
