# BasisTheory C# Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-Built%20with%20Fern-brightgreen)](https://buildwithfern.com?utm_source=github&utm_medium=github&utm_campaign=readme&utm_source=https%3A%2F%2Fgithub.com%2FBasis-Theory%2Fdotnet-sdk)
[![nuget shield](https://img.shields.io/nuget/v/BasisTheory)](https://nuget.org/packages/BasisTheory)

The BasisTheory C# library provides convenient access to the BasisTheory APIs from C#.

## Table of Contents

- [Documentation](#documentation)
- [Installation](#installation)
- [Reference](#reference)
- [Usage](#usage)
- [Environments](#environments)
- [Exception Handling](#exception-handling)
- [Pagination](#pagination)
- [Advanced](#advanced)
  - [Retries](#retries)
  - [Timeouts](#timeouts)
  - [Raw Response](#raw-response)
  - [Additional Headers](#additional-headers)
  - [Additional Query Parameters](#additional-query-parameters)
- [Contributing](#contributing)
- [Requirements](#requirements)

## Documentation

API reference documentation is available [here](https://api.basistheory.com).

## Installation

```sh
dotnet add package BasisTheory
```

## Reference

A full reference for this library is available [here](https://github.com/Basis-Theory/dotnet-sdk/blob/HEAD/./reference.md).

## Usage

Instantiate and use the client with the following:

```csharp


var client = new global::BasisTheory.Client.BasisTheory("API_KEY", "CORRELATION_ID");
await client.Tenants.Self.GetAsync();
```

## Environments

This SDK allows you to configure different environments for API requests.

```csharp
using BasisTheory.Client;

var client = new BasisTheory(new ClientOptions
{
    BaseUrl = BasisTheoryEnvironment.Default
});
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), a subclass of the following error
will be thrown.

```csharp
using BasisTheory.Client;

try {
    var response = await client.Tenants.Self.GetAsync(...);
} catch (BasisTheoryApiException e) {
    System.Console.WriteLine(e.Body);
    System.Console.WriteLine(e.StatusCode);
}
```

## Pagination

List endpoints are paginated. The SDK provides an async enumerable so that you can simply loop over the items:

```csharp
using global::BasisTheory.Client;

var client = new global::BasisTheory.Client.BasisTheory("API_KEY", "CORRELATION_ID");
var items = await client.Applications.ListAsync(
    new ApplicationsListRequest
    {
        Page = 1,
        Start = "start",
        Size = 1,
    }
);

await foreach (var item in items)
{
    // do something with item
}
```

## Advanced

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retryable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retryable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `MaxRetries` request option to configure this behavior.

```csharp
var response = await client.Tenants.Self.GetAsync(
    ...,
    new RequestOptions {
        MaxRetries: 0 // Override MaxRetries at the request level
    }
);
```

### Timeouts

The SDK defaults to a 30 second timeout. Use the `Timeout` option to configure this behavior.

```csharp
var response = await client.Tenants.Self.GetAsync(
    ...,
    new RequestOptions {
        Timeout: TimeSpan.FromSeconds(3) // Override timeout to 3s
    }
);
```

### Raw Response

Access raw HTTP response data (status code, headers, URL) alongside parsed response data using the `.WithRawResponse()` method.

```csharp
using BasisTheory.Client;

// Access raw response data (status code, headers, etc.) alongside the parsed response
var result = await client.Tenants.Self.GetAsync(...).WithRawResponse();

// Access the parsed data
var data = result.Data;

// Access raw response metadata
var statusCode = result.RawResponse.StatusCode;
var headers = result.RawResponse.Headers;
var url = result.RawResponse.Url;

// Access specific headers (case-insensitive)
if (headers.TryGetValue("X-Request-Id", out var requestId))
{
    System.Console.WriteLine($"Request ID: {requestId}");
}

// For the default behavior, simply await without .WithRawResponse()
var data = await client.Tenants.Self.GetAsync(...);
```

### Additional Headers

If you would like to send additional headers as part of the request, use the `AdditionalHeaders` request option.

```csharp
var response = await client.Tenants.Self.GetAsync(
    ...,
    new RequestOptions {
        AdditionalHeaders = new Dictionary<string, string?>
        {
            { "X-Custom-Header", "custom-value" }
        }
    }
);
```

### Additional Query Parameters

If you would like to send additional query parameters as part of the request, use the `AdditionalQueryParameters` request option.

```csharp
var response = await client.Tenants.Self.GetAsync(
    ...,
    new RequestOptions {
        AdditionalQueryParameters = new Dictionary<string, string>
        {
            { "custom_param", "custom-value" }
        }
    }
);
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
## Requirements

This SDK requires:

