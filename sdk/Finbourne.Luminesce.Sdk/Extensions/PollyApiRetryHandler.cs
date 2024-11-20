/*
 * LUSID API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Finbourne.Luminesce.Sdk.Client;
using SdkConfiguration = Finbourne.Luminesce.Sdk.Client.Configuration;
using Polly;
using Polly.Retry;
using Polly.Wrap;

namespace Finbourne.Luminesce.Sdk.Extensions
{
    /// <summary>
    /// Class used to define API error retry rules for all API calls.
    /// </summary>
    public static class PollyApiRetryHandler
    {
        /// <summary>
        /// Number of max default retry attempts
        /// </summary>
        public const int DefaultNumberOfRetries = 2;

        /// <summary>
        /// Get the Polly retry condition on which to retry.
        /// </summary>
        /// <param name="response">Response object that comes from the API Client</param>
        /// <returns>The boolean of whether the Polly retry condition is satisfied</returns>
        public static bool GetPollyRetryCondition(ResponseBase response)
        {
            // Retry on concurrency conflict failures
            bool concurrencyConflictCondition = response.StatusCode == (HttpStatusCode)409;

            return concurrencyConflictCondition;
        }

        /// <summary>
        /// Get the Polly retry condition on which to retry.
        /// </summary>
        /// <param name="response">Response object that comes from the API Client</param>
        /// <returns>The boolean of whether the Polly retry condition is satisfied</returns>
        public static bool GetPollyRateLimitRetryCondition(ResponseBase response)
        {
            if (response == null) return false;
            // Retry on rate limit hit:
            bool rateLimitHitCondition = response.StatusCode == (HttpStatusCode)429;
            return rateLimitHitCondition;
        }

        private static void HandleRetryAction(DelegateResult<ResponseBase> result, int retryCount, Context ctx)
        {
        }

        #region Synchronous Retry Policies

        /// <summary>
        /// Retry policy with an action to return the failed response after retries have exceeded.
        /// Use .Wrap() method to combine this policy with your other custom policies
        /// </summary>
        public static readonly PolicyWrap<ResponseBase> DefaultRetryPolicyWithFallback =
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            DefaultFallbackPolicy.Wrap(DefaultRetryPolicy);

        /// <summary>
        /// Combines DefaultFallbackPolicy and GetDefaultRetryPolicyWithRateLimit.
        /// Use .Wrap() method to combine this policy with your other custom policies
        /// </summary>
        /// <param name="rateLimitRetries"></param>
        /// <returns></returns>
        public static PolicyWrap<ResponseBase> GetDefaultRetryPolicyWithRateLimitWithFallback(int rateLimitRetries)
        {
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            return DefaultFallbackPolicy.Wrap(GetDefaultRetryPolicyWithRateLimit(rateLimitRetries));
        }

        /// <summary>
        /// Causes the actual API response to be returned after retries have been exceeded.
        /// It is necessary to use with OpenAPI, as without it a null result will be returned
        /// </summary>
        /// <returns>Fallback Policy (Synchronous)</returns>
        public static Policy<ResponseBase> DefaultFallbackPolicy =>
            Policy<ResponseBase>
                .Handle<Exception>()
                .Fallback(
                    (outcome, ctx, ct) => outcome.Result,
                    (outcome, ctx) => {
                        // Add logging or other logic here
                    });


        /// <summary>
        /// Define Polly retry policy for synchronous API calls.
        /// </summary>
        public static Policy<ResponseBase> DefaultRetryPolicy =>
            Policy
                .HandleResult<ResponseBase>(GetPollyRetryCondition)
                .Retry(retryCount: DefaultNumberOfRetries, onRetry: HandleRetryAction);

        /// <summary>
        /// Retry policy wrap that handles rate limit codes (409) as well as the default retry policy.
        /// Use .Wrap() method to combine this policy with your other custom policies.
        /// </summary>
        /// <returns> Policy Wraps (Synchronous)</returns>
        public static PolicyWrap<ResponseBase> DefaultRetryPolicyWithRateLimit =>
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            GetDefaultRetryPolicyWithRateLimit(SdkConfiguration.DefaultRateLimitRetries);

        private static PolicyWrap<ResponseBase> GetDefaultRetryPolicyWithRateLimit(int rateLimitRetries)
        {
            return DefaultRetryPolicy.Wrap(GetRateLimitRetryPolicy(rateLimitRetries));
        }

        /// <summary>
        /// Defines policy for handling rate limit (429) http response codes.
        /// </summary>
        public static Policy<ResponseBase> RateLimitRetryPolicy => GetRateLimitRetryPolicy(GlobalConfiguration.Instance.RateLimitRetries);

        private static RetryPolicy<ResponseBase> GetRateLimitRetryPolicy(int rateLimitRetries)
        {
            return Policy
                .HandleResult<ResponseBase>(GetPollyRateLimitRetryCondition)
                .WaitAndRetry(rateLimitRetries, RateLimitSleepDurationProvider, OnRetry);
        }

        private static void OnRetry(DelegateResult<ResponseBase> arg1, TimeSpan arg2, Context arg3)
        {
        }

        #endregion

        #region Async Retry Policies

        /// <summary>
        /// Retry policy with an action to return the failed response after retries have exceeded.
        /// Use .WrapAsync() method to combine this policy with your other custom policies
        /// </summary>
        public static readonly AsyncPolicyWrap<ResponseBase> DefaultRetryPolicyWithFallbackAsync =
            DefaultFallbackPolicyAsync.WrapAsync(DefaultRetryPolicyAsync);

        /// <summary>
        /// Combines DefaultFallbackPolicyAsync and GetAsyncDefaultRetryPolicyWithRateLimit.
        /// Use .Wrap() method to combine this policy with your other custom policies
        /// </summary>
        /// <param name="rateLimitRetries"></param>
        /// <returns></returns>
        public static AsyncPolicyWrap<ResponseBase> GetDefaultRetryPolicyWithRateLimitRetryWithFallbackAsync(int rateLimitRetries)
        {
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            return DefaultFallbackPolicyAsync.WrapAsync(GetAsyncDefaultRetryPolicyWithRateLimit(rateLimitRetries));
        }

        /// <summary>
        /// Define Polly retry policy for asynchronous API calls.
        /// </summary>
        public static AsyncPolicy<ResponseBase> DefaultRetryPolicyAsync =>
            Policy
                .HandleResult<ResponseBase>(GetPollyRetryCondition)
                .RetryAsync(retryCount: DefaultNumberOfRetries, onRetry: HandleRetryAction);

        /// <summary>
        /// Defines async policy for handling rate limit (429) http response codes.
        /// </summary>
        public static AsyncPolicy<ResponseBase> AsyncRateLimitRetryPolicy
            => GetAsyncRateLimitRetryPolicy(GlobalConfiguration.Instance.RateLimitRetries);

        private static AsyncPolicy<ResponseBase> GetAsyncRateLimitRetryPolicy(int rateLimitRetries)
        {
            return Policy.HandleResult<ResponseBase>(GetPollyRateLimitRetryCondition)
                .WaitAndRetryAsync(rateLimitRetries, RateLimitSleepDurationProvider, OnRetryAsync);
        }

        private static Task OnRetryAsync(DelegateResult<ResponseBase> arg1, TimeSpan arg2, int arg3, Context arg4)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Causes the actual API response to be returned after retries have been exceeded.
        /// It is necessary to use with OpenAPI, as without it a null result will be returned
        /// </summary>
        /// <returns>Fallback Policy (Asynchronous)</returns>
        public static AsyncPolicy<ResponseBase> DefaultFallbackPolicyAsync =>
            Policy<ResponseBase>
                .Handle<Exception>()
                .FallbackAsync(
                    (outcome, b, c) => Task.FromException<ResponseBase>(outcome.Exception),
                    (outcome, ctx) =>
                    {
                        // Add logging or other logic here 
                        if (Environment.GetEnvironmentVariable("SDK_LOGGING") != null)
                        {
                            Console.WriteLine("ASYNC FALLBACK action triggered: {0}", ctx.CorrelationId);
                            Console.WriteLine("Outcome Result: {0}", outcome.Result);
                            Console.WriteLine("Outcome Exception: {0}", outcome.Exception);
                        }
                        return Task.CompletedTask;
                    });

        /// <summary>
        /// Async retry policy wrap that handles rate limit codes (409) as well as the default retry policy.
        /// Use .WrapAsync() method to combine this policy with your other custom policies.
        /// </summary>
        /// <returns>Policy Wrap (Async)</returns>
        public static AsyncPolicyWrap<ResponseBase> AsyncDefaultRetryPolicyWithRateLimit =>
            GetAsyncDefaultRetryPolicyWithRateLimit(GlobalConfiguration.Instance.RateLimitRetries);

        private static AsyncPolicyWrap<ResponseBase> GetAsyncDefaultRetryPolicyWithRateLimit(int rateLimitRetries)
        {
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            return DefaultRetryPolicyAsync.WrapAsync(GetAsyncRateLimitRetryPolicy(rateLimitRetries));
        }

        #endregion

        private static TimeSpan RateLimitSleepDurationProvider(int attemptCount,
            DelegateResult<ResponseBase> response, Context context)
        {
            var retryAfterHeader = response?.Result?.Headers?.SingleOrDefault(h => h.Name == "Retry-After");
            double secondsInterval = 0;
            if (retryAfterHeader != null)
            {
                var value = retryAfterHeader.Value?.ToString();
                double.TryParse(value, out secondsInterval);
            }

            if (secondsInterval == 0)
            {
                secondsInterval = Math.Pow(2, attemptCount);
            }

            return TimeSpan.FromSeconds(secondsInterval);
        }
    }
}