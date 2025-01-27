# Reference
## Applications
<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">ListAsync</a>(ApplicationsListRequest { ... }) -> Pager<Application></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.ListAsync(new ApplicationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApplicationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">CreateAsync</a>(CreateApplicationRequest { ... }) -> Application</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.CreateAsync(
    new CreateApplicationRequest { Name = "name", Type = "type" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateApplicationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">GetAsync</a>(id) -> Application</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">UpdateAsync</a>(id, UpdateApplicationRequest { ... }) -> Application</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.UpdateAsync("id", new UpdateApplicationRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateApplicationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">GetByKeyAsync</a>() -> Application</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.GetByKeyAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplicationKeys
<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">ListAsync</a>(id, ApplicationKeysListRequest { ... }) -> IEnumerable<ApplicationKey></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationKeys.ListAsync("id", new ApplicationKeysListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ApplicationKeysListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">CreateAsync</a>(id) -> ApplicationKey</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationKeys.CreateAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">GetAsync</a>(id, keyId) -> ApplicationKey</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationKeys.GetAsync("id", "keyId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**keyId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">DeleteAsync</a>(id, keyId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationKeys.DeleteAsync("id", "keyId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**keyId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplicationTemplates
<details><summary><code>client.ApplicationTemplates.<a href="/src/BasisTheory.Client/ApplicationTemplates/ApplicationTemplatesClient.cs">ListAsync</a>() -> IEnumerable<ApplicationTemplate></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationTemplates.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplicationTemplates.<a href="/src/BasisTheory.Client/ApplicationTemplates/ApplicationTemplatesClient.cs">GetAsync</a>(id) -> ApplicationTemplate</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationTemplates.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tokens
<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">DetokenizeAsync</a>(object { ... }) -> object</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.DetokenizeAsync(new Dictionary<object, object?>() { { "key", "value" } });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">TokenizeAsync</a>(object { ... }) -> object</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.TokenizeAsync(new Dictionary<object, object?>() { { "key", "value" } });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">ListAsync</a>(TokensListRequest { ... }) -> Pager<Token></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.ListAsync(new TokensListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TokensListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">CreateAsync</a>(CreateTokenRequest { ... }) -> Token</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.CreateAsync(new CreateTokenRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">SearchAsync</a>(SearchTokensRequest { ... }) -> Pager<Token></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.SearchAsync(new SearchTokensRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchTokensRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">GetAsync</a>(id) -> Token</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">UpdateAsync</a>(id, UpdateTokenRequest { ... }) -> Token</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.UpdateAsync("id", new UpdateTokenRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">ListV2Async</a>(TokensListV2Request { ... }) -> Pager<Token></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.ListV2Async(new TokensListV2Request());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TokensListV2Request` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">SearchV2Async</a>(SearchTokensRequestV2 { ... }) -> Pager<Token></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.SearchV2Async(new SearchTokensRequestV2());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchTokensRequestV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Enrichments
<details><summary><code>client.Enrichments.<a href="/src/BasisTheory.Client/Enrichments/EnrichmentsClient.cs">BankAccountVerifyAsync</a>(BankVerificationRequest { ... }) -> BankVerificationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Enrichments.BankAccountVerifyAsync(
    new BankVerificationRequest { TokenId = "token_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BankVerificationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Googlepay
<details><summary><code>client.Googlepay.<a href="/src/BasisTheory.Client/Googlepay/GooglepayClient.cs">TokenizeAsync</a>(GooglePayTokenizeRequest { ... }) -> GooglePayTokenizeResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Googlepay.TokenizeAsync(new GooglePayTokenizeRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GooglePayTokenizeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Logs
<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">ListAsync</a>(LogsListRequest { ... }) -> Pager<Log></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Logs.ListAsync(new LogsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LogsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">GetEntityTypesAsync</a>() -> IEnumerable<LogEntityType></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Logs.GetEntityTypesAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Permissions
<details><summary><code>client.Permissions.<a href="/src/BasisTheory.Client/Permissions/PermissionsClient.cs">ListAsync</a>(PermissionsListRequest { ... }) -> IEnumerable<Permission></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Permissions.ListAsync(new PermissionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PermissionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Proxies
<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">ListAsync</a>(ProxiesListRequest { ... }) -> Pager<Proxy></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.ListAsync(new ProxiesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ProxiesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">CreateAsync</a>(CreateProxyRequest { ... }) -> Proxy</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.CreateAsync(
    new CreateProxyRequest { Name = "name", DestinationUrl = "destination_url" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateProxyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">GetAsync</a>(id) -> Proxy</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">UpdateAsync</a>(id, UpdateProxyRequest { ... }) -> Proxy</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.UpdateAsync(
    "id",
    new UpdateProxyRequest { Name = "name", DestinationUrl = "destination_url" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateProxyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">PatchAsync</a>(id, PatchProxyRequest { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.PatchAsync("id", new PatchProxyRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchProxyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reactors
<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ListAsync</a>(ReactorsListRequest { ... }) -> Pager<Reactor></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ListAsync(new ReactorsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReactorsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">CreateAsync</a>(CreateReactorRequest { ... }) -> Reactor</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.CreateAsync(new CreateReactorRequest { Name = "name", Code = "code" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateReactorRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">GetAsync</a>(id) -> Reactor</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">UpdateAsync</a>(id, UpdateReactorRequest { ... }) -> Reactor</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.UpdateAsync("id", new UpdateReactorRequest { Name = "name", Code = "code" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateReactorRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">PatchAsync</a>(id, PatchReactorRequest { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.PatchAsync("id", new PatchReactorRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchReactorRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsync</a>(id, ReactRequest { ... }) -> ReactResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ReactAsync("id", new ReactRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ReactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsyncAsync</a>(id, ReactRequestAsync { ... }) -> AsyncReactResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ReactAsyncAsync("id", new ReactRequestAsync());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ReactRequestAsync` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Roles
<details><summary><code>client.Roles.<a href="/src/BasisTheory.Client/Roles/RolesClient.cs">ListAsync</a>() -> IEnumerable<Role></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sessions
<details><summary><code>client.Sessions.<a href="/src/BasisTheory.Client/Sessions/SessionsClient.cs">CreateAsync</a>() -> CreateSessionResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sessions.CreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sessions.<a href="/src/BasisTheory.Client/Sessions/SessionsClient.cs">AuthorizeAsync</a>(AuthorizeSessionRequest { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Sessions.AuthorizeAsync(new AuthorizeSessionRequest { Nonce = "nonce" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthorizeSessionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## TokenIntents
<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">CreateAsync</a>(CreateTokenIntentRequest { ... }) -> CreateTokenIntentResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TokenIntents.CreateAsync(
    new CreateTokenIntentRequest
    {
        Type = "x",
        Data = new Dictionary<object, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTokenIntentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TokenIntents.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">PingAsync</a>()</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Simple endpoint that can be utilized to verify the application is running
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PingAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">GetAsync</a>(id) -> Webhook</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the webhook
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">UpdateAsync</a>(id, UpdateWebhookRequest { ... }) -> Webhook</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a new webhook
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.UpdateAsync(
    "id",
    new UpdateWebhookRequest
    {
        Name = "webhook-update",
        Url = "http://www.example.com",
        Events = new List<string>() { "token:created" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateWebhookRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a new webhook
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">ListAsync</a>() -> WebhookList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the configured webhooks
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">CreateAsync</a>(CreateWebhookRequest { ... }) -> Webhook</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new webhook
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.CreateAsync(
    new CreateWebhookRequest
    {
        Name = "webhook-create",
        Url = "http://www.example.com",
        Events = new List<string>() { "token:created" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateWebhookRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reactors Results
<details><summary><code>client.Reactors.Results.<a href="/src/BasisTheory.Client/Reactors/Results/ResultsClient.cs">GetAsync</a>(id, requestId) -> object</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.Results.GetAsync("id", "requestId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**requestId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Connections
<details><summary><code>client.Tenants.Connections.<a href="/src/BasisTheory.Client/Tenants/Connections/ConnectionsClient.cs">CreateAsync</a>(CreateTenantConnectionRequest { ... }) -> CreateTenantConnectionResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Connections.CreateAsync(
    new CreateTenantConnectionRequest
    {
        Strategy = "strategy",
        Options = new TenantConnectionOptions(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTenantConnectionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Connections.<a href="/src/BasisTheory.Client/Tenants/Connections/ConnectionsClient.cs">DeleteAsync</a>() -> CreateTenantConnectionResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Connections.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Invitations
<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">ListAsync</a>(InvitationsListRequest { ... }) -> Pager<TenantInvitationResponse></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.ListAsync(new InvitationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InvitationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">CreateAsync</a>(CreateTenantInvitationRequest { ... }) -> TenantInvitationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.CreateAsync(new CreateTenantInvitationRequest { Email = "email" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTenantInvitationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">ResendAsync</a>(invitationId) -> TenantInvitationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.ResendAsync("invitationId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**invitationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">GetAsync</a>(invitationId) -> TenantInvitationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.GetAsync("invitationId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**invitationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">DeleteAsync</a>(invitationId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.DeleteAsync("invitationId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**invitationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Members
<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">ListAsync</a>(MembersListRequest { ... }) -> TenantMemberResponsePaginatedList</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Members.ListAsync(new MembersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MembersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">UpdateAsync</a>(memberId, UpdateTenantMemberRequest { ... }) -> TenantMemberResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Members.UpdateAsync(
    "memberId",
    new UpdateTenantMemberRequest { Role = "role" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**memberId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateTenantMemberRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">DeleteAsync</a>(memberId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Members.DeleteAsync("memberId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**memberId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Owner
<details><summary><code>client.Tenants.Owner.<a href="/src/BasisTheory.Client/Tenants/Owner/OwnerClient.cs">GetAsync</a>() -> TenantMemberResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Owner.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Self
<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">GetUsageReportsAsync</a>() -> TenantUsageReport</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Self.GetUsageReportsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">GetAsync</a>() -> Tenant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Self.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">UpdateAsync</a>(UpdateTenantRequest { ... }) -> Tenant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Self.UpdateAsync(new UpdateTenantRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateTenantRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">DeleteAsync</a>()</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Self.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Threeds Sessions
<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">CreateAsync</a>(CreateThreeDsSessionRequest { ... }) -> CreateThreeDsSessionResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threeds.Sessions.CreateAsync(new CreateThreeDsSessionRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateThreeDsSessionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">AuthenticateAsync</a>(sessionId, AuthenticateThreeDsSessionRequest { ... }) -> ThreeDsAuthentication</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threeds.Sessions.AuthenticateAsync(
    "sessionId",
    new AuthenticateThreeDsSessionRequest
    {
        AuthenticationCategory = "authentication_category",
        AuthenticationType = "authentication_type",
        RequestorInfo = new ThreeDsRequestorInfo(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**sessionId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AuthenticateThreeDsSessionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">GetChallengeResultAsync</a>(sessionId) -> ThreeDsAuthentication</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threeds.Sessions.GetChallengeResultAsync("sessionId");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**sessionId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">GetAsync</a>(id) -> ThreeDsSession</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threeds.Sessions.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks Events
<details><summary><code>client.Webhooks.Events.<a href="/src/BasisTheory.Client/Webhooks/Events/EventsClient.cs">ListAsync</a>() -> IEnumerable<string></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a list of available event types
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.Events.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
