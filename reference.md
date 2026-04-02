# Reference
## Applications
<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">ListAsync</a>(ApplicationsListRequest { ... }) -> Core.Pager&lt;Application&gt;</code></summary>
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
<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">ListAsync</a>(id, ApplicationKeysListRequest { ... }) -> IEnumerable&lt;ApplicationKey&gt;</code></summary>
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
<details><summary><code>client.ApplicationTemplates.<a href="/src/BasisTheory.Client/ApplicationTemplates/ApplicationTemplatesClient.cs">ListAsync</a>() -> IEnumerable&lt;ApplicationTemplate&gt;</code></summary>
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

## ApplePay
<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">CreateAsync</a>(ApplePayCreateRequest { ... }) -> ApplePayCreateResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.CreateAsync(new ApplePayCreateRequest());
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

**request:** `ApplePayCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">GetAsync</a>(id) -> ApplePayToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.GetAsync("id");
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

<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">DeleteAsync</a>(id) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.DeleteAsync("id");
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

## GooglePay
<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">CreateAsync</a>(GooglePayCreateRequest { ... }) -> GooglePayCreateResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.CreateAsync(new GooglePayCreateRequest());
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

**request:** `GooglePayCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">GetAsync</a>(id) -> GooglePayToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.GetAsync("id");
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

<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">DeleteAsync</a>(id) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.DeleteAsync("id");
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

## Documents
<details><summary><code>client.Documents.<a href="/src/BasisTheory.Client/Documents/DocumentsClient.cs">GetAsync</a>(id) -> Document</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.GetAsync("id");
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

<details><summary><code>client.Documents.<a href="/src/BasisTheory.Client/Documents/DocumentsClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.DeleteAsync("id");
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">ListV2Async</a>(TokensListV2Request { ... }) -> Core.Pager&lt;Token&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">SearchV2Async</a>(SearchTokensRequestV2 { ... }) -> Core.Pager&lt;Token&gt;</code></summary>
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

<details><summary><code>client.Enrichments.<a href="/src/BasisTheory.Client/Enrichments/EnrichmentsClient.cs">GetcarddetailsAsync</a>(EnrichmentsGetCardDetailsRequest { ... }) -> CardDetailsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Enrichments.GetcarddetailsAsync(new EnrichmentsGetCardDetailsRequest { Bin = "bin" });
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

**request:** `EnrichmentsGetCardDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Keys
<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">ListAsync</a>() -> IEnumerable&lt;ClientEncryptionKeyMetadataResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Keys.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">CreateAsync</a>(ClientEncryptionKeyRequest { ... }) -> ClientEncryptionKeyResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Keys.CreateAsync(new ClientEncryptionKeyRequest());
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

**request:** `ClientEncryptionKeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">GetAsync</a>(id) -> ClientEncryptionKeyMetadataResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Keys.GetAsync("id");
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

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Keys.DeleteAsync("id");
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

## Logs
<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">ListAsync</a>(LogsListRequest { ... }) -> Core.Pager&lt;Log&gt;</code></summary>
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

<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">GetEntityTypesAsync</a>() -> IEnumerable&lt;LogEntityType&gt;</code></summary>
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

## NetworkTokens
<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">CreateAsync</a>(CreateNetworkTokenRequest { ... }) -> NetworkToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.CreateAsync(new CreateNetworkTokenRequest());
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

**request:** `CreateNetworkTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">CryptogramAsync</a>(id) -> NetworkTokenCryptogram</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.CryptogramAsync("id");
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">GetAsync</a>(id) -> NetworkToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.GetAsync("id");
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.DeleteAsync("id");
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">SuspendAsync</a>(id) -> NetworkToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.SuspendAsync("id");
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">ResumeAsync</a>(id) -> NetworkToken</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.ResumeAsync("id");
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

## Permissions
<details><summary><code>client.Permissions.<a href="/src/BasisTheory.Client/Permissions/PermissionsClient.cs">ListAsync</a>(PermissionsListRequest { ... }) -> IEnumerable&lt;Permission&gt;</code></summary>
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
<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">ListAsync</a>(ProxiesListRequest { ... }) -> Core.Pager&lt;Proxy&gt;</code></summary>
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
<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ListAsync</a>(ReactorsListRequest { ... }) -> Core.Pager&lt;Reactor&gt;</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsync</a>(id, object { ... }) -> ReactResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ReactAsync("id", new Dictionary<object, object?>() { { "key", "value" } });
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

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsyncAsync</a>(id, object { ... }) -> AsyncReactResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ReactAsyncAsync(
    "id",
    new Dictionary<object, object?>() { { "key", "value" } }
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

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Roles
<details><summary><code>client.Roles.<a href="/src/BasisTheory.Client/Roles/RolesClient.cs">ListAsync</a>() -> IEnumerable&lt;Role&gt;</code></summary>
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
<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">GetAsync</a>(id) -> TokenIntent</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TokenIntents.GetAsync("id");
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

## AccountUpdater Jobs
<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">GetAsync</a>(id) -> AccountUpdaterJob</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the account updater batch job
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
await client.AccountUpdater.Jobs.GetAsync("id");
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

<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">ListAsync</a>(AccountUpdater.JobsListRequest { ... }) -> AccountUpdaterJobList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of account updater batch jobs
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
await client.AccountUpdater.Jobs.ListAsync(new JobsListRequest());
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

**request:** `AccountUpdater.JobsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">CreateAsync</a>() -> AccountUpdaterJob</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the created account updater batch job
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
await client.AccountUpdater.Jobs.CreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## AccountUpdater RealTime
<details><summary><code>client.AccountUpdater.RealTime.<a href="/src/BasisTheory.Client/AccountUpdater/RealTime/RealTimeClient.cs">InvokeAsync</a>(AccountUpdater.AccountUpdaterRealTimeRequest { ... }) -> AccountUpdaterRealTimeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the update result
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
await client.AccountUpdater.RealTime.InvokeAsync(
    new AccountUpdaterRealTimeRequest { TokenId = "9a420b15-ddfe-4793-9466-48f53520e47c" }
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

**request:** `AccountUpdater.AccountUpdaterRealTimeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents
<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">CreateAsync</a>(Agentic.CreateAgentRequest { ... }) -> Agent</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.CreateAsync(new CreateAgentRequest { Name = "name" });
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

**request:** `Agentic.CreateAgentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">GetAsync</a>(agentId) -> Agent</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.GetAsync("agent_id");
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

**agentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">DeleteAsync</a>(agentId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.DeleteAsync("agent_id");
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

**agentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">UpdateAsync</a>(agentId, Agentic.UpdateAgentRequest { ... }) -> Agent</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.UpdateAsync("agent_id", new UpdateAgentRequest());
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.UpdateAgentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Enrollments
<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">ListAsync</a>(Agentic.EnrollmentsListRequest { ... }) -> EnrollmentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all enrollments for the current tenant with cursor-based pagination.
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
await client.Agentic.Enrollments.ListAsync(new EnrollmentsListRequest());
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

**request:** `Agentic.EnrollmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">CreateAsync</a>(Agentic.CreateEnrollmentRequest { ... }) -> Enrollment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Enroll a card token with a card network (Visa or Mastercard).
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
await client.Agentic.Enrollments.CreateAsync(
    new CreateEnrollmentRequest
    {
        TokenId = "token_id",
        Consumer = new Consumer { Email = "email" },
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

**request:** `Agentic.CreateEnrollmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">GetAsync</a>(enrollmentId) -> Enrollment</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Enrollments.GetAsync("enrollment_id");
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

**enrollmentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">DeleteAsync</a>(enrollmentId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Soft-deletes the enrollment by marking its status as deleted.
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
await client.Agentic.Enrollments.DeleteAsync("enrollment_id");
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

**enrollmentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">RetryAsync</a>(enrollmentId) -> Enrollment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retry enrolling a card that previously failed. Only failed enrollments can be retried.
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
await client.Agentic.Enrollments.RetryAsync("enrollment_id");
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

**enrollmentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents Instructions
<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">ListAsync</a>(agentId, Agentic.Agents.InstructionsListRequest { ... }) -> InstructionList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all purchase instructions for an agent with cursor-based pagination and optional enrollment filter.
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
await client.Agentic.Agents.Instructions.ListAsync("agent_id", new InstructionsListRequest());
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Agents.InstructionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">CreateAsync</a>(agentId, Agentic.Agents.CreateInstructionRequest { ... }) -> Instruction</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new payment instruction for an agent, linked to an enrollment.
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
await client.Agentic.Agents.Instructions.CreateAsync(
    "agent_id",
    new CreateInstructionRequest
    {
        EnrollmentId = "enrollment_id",
        Amount = new Amount { Value = "100.00" },
        Description = "description",
        ExpiresAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Agents.CreateInstructionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">GetAsync</a>(agentId, instructionId) -> Instruction</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.Instructions.GetAsync("agent_id", "instruction_id");
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">DeleteAsync</a>(agentId, instructionId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.Instructions.DeleteAsync("agent_id", "instruction_id");
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">UpdateAsync</a>(agentId, instructionId, Agentic.Agents.UpdateInstructionRequest { ... }) -> Instruction</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Agents.Instructions.UpdateAsync(
    "agent_id",
    "instruction_id",
    new UpdateInstructionRequest()
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Agents.UpdateInstructionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents Instructions Credentials
<details><summary><code>client.Agentic.Agents.Instructions.Credentials.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Credentials/CredentialsClient.cs">CreateAsync</a>(agentId, instructionId, Agentic.Agents.Instructions.GetCredentialsRequest { ... }) -> Credentials</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve payment credentials (card number, expiration, CVC) for a purchase instruction.
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
await client.Agentic.Agents.Instructions.Credentials.CreateAsync(
    "agent_id",
    "instruction_id",
    new GetCredentialsRequest
    {
        Merchant = new BasisTheory.Client.Merchant
        {
            Name = "name",
            Url = "url",
            CountryCode = "country_code",
        },
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Agents.Instructions.GetCredentialsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents Instructions Verify
<details><summary><code>client.Agentic.Agents.Instructions.Verify.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Verify/VerifyClient.cs">StartAsync</a>(agentId, instructionId, StartVerificationRequest { ... }) -> VerificationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Initiate cardholder verification for a purchase instruction that requires it.
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
await client.Agentic.Agents.Instructions.Verify.StartAsync(
    "agent_id",
    "instruction_id",
    new StartVerificationRequest
    {
        DeviceContext = new DeviceContext
        {
            ScreenHeight = 1,
            ScreenWidth = 1,
            UserAgentString = "user_agent_string",
            LanguageCode = "language_code",
            TimeZone = "time_zone",
            JavaScriptEnabled = true,
            ClientDeviceId = "client_device_id",
            ClientReferenceId = "client_reference_id",
            PlatformType = DeviceContextPlatformType.Web,
        },
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `StartVerificationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.Verify.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Verify/VerifyClient.cs">PasskeyAsync</a>(agentId, instructionId, Agentic.Agents.Instructions.SubmitPasskeyRequest { ... }) -> Instruction</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Submit passkey/FIDO assertion data to complete instruction verification.
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
await client.Agentic.Agents.Instructions.Verify.PasskeyAsync(
    "agent_id",
    "instruction_id",
    new SubmitPasskeyRequest
    {
        AssuranceData = new Dictionary<string, object>() { { "key", "value" } },
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

**agentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**instructionId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Agents.Instructions.SubmitPasskeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Enrollments Verify
<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">StartAsync</a>(enrollmentId, StartVerificationRequest { ... }) -> VerificationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Initiates the cardholder verification flow for a pending enrollment.
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
await client.Agentic.Enrollments.Verify.StartAsync(
    "enrollment_id",
    new StartVerificationRequest
    {
        DeviceContext = new DeviceContext
        {
            ScreenHeight = 1,
            ScreenWidth = 1,
            UserAgentString = "user_agent_string",
            LanguageCode = "language_code",
            TimeZone = "time_zone",
            JavaScriptEnabled = true,
            ClientDeviceId = "client_device_id",
            ClientReferenceId = "client_reference_id",
            PlatformType = DeviceContextPlatformType.Web,
        },
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

**enrollmentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `StartVerificationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">MethodAsync</a>(enrollmentId, Agentic.Enrollments.SelectMethodRequest { ... }) -> VerificationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Choose the OTP delivery method (SMS, email, etc.) for enrollment verification.
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
await client.Agentic.Enrollments.Verify.MethodAsync(
    "enrollment_id",
    new SelectMethodRequest { MethodId = "method_id" }
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

**enrollmentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Enrollments.SelectMethodRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">OtpAsync</a>(enrollmentId, Agentic.Enrollments.SubmitOtpRequest { ... }) -> Enrollment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Submit the one-time password received by the cardholder.
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
await client.Agentic.Enrollments.Verify.OtpAsync(
    "enrollment_id",
    new SubmitOtpRequest { OtpCode = "otp_code" }
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

**enrollmentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Enrollments.SubmitOtpRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">CompleteAsync</a>(enrollmentId, Agentic.Enrollments.CompleteVerificationRequest { ... }) -> Enrollment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Complete the verification flow (e.g. after passkey creation). Body is optional — Visa sends empty body, Mastercard sends assurance_data.
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
await client.Agentic.Enrollments.Verify.CompleteAsync(
    "enrollment_id",
    new CompleteVerificationRequest()
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

**enrollmentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Agentic.Enrollments.CompleteVerificationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Merchant
<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">GetAsync</a>(id) -> ApplePayMerchant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.GetAsync("id");
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

<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.DeleteAsync("id");
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

<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">CreateAsync</a>(ApplePay.ApplePayMerchantRegisterRequest { ... }) -> ApplePayMerchant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.CreateAsync(new ApplePayMerchantRegisterRequest());
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

**request:** `ApplePay.ApplePayMerchantRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Domain
<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">DeregisterAsync</a>(ApplePay.ApplePayDomainDeregistrationRequest { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Domain.DeregisterAsync(
    new ApplePayDomainDeregistrationRequest { Domain = "domain" }
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

**request:** `ApplePay.ApplePayDomainDeregistrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">GetAsync</a>() -> ApplePayDomainRegistrationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Domain.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">RegisterAsync</a>(ApplePay.ApplePayDomainRegistrationRequest { ... }) -> ApplePayDomainRegistrationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Domain.RegisterAsync(
    new ApplePayDomainRegistrationRequest { Domain = "domain" }
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

**request:** `ApplePay.ApplePayDomainRegistrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">RegisterAllAsync</a>(ApplePay.ApplePayDomainRegistrationListRequest { ... }) -> ApplePayDomainRegistrationResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Domain.RegisterAllAsync(new ApplePayDomainRegistrationListRequest());
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

**request:** `ApplePay.ApplePayDomainRegistrationListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Session
<details><summary><code>client.ApplePay.Session.<a href="/src/BasisTheory.Client/ApplePay/Session/SessionClient.cs">CreateAsync</a>(ApplePay.ApplePaySessionRequest { ... }) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Session.CreateAsync(new ApplePaySessionRequest());
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

**request:** `ApplePay.ApplePaySessionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Merchant Certificates
<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">GetAsync</a>(merchantId, id) -> ApplePayMerchantCertificates</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.Certificates.GetAsync("merchantId", "id");
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

**merchantId:** `string` 
    
</dd>
</dl>

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

<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">DeleteAsync</a>(merchantId, id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.Certificates.DeleteAsync("merchantId", "id");
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

**merchantId:** `string` 
    
</dd>
</dl>

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

<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">CreateAsync</a>(merchantId, ApplePay.Merchant.ApplePayMerchantCertificatesRegisterRequest { ... }) -> ApplePayMerchantCertificates</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplePay.Merchant.Certificates.CreateAsync(
    "merchantId",
    new ApplePayMerchantCertificatesRegisterRequest()
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

**merchantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ApplePay.Merchant.ApplePayMerchantCertificatesRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents Data
<details><summary><code>client.Documents.Data.<a href="/src/BasisTheory.Client/Documents/Data/DataClient.cs">GetAsync</a>(documentId) -> System.IO.Stream</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.Data.GetAsync("documentId");
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

**documentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## GooglePay Merchant
<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">GetAsync</a>(id) -> GooglePayMerchant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.GetAsync("id");
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

<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.DeleteAsync("id");
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

<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">CreateAsync</a>(GooglePay.GooglePayMerchantRegisterRequest { ... }) -> GooglePayMerchant</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.CreateAsync(new GooglePayMerchantRegisterRequest());
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

**request:** `GooglePay.GooglePayMerchantRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## GooglePay Merchant Certificates
<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">GetAsync</a>(merchantId, id) -> GooglePayMerchantCertificates</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.Certificates.GetAsync("merchantId", "id");
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

**merchantId:** `string` 
    
</dd>
</dl>

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

<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">DeleteAsync</a>(merchantId, id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.Certificates.DeleteAsync("merchantId", "id");
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

**merchantId:** `string` 
    
</dd>
</dl>

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

<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">CreateAsync</a>(merchantId, GooglePay.Merchant.GooglePayMerchantCertificatesRegisterRequest { ... }) -> GooglePayMerchantCertificates</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GooglePay.Merchant.Certificates.CreateAsync(
    "merchantId",
    new GooglePayMerchantCertificatesRegisterRequest()
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

**merchantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `GooglePay.Merchant.GooglePayMerchantCertificatesRegisterRequest` 
    
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

## Tenants SecurityContact
<details><summary><code>client.Tenants.SecurityContact.<a href="/src/BasisTheory.Client/Tenants/SecurityContact/SecurityContactClient.cs">GetAsync</a>() -> SecurityContactEmailResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.SecurityContact.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.SecurityContact.<a href="/src/BasisTheory.Client/Tenants/SecurityContact/SecurityContactClient.cs">UpdateAsync</a>(Tenants.SecurityContactEmailRequest { ... }) -> SecurityContactEmailResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.SecurityContact.UpdateAsync(
    new SecurityContactEmailRequest { Email = "email" }
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

**request:** `Tenants.SecurityContactEmailRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Connections
<details><summary><code>client.Tenants.Connections.<a href="/src/BasisTheory.Client/Tenants/Connections/ConnectionsClient.cs">CreateAsync</a>(Tenants.CreateTenantConnectionRequest { ... }) -> CreateTenantConnectionResponse</code></summary>
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

**request:** `Tenants.CreateTenantConnectionRequest` 
    
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
<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">ListAsync</a>(Tenants.InvitationsListRequest { ... }) -> Core.Pager&lt;TenantInvitationResponse&gt;</code></summary>
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

**request:** `Tenants.InvitationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">CreateAsync</a>(Tenants.CreateTenantInvitationRequest { ... }) -> TenantInvitationResponse</code></summary>
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

**request:** `Tenants.CreateTenantInvitationRequest` 
    
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
<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">ListAsync</a>(Tenants.MembersListRequest { ... }) -> TenantMemberResponsePaginatedList</code></summary>
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

**request:** `Tenants.MembersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">UpdateAsync</a>(memberId, Tenants.UpdateTenantMemberRequest { ... }) -> TenantMemberResponse</code></summary>
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

**request:** `Tenants.UpdateTenantMemberRequest` 
    
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

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">UpdateAsync</a>(Tenants.UpdateTenantRequest { ... }) -> Tenant</code></summary>
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

**request:** `Tenants.UpdateTenantRequest` 
    
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
<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">CreateAsync</a>(Threeds.CreateThreeDsSessionRequest { ... }) -> CreateThreeDsSessionResponse</code></summary>
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

**request:** `Threeds.CreateThreeDsSessionRequest` 
    
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
<details><summary><code>client.Webhooks.Events.<a href="/src/BasisTheory.Client/Webhooks/Events/EventsClient.cs">ListAsync</a>() -> IEnumerable&lt;string&gt;</code></summary>
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
