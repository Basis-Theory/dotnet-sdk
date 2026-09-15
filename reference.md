# Reference
## Applications
<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">ListAsync</a>(ApplicationsListRequest { ... }) -> Pager&lt;Application&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Applications.ListAsync(
    new ApplicationsListRequest
    {
        Id = new List<string>() { "id" },
        Type = new List<string>() { "type" },
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `ApplicationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">CreateAsync</a>(CreateApplicationRequest { ... }) -> WithRawResponseTask&lt;Application&gt;</code></summary>
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

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Application&gt;</code></summary>
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

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">UpdateAsync</a>(id, UpdateApplicationRequest { ... }) -> WithRawResponseTask&lt;Application&gt;</code></summary>
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

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Applications.<a href="/src/BasisTheory.Client/Applications/ApplicationsClient.cs">GetByKeyAsync</a>() -> WithRawResponseTask&lt;Application&gt;</code></summary>
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
<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">ListAsync</a>(id, ApplicationKeysListRequest { ... }) -> WithRawResponseTask&lt;IEnumerable&lt;ApplicationKey&gt;&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ApplicationKeys.ListAsync(
    "id",
    new ApplicationKeysListRequest
    {
        KeyId = new List<string>() { "id" },
        Type = new List<string>() { "type" },
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

**request:** `ApplicationKeysListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">CreateAsync</a>(id) -> WithRawResponseTask&lt;ApplicationKey&gt;</code></summary>
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

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">GetAsync</a>(id, keyId) -> WithRawResponseTask&lt;ApplicationKey&gt;</code></summary>
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

<details><summary><code>client.ApplicationKeys.<a href="/src/BasisTheory.Client/ApplicationKeys/ApplicationKeysClient.cs">DeleteAsync</a>(id, keyId) -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.ApplicationTemplates.<a href="/src/BasisTheory.Client/ApplicationTemplates/ApplicationTemplatesClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;ApplicationTemplate&gt;&gt;</code></summary>
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

<details><summary><code>client.ApplicationTemplates.<a href="/src/BasisTheory.Client/ApplicationTemplates/ApplicationTemplatesClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;ApplicationTemplate&gt;</code></summary>
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
<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">CreateAsync</a>(ApplePayCreateRequest { ... }) -> WithRawResponseTask&lt;ApplePayCreateResponse&gt;</code></summary>
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

<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;ApplePayToken&gt;</code></summary>
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

<details><summary><code>client.ApplePay.<a href="/src/BasisTheory.Client/ApplePay/ApplePayClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
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
<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">CreateAsync</a>(GooglePayCreateRequest { ... }) -> WithRawResponseTask&lt;GooglePayCreateResponse&gt;</code></summary>
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

<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;GooglePayToken&gt;</code></summary>
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

<details><summary><code>client.GooglePay.<a href="/src/BasisTheory.Client/GooglePay/GooglePayClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
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
<details><summary><code>client.Documents.<a href="/src/BasisTheory.Client/Documents/DocumentsClient.cs">UploadAsync</a>(DocumentsUploadRequest { ... }) -> WithRawResponseTask&lt;Document&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.UploadAsync(new DocumentsUploadRequest());
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

**request:** `DocumentsUploadRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/BasisTheory.Client/Documents/DocumentsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Document&gt;</code></summary>
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

<details><summary><code>client.Documents.<a href="/src/BasisTheory.Client/Documents/DocumentsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">DetokenizeAsync</a>(object { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">TokenizeAsync</a>(object { ... }) -> WithRawResponseTask&lt;object&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Token&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">UpdateAsync</a>(id, UpdateTokenRequest { ... }) -> WithRawResponseTask&lt;Token&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">CreateAsync</a>(CreateTokenRequest { ... }) -> WithRawResponseTask&lt;Token&gt;</code></summary>
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

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">ListV2Async</a>(TokensListV2Request { ... }) -> Pager&lt;Token&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.ListV2Async(
    new TokensListV2Request
    {
        Type = "type",
        Container = "container",
        Fingerprint = "fingerprint",
        Start = "start",
        Size = 1,
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

**request:** `TokensListV2Request` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/BasisTheory.Client/Tokens/TokensClient.cs">SearchV2Async</a>(SearchTokensRequestV2 { ... }) -> Pager&lt;Token&gt;</code></summary>
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
<details><summary><code>client.Enrichments.<a href="/src/BasisTheory.Client/Enrichments/EnrichmentsClient.cs">BankAccountVerifyAsync</a>(BankVerificationRequest { ... }) -> WithRawResponseTask&lt;BankVerificationResponse&gt;</code></summary>
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

<details><summary><code>client.Enrichments.<a href="/src/BasisTheory.Client/Enrichments/EnrichmentsClient.cs">CardDetailsAsync</a>(EnrichmentsCardDetailsRequest { ... }) -> WithRawResponseTask&lt;CardDetailsResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Enrichments.CardDetailsAsync(new EnrichmentsCardDetailsRequest { Bin = "bin" });
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

**request:** `EnrichmentsCardDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Keys
<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;ClientEncryptionKeyMetadataResponse&gt;&gt;</code></summary>
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

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">CreateAsync</a>(ClientEncryptionKeyRequest { ... }) -> WithRawResponseTask&lt;ClientEncryptionKeyResponse&gt;</code></summary>
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

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;ClientEncryptionKeyMetadataResponse&gt;</code></summary>
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

<details><summary><code>client.Keys.<a href="/src/BasisTheory.Client/Keys/KeysClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">ListAsync</a>(LogsListRequest { ... }) -> Pager&lt;Log&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Logs.ListAsync(
    new LogsListRequest
    {
        EntityType = "entity_type",
        EntityId = "entity_id",
        StartDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        EndDate = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `LogsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Logs.<a href="/src/BasisTheory.Client/Logs/LogsClient.cs">GetEntityTypesAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;LogEntityType&gt;&gt;</code></summary>
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
<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">CreateAsync</a>(CreateNetworkTokenRequest { ... }) -> WithRawResponseTask&lt;NetworkToken&gt;</code></summary>
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">CryptogramAsync</a>(id) -> WithRawResponseTask&lt;NetworkTokenCryptogram&gt;</code></summary>
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;NetworkToken&gt;</code></summary>
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">SuspendAsync</a>(id) -> WithRawResponseTask&lt;NetworkToken&gt;</code></summary>
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

<details><summary><code>client.NetworkTokens.<a href="/src/BasisTheory.Client/NetworkTokens/NetworkTokensClient.cs">ResumeAsync</a>(id) -> WithRawResponseTask&lt;NetworkToken&gt;</code></summary>
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
<details><summary><code>client.Permissions.<a href="/src/BasisTheory.Client/Permissions/PermissionsClient.cs">ListAsync</a>(PermissionsListRequest { ... }) -> WithRawResponseTask&lt;IEnumerable&lt;Permission&gt;&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Permissions.ListAsync(
    new PermissionsListRequest { ApplicationType = "application_type" }
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

**request:** `PermissionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Proxies
<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">ListAsync</a>(ProxiesListRequest { ... }) -> Pager&lt;Proxy&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.ListAsync(
    new ProxiesListRequest
    {
        Id = new List<string>() { "id" },
        Name = "name",
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `ProxiesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">CreateAsync</a>(CreateProxyRequest { ... }) -> WithRawResponseTask&lt;Proxy&gt;</code></summary>
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

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Proxy&gt;</code></summary>
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

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">UpdateAsync</a>(id, UpdateProxyRequest { ... }) -> WithRawResponseTask&lt;Proxy&gt;</code></summary>
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

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">PatchAsync</a>(id, PatchProxyRequest { ... }) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Proxies.<a href="/src/BasisTheory.Client/Proxies/ProxiesClient.cs">TransferHostnameAsync</a>(id, TransferProxyHostnameRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Proxies.TransferHostnameAsync(
    "id",
    new TransferProxyHostnameRequest { ProxyHost = "proxy_host" }
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

**request:** `TransferProxyHostnameRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reactors
<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ListAsync</a>(ReactorsListRequest { ... }) -> Pager&lt;Reactor&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reactors.ListAsync(
    new ReactorsListRequest
    {
        Id = new List<string>() { "id" },
        Name = "name",
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `ReactorsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">CreateAsync</a>(CreateReactorRequest { ... }) -> WithRawResponseTask&lt;Reactor&gt;</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Reactor&gt;</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">UpdateAsync</a>(id, UpdateReactorRequest { ... }) -> WithRawResponseTask&lt;Reactor&gt;</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">PatchAsync</a>(id, PatchReactorRequest { ... }) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsync</a>(id, object { ... }) -> WithRawResponseTask&lt;ReactResponse&gt;</code></summary>
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

<details><summary><code>client.Reactors.<a href="/src/BasisTheory.Client/Reactors/ReactorsClient.cs">ReactAsyncAsync</a>(id, object { ... }) -> WithRawResponseTask&lt;AsyncReactResponse&gt;</code></summary>
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
<details><summary><code>client.Roles.<a href="/src/BasisTheory.Client/Roles/RolesClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;Role&gt;&gt;</code></summary>
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
<details><summary><code>client.Sessions.<a href="/src/BasisTheory.Client/Sessions/SessionsClient.cs">CreateAsync</a>() -> WithRawResponseTask&lt;CreateSessionResponse&gt;</code></summary>
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

<details><summary><code>client.Sessions.<a href="/src/BasisTheory.Client/Sessions/SessionsClient.cs">AuthorizeAsync</a>(AuthorizeSessionRequest { ... }) -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;TokenIntent&gt;</code></summary>
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

<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.TokenIntents.<a href="/src/BasisTheory.Client/TokenIntents/TokenIntentsClient.cs">CreateAsync</a>(CreateTokenIntentRequest { ... }) -> WithRawResponseTask&lt;CreateTokenIntentResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TokenIntents.CreateAsync(new CreateTokenIntentRequest { Type = "type" });
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
<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">PingAsync</a>() -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;Webhook&gt;</code></summary>
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

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">UpdateAsync</a>(id, UpdateWebhookRequest { ... }) -> WithRawResponseTask&lt;Webhook&gt;</code></summary>
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

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;WebhookList&gt;</code></summary>
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

<details><summary><code>client.Webhooks.<a href="/src/BasisTheory.Client/Webhooks/WebhooksClient.cs">CreateAsync</a>(CreateWebhookRequest { ... }) -> WithRawResponseTask&lt;Webhook&gt;</code></summary>
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
<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;AccountUpdaterJob&gt;</code></summary>
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

<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">ListAsync</a>(JobsListRequest { ... }) -> WithRawResponseTask&lt;AccountUpdaterJobList&gt;</code></summary>
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
await client.AccountUpdater.Jobs.ListAsync(new JobsListRequest { Size = 1, Start = "start" });
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

**request:** `JobsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.AccountUpdater.Jobs.<a href="/src/BasisTheory.Client/AccountUpdater/Jobs/JobsClient.cs">CreateAsync</a>(CreateAccountUpdaterJobRequest { ... }) -> WithRawResponseTask&lt;AccountUpdaterJob&gt;</code></summary>
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
await client.AccountUpdater.Jobs.CreateAsync(new CreateAccountUpdaterJobRequest());
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

**request:** `CreateAccountUpdaterJobRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## AccountUpdater RealTime
<details><summary><code>client.AccountUpdater.RealTime.<a href="/src/BasisTheory.Client/AccountUpdater/RealTime/RealTimeClient.cs">InvokeAsync</a>(AccountUpdaterRealTimeRequest { ... }) -> WithRawResponseTask&lt;AccountUpdaterRealTimeResponse&gt;</code></summary>
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

**request:** `AccountUpdaterRealTimeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Enrollments
<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">ListAsync</a>(EnrollmentsListRequest { ... }) -> Pager&lt;Enrollment&gt;</code></summary>
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
await client.Agentic.Enrollments.ListAsync(
    new EnrollmentsListRequest { Limit = 1, Cursor = "cursor" }
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

**request:** `EnrollmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">CreateAsync</a>(CreateEnrollmentRequest { ... }) -> WithRawResponseTask&lt;Enrollment&gt;</code></summary>
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

**request:** `CreateEnrollmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">GetAsync</a>(enrollmentId) -> WithRawResponseTask&lt;Enrollment&gt;</code></summary>
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

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">DeleteAsync</a>(enrollmentId) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Agentic.Enrollments.<a href="/src/BasisTheory.Client/Agentic/Enrollments/EnrollmentsClient.cs">RetryAsync</a>(enrollmentId) -> WithRawResponseTask&lt;Enrollment&gt;</code></summary>
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

## Agentic Agents
<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">CreateAsync</a>(CreateAgentRequest { ... }) -> WithRawResponseTask&lt;Agent&gt;</code></summary>
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

**request:** `CreateAgentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">GetAsync</a>(agentId) -> WithRawResponseTask&lt;Agent&gt;</code></summary>
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

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">DeleteAsync</a>(agentId) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Agentic.Agents.<a href="/src/BasisTheory.Client/Agentic/Agents/AgentsClient.cs">UpdateAsync</a>(agentId, UpdateAgentRequest { ... }) -> WithRawResponseTask&lt;Agent&gt;</code></summary>
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

**request:** `UpdateAgentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic PaymentMethods
<details><summary><code>client.Agentic.PaymentMethods.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/PaymentMethodsClient.cs">ListAsync</a>(PaymentMethodsListRequest { ... }) -> Pager&lt;PaymentMethod&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists shared payment methods for the current tenant. Defaults to active resources; use `status=all` for a complete Portal history. Server-side page filling prevents sparse pages when filtering by status.
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
await client.Agentic.PaymentMethods.ListAsync(
    new PaymentMethodsListRequest
    {
        Size = 1,
        Start = "start",
        ConsumerId = "consumer_id",
        Status = PaymentMethodsListRequestStatus.Active,
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

**request:** `PaymentMethodsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.PaymentMethods.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/PaymentMethodsClient.cs">CreateAsync</a>(CreatePaymentMethodRequest { ... }) -> WithRawResponseTask&lt;PaymentMethod&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a shared payment method from a funding source — a Basis Theory card token, or an instrument reached through a source connection — and provision the rails that source is eligible for. Public and private applications may call this operation with `agentic:payment-method:create`. Supply BT-IDEMPOTENCY-KEY to make matching retries return the same resource. Without it, every request is a new create operation.
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
await client.Agentic.PaymentMethods.CreateAsync(
    new CreatePaymentMethodRequest
    {
        Source = new PaymentMethodSourceBasisTheoryCardToken { TokenId = "token_id" },
        Consumer = new SharedPaymentConsumer { Email = "email" },
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

**request:** `CreatePaymentMethodRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.PaymentMethods.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/PaymentMethodsClient.cs">GetAsync</a>(paymentMethodId) -> WithRawResponseTask&lt;PaymentMethod&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.PaymentMethods.GetAsync("payment_method_id");
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

**paymentMethodId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.PaymentMethods.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/PaymentMethodsClient.cs">DeleteAsync</a>(paymentMethodId) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a payment method and revoke everything downstream - every allowance backed by it is cancelled (including network-side purchase instructions) and no further verification or credential minting is possible.
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
await client.Agentic.PaymentMethods.DeleteAsync("payment_method_id");
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

**paymentMethodId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.PaymentMethods.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/PaymentMethodsClient.cs">ErrorsAsync</a>(paymentMethodId, PaymentMethodsErrorsRequest { ... }) -> Pager&lt;SharedPaymentProviderError&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists sanitized provider failures for a payment method and its downstream operations. Raw provider bodies and card data are never returned.
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
await client.Agentic.PaymentMethods.ErrorsAsync(
    "payment_method_id",
    new PaymentMethodsErrorsRequest { Size = 1, Start = "start" }
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

**paymentMethodId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PaymentMethodsErrorsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic PaymentCredentials
<details><summary><code>client.Agentic.PaymentCredentials.<a href="/src/BasisTheory.Client/Agentic/PaymentCredentials/PaymentCredentialsClient.cs">ListAsync</a>(PaymentCredentialsListRequest { ... }) -> Pager&lt;PaymentCredentialMetadata&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists credential metadata across the tenant for Portal history. Spendable card, SPT, and MPP payloads are never returned.
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
await client.Agentic.PaymentCredentials.ListAsync(
    new PaymentCredentialsListRequest { Size = 1, Start = "start" }
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

**request:** `PaymentCredentialsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Allowances
<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">ListAsync</a>(AllowancesListRequest { ... }) -> Pager&lt;Allowance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists allowances for the current tenant. Defaults to active, unexpired resources; use `status=all` for a complete Portal history. Results can be scoped to one payment method, and server-side page filling prevents sparse pages when filtering by status.
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
await client.Agentic.Allowances.ListAsync(
    new AllowancesListRequest
    {
        Size = 1,
        Start = "start",
        PaymentMethodId = "payment_method_id",
        Status = AllowancesListRequestStatus.Active,
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

**request:** `AllowancesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">CreateAsync</a>(CreateAllowanceRequest { ... }) -> WithRawResponseTask&lt;Allowance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a spending allowance from a payment method. Supply `merchant` to scope the mandate to one merchant, or omit it to leave the allowance open and name a merchant on each credential request instead. The payment method must have at least one enabled rail; otherwise the request returns `NO_ACTIVE_RAILS`.
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
await client.Agentic.Allowances.CreateAsync(
    new CreateAllowanceRequest
    {
        PaymentMethodId = "payment_method_id",
        Amount = new SharedPaymentAmount { Value = "100.00", Currency = "USD" },
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

**request:** `CreateAllowanceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">GetAsync</a>(allowanceId) -> WithRawResponseTask&lt;Allowance&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agentic.Allowances.GetAsync("allowance_id");
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

**allowanceId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">DeleteAsync</a>(allowanceId) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Cancel an allowance so new credentials cannot be created from it. Network-side purchase instructions held by its rails are cancelled with the provider.
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
await client.Agentic.Allowances.DeleteAsync("allowance_id");
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

**allowanceId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">UpdateAsync</a>(allowanceId, AllowancesUpdateRequest { ... }) -> WithRawResponseTask&lt;Allowance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates one or more mutable fields by changing the provider-side mandate first, then committing the same amount, prompt, and expiry locally. Mints are blocked while the update is in flight, and an empty request body is rejected.
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
await client.Agentic.Allowances.UpdateAsync("allowance_id", new AllowancesUpdateRequest());
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AllowancesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">ErrorsAsync</a>(allowanceId, AllowancesErrorsRequest { ... }) -> Pager&lt;SharedPaymentProviderError&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists sanitized provider failures for an allowance, including failed verification and credential attempts. Raw provider bodies and card data are never returned.
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
await client.Agentic.Allowances.ErrorsAsync(
    "allowance_id",
    new AllowancesErrorsRequest { Size = 1, Start = "start" }
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AllowancesErrorsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.<a href="/src/BasisTheory.Client/Agentic/Allowances/AllowancesClient.cs">VerifyAsync</a>(allowanceId, object { ... }) -> WithRawResponseTask&lt;AllowanceVerificationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Start or continue self-served verification for a rail that requires it. Public and private applications may call this operation with `agentic:allowance:verify`; browser clients should use a public application key. Visa verification is advanced through explicit ceremony actions. Mastercard managed authentication is finalized with `complete` after the hosted ceremony; callback delivery is only a browser signal and is not required.
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
await client.Agentic.Allowances.VerifyAsync(
    "allowance_id",
    new VerifyAllowanceRequestStart
    {
        Rail = VerifyAllowanceRequestStartRail.AgenticToken,
        Provider = VerifyAllowanceRequestStartProvider.Vic,
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

**allowanceId:** `string` 
    
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

## Agentic Agents Instructions
<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">ListAsync</a>(agentId, InstructionsListRequest { ... }) -> Pager&lt;Instruction&gt;</code></summary>
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
await client.Agentic.Agents.Instructions.ListAsync(
    "agent_id",
    new InstructionsListRequest
    {
        EnrollmentId = "enrollment_id",
        Limit = 1,
        Cursor = "cursor",
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

**request:** `InstructionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">CreateAsync</a>(agentId, CreateInstructionRequest { ... }) -> WithRawResponseTask&lt;Instruction&gt;</code></summary>
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

**request:** `CreateInstructionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">GetAsync</a>(agentId, instructionId) -> WithRawResponseTask&lt;Instruction&gt;</code></summary>
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

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">DeleteAsync</a>(agentId, instructionId) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">UpdateAsync</a>(agentId, instructionId, UpdateInstructionRequest { ... }) -> WithRawResponseTask&lt;Instruction&gt;</code></summary>
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

**request:** `UpdateInstructionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Agents.Instructions.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/InstructionsClient.cs">ConfirmationsAsync</a>(agentId, instructionId, PublishConfirmationRequest { ... }) -> WithRawResponseTask&lt;PublishConfirmationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Report the outcome of a transaction back to the card network.
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
await client.Agentic.Agents.Instructions.ConfirmationsAsync(
    "agent_id",
    "instruction_id",
    new PublishConfirmationRequest
    {
        ConfirmationData = new List<ConfirmationEntry>()
        {
            new ConfirmationEntry
            {
                TransactionStatus = TransactionStatus.Approved,
                TransactionType = TransactionType.Purchase,
            },
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

**request:** `PublishConfirmationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents Instructions Credentials
<details><summary><code>client.Agentic.Agents.Instructions.Credentials.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Credentials/CredentialsClient.cs">CreateAsync</a>(agentId, instructionId, GetCredentialsRequest { ... }) -> WithRawResponseTask&lt;Credentials&gt;</code></summary>
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
    new GetCredentialsRequest()
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

**request:** `GetCredentialsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Agents Instructions Verify
<details><summary><code>client.Agentic.Agents.Instructions.Verify.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Verify/VerifyClient.cs">StartAsync</a>(agentId, instructionId, StartVerificationRequest { ... }) -> WithRawResponseTask&lt;VerificationResponse&gt;</code></summary>
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

<details><summary><code>client.Agentic.Agents.Instructions.Verify.<a href="/src/BasisTheory.Client/Agentic/Agents/Instructions/Verify/VerifyClient.cs">PasskeyAsync</a>(agentId, instructionId, SubmitPasskeyRequest { ... }) -> WithRawResponseTask&lt;Instruction&gt;</code></summary>
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
        AssuranceData = new Dictionary<string, object?>() { { "key", "value" } },
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

**request:** `SubmitPasskeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Allowances Rails
<details><summary><code>client.Agentic.Allowances.Rails.<a href="/src/BasisTheory.Client/Agentic/Allowances/Rails/RailsClient.cs">RetryAsync</a>(allowanceId, RailsRetryRequest { ... }) -> WithRawResponseTask&lt;Allowance&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Re-run provider setup for one failed allowance rail. Allowance creation keeps rails that failed at the provider, so a transient outage does not require rebuilding the mandate. Only rails with status `error` can be retried, and the payment method's matching rail must still be `enabled`.
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
await client.Agentic.Allowances.Rails.RetryAsync(
    "allowance_id",
    new global::BasisTheory.Client.Agentic.Allowances.RailsRetryRequest
    {
        Rail = global::BasisTheory.Client.Agentic.Allowances.RailsRetryRequestRail.AgenticToken,
        Provider = global::BasisTheory.Client.Agentic.Allowances.RailsRetryRequestProvider.Vic,
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `RailsRetryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Allowances Credentials
<details><summary><code>client.Agentic.Allowances.Credentials.<a href="/src/BasisTheory.Client/Agentic/Allowances/Credentials/CredentialsClient.cs">ListAsync</a>(allowanceId, CredentialsListRequest { ... }) -> Pager&lt;PaymentCredentialMetadata&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List credential metadata for an allowance. Responses contain metadata only — never card numbers, SPT values, or MPP payloads.
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
await client.Agentic.Allowances.Credentials.ListAsync(
    "allowance_id",
    new CredentialsListRequest { Size = 1, Start = "start" }
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CredentialsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.Credentials.<a href="/src/BasisTheory.Client/Agentic/Allowances/Credentials/CredentialsClient.cs">CreateAsync</a>(allowanceId, CreatePaymentCredentialRequest { ... }) -> WithRawResponseTask&lt;PaymentCredential&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a spend credential from an allowance. Supply BT-IDEMPOTENCY-KEY for retry protection. Without it, every request is a new mint and may spend the allowance again.
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
await client.Agentic.Allowances.Credentials.CreateAsync(
    "allowance_id",
    new CreatePaymentCredentialRequest
    {
        Rail = CreatePaymentCredentialRequestRail.AgenticToken,
        Provider = CreatePaymentCredentialRequestProvider.Vic,
        Credential = new CreatePaymentCredentialRequestCredentialCard(),
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CreatePaymentCredentialRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Allowances.Credentials.<a href="/src/BasisTheory.Client/Agentic/Allowances/Credentials/CredentialsClient.cs">GetAsync</a>(allowanceId, credentialId) -> WithRawResponseTask&lt;PaymentCredentialMetadata&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get credential metadata. The credential payload itself (card number, SPT, MPP token) is only ever returned by the create call.
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
await client.Agentic.Allowances.Credentials.GetAsync("allowance_id", "credential_id");
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

**allowanceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**credentialId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic Enrollments Verify
<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">StartAsync</a>(enrollmentId, StartVerificationRequest { ... }) -> WithRawResponseTask&lt;VerificationResponse&gt;</code></summary>
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

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">MethodAsync</a>(enrollmentId, SelectMethodRequest { ... }) -> WithRawResponseTask&lt;VerificationResponse&gt;</code></summary>
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

**request:** `SelectMethodRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">OtpAsync</a>(enrollmentId, SubmitOtpRequest { ... }) -> WithRawResponseTask&lt;VerificationResponse&gt;</code></summary>
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

**request:** `SubmitOtpRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agentic.Enrollments.Verify.<a href="/src/BasisTheory.Client/Agentic/Enrollments/Verify/VerifyClient.cs">CompleteAsync</a>(enrollmentId, CompleteVerificationRequest { ... }) -> WithRawResponseTask&lt;VerificationResponse&gt;</code></summary>
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

**request:** `CompleteVerificationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agentic PaymentMethods Rails
<details><summary><code>client.Agentic.PaymentMethods.Rails.<a href="/src/BasisTheory.Client/Agentic/PaymentMethods/Rails/RailsClient.cs">RetryAsync</a>(paymentMethodId, RailsRetryRequest { ... }) -> WithRawResponseTask&lt;PaymentMethod&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retry one payment method rail after pending or failed provisioning. Public and private applications may call this operation with `agentic:payment-method:create`.
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
await client.Agentic.PaymentMethods.Rails.RetryAsync(
    "payment_method_id",
    new global::BasisTheory.Client.Agentic.PaymentMethods.RailsRetryRequest
    {
        Rail = global::BasisTheory.Client.Agentic.PaymentMethods.RailsRetryRequestRail.AgenticToken,
        Provider = global::BasisTheory.Client.Agentic.PaymentMethods.RailsRetryRequestProvider.Vic,
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

**paymentMethodId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `RailsRetryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Merchant
<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;ApplePayMerchant&gt;</code></summary>
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

<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.ApplePay.Merchant.<a href="/src/BasisTheory.Client/ApplePay/Merchant/MerchantClient.cs">CreateAsync</a>(ApplePayMerchantRegisterRequest { ... }) -> WithRawResponseTask&lt;ApplePayMerchant&gt;</code></summary>
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

**request:** `ApplePayMerchantRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Domain
<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">DeregisterAsync</a>(ApplePayDomainDeregistrationRequest { ... }) -> WithRawResponseTask</code></summary>
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

**request:** `ApplePayDomainDeregistrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">GetAsync</a>() -> WithRawResponseTask&lt;ApplePayDomainRegistrationResponse&gt;</code></summary>
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

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">RegisterAsync</a>(ApplePayDomainRegistrationRequest { ... }) -> WithRawResponseTask&lt;ApplePayDomainRegistrationResponse&gt;</code></summary>
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

**request:** `ApplePayDomainRegistrationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ApplePay.Domain.<a href="/src/BasisTheory.Client/ApplePay/Domain/DomainClient.cs">RegisterAllAsync</a>(ApplePayDomainRegistrationListRequest { ... }) -> WithRawResponseTask&lt;ApplePayDomainRegistrationResponse&gt;</code></summary>
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

**request:** `ApplePayDomainRegistrationListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Session
<details><summary><code>client.ApplePay.Session.<a href="/src/BasisTheory.Client/ApplePay/Session/SessionClient.cs">CreateAsync</a>(ApplePaySessionRequest { ... }) -> WithRawResponseTask&lt;string&gt;</code></summary>
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

**request:** `ApplePaySessionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ApplePay Merchant Certificates
<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">GetAsync</a>(merchantId, id) -> WithRawResponseTask&lt;ApplePayMerchantCertificates&gt;</code></summary>
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

<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">DeleteAsync</a>(merchantId, id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.ApplePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/ApplePay/Merchant/Certificates/CertificatesClient.cs">CreateAsync</a>(merchantId, ApplePayMerchantCertificatesRegisterRequest { ... }) -> WithRawResponseTask&lt;ApplePayMerchantCertificates&gt;</code></summary>
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
    new ApplePayMerchantCertificatesRegisterRequest
    {
        PaymentProcessorCertificateData = "payment_processor_certificate_data",
        PaymentProcessorCertificatePassword = "payment_processor_certificate_password",
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

**merchantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ApplePayMerchantCertificatesRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents Data
<details><summary><code>client.Documents.Data.<a href="/src/BasisTheory.Client/Documents/Data/DataClient.cs">GetAsync</a>(documentId) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
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
<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;GooglePayMerchant&gt;</code></summary>
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

<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.GooglePay.Merchant.<a href="/src/BasisTheory.Client/GooglePay/Merchant/MerchantClient.cs">CreateAsync</a>(GooglePayMerchantRegisterRequest { ... }) -> WithRawResponseTask&lt;GooglePayMerchant&gt;</code></summary>
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

**request:** `GooglePayMerchantRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## GooglePay Merchant Certificates
<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">GetAsync</a>(merchantId, id) -> WithRawResponseTask&lt;GooglePayMerchantCertificates&gt;</code></summary>
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

<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">DeleteAsync</a>(merchantId, id) -> WithRawResponseTask</code></summary>
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

<details><summary><code>client.GooglePay.Merchant.Certificates.<a href="/src/BasisTheory.Client/GooglePay/Merchant/Certificates/CertificatesClient.cs">CreateAsync</a>(merchantId, GooglePayMerchantCertificatesRegisterRequest { ... }) -> WithRawResponseTask&lt;GooglePayMerchantCertificates&gt;</code></summary>
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

**request:** `GooglePayMerchantCertificatesRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NetworkTokens Account
<details><summary><code>client.NetworkTokens.Account.<a href="/src/BasisTheory.Client/NetworkTokens/Account/AccountClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;NetworkTokenAccount&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NetworkTokens.Account.GetAsync("id");
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

## Reactors Results
<details><summary><code>client.Reactors.Results.<a href="/src/BasisTheory.Client/Reactors/Results/ResultsClient.cs">GetAsync</a>(id, requestId) -> WithRawResponseTask&lt;object&gt;</code></summary>
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
<details><summary><code>client.Tenants.SecurityContact.<a href="/src/BasisTheory.Client/Tenants/SecurityContact/SecurityContactClient.cs">GetAsync</a>() -> WithRawResponseTask&lt;SecurityContactEmailResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.SecurityContact.<a href="/src/BasisTheory.Client/Tenants/SecurityContact/SecurityContactClient.cs">UpdateAsync</a>(SecurityContactEmailRequest { ... }) -> WithRawResponseTask&lt;SecurityContactEmailResponse&gt;</code></summary>
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

**request:** `SecurityContactEmailRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Connections
<details><summary><code>client.Tenants.Connections.<a href="/src/BasisTheory.Client/Tenants/Connections/ConnectionsClient.cs">CreateAsync</a>(CreateTenantConnectionRequest { ... }) -> WithRawResponseTask&lt;CreateTenantConnectionResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Connections.<a href="/src/BasisTheory.Client/Tenants/Connections/ConnectionsClient.cs">DeleteAsync</a>() -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">ListAsync</a>(InvitationsListRequest { ... }) -> Pager&lt;TenantInvitationResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Invitations.ListAsync(
    new InvitationsListRequest
    {
        Status = TenantInvitationStatus.Pending,
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `InvitationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">CreateAsync</a>(CreateTenantInvitationRequest { ... }) -> WithRawResponseTask&lt;TenantInvitationResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">ResendAsync</a>(invitationId) -> WithRawResponseTask&lt;TenantInvitationResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">GetAsync</a>(invitationId) -> WithRawResponseTask&lt;TenantInvitationResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Invitations.<a href="/src/BasisTheory.Client/Tenants/Invitations/InvitationsClient.cs">DeleteAsync</a>(invitationId) -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">ListAsync</a>(MembersListRequest { ... }) -> Pager&lt;TenantMemberResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Members.ListAsync(
    new MembersListRequest
    {
        UserId = new List<string>() { "user_id" },
        Page = 1,
        Start = "start",
        Size = 1,
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

**request:** `MembersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">UpdateAsync</a>(memberId, UpdateTenantMemberRequest { ... }) -> WithRawResponseTask&lt;TenantMemberResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Members.<a href="/src/BasisTheory.Client/Tenants/Members/MembersClient.cs">DeleteAsync</a>(memberId) -> WithRawResponseTask</code></summary>
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

## Tenants Merchants
<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">ListAsync</a>(tenantId, MerchantsListRequest { ... }) -> Pager&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.ListAsync(
    "tenantId",
    new MerchantsListRequest
    {
        Page = 1,
        Start = "start",
        Size = 1,
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MerchantsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">CreateAsync</a>(tenantId, TenantMerchantRequest { ... }) -> WithRawResponseTask&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.CreateAsync("tenantId", new TenantMerchantRequest { Name = "name" });
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `TenantMerchantRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">GetAsync</a>(tenantId, merchantId) -> WithRawResponseTask&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.GetAsync("tenantId", "merchantId");
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**merchantId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">DeleteAsync</a>(tenantId, merchantId) -> WithRawResponseTask&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.DeleteAsync("tenantId", "merchantId");
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**merchantId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">UpdateAsync</a>(tenantId, merchantId, TenantMerchantRequest { ... }) -> WithRawResponseTask&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.UpdateAsync(
    "tenantId",
    "merchantId",
    new TenantMerchantRequest { Name = "name" }
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**merchantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `TenantMerchantRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.Merchants.<a href="/src/BasisTheory.Client/Tenants/Merchants/MerchantsClient.cs">RequestOnboardingAsync</a>(tenantId, merchantId, ServiceOnboardingRequest { ... }) -> WithRawResponseTask&lt;TenantMerchant&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Merchants.RequestOnboardingAsync(
    "tenantId",
    "merchantId",
    new ServiceOnboardingRequest()
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

**tenantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**merchantId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ServiceOnboardingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Owner
<details><summary><code>client.Tenants.Owner.<a href="/src/BasisTheory.Client/Tenants/Owner/OwnerClient.cs">GetAsync</a>() -> WithRawResponseTask&lt;TenantMemberResponse&gt;</code></summary>
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

<details><summary><code>client.Tenants.Owner.<a href="/src/BasisTheory.Client/Tenants/Owner/OwnerClient.cs">TransferAsync</a>(TransferTenantOwnerRequest { ... }) -> WithRawResponseTask&lt;TenantMemberResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.Owner.TransferAsync(new TransferTenantOwnerRequest { MemberId = "member_id" });
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

**request:** `TransferTenantOwnerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants Self
<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">GetUsageReportsAsync</a>() -> WithRawResponseTask&lt;TenantUsageReport&gt;</code></summary>
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

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">GetAsync</a>() -> WithRawResponseTask&lt;Tenant&gt;</code></summary>
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

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">UpdateAsync</a>(UpdateTenantRequest { ... }) -> WithRawResponseTask&lt;Tenant&gt;</code></summary>
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

<details><summary><code>client.Tenants.Self.<a href="/src/BasisTheory.Client/Tenants/Self/SelfClient.cs">DeleteAsync</a>() -> WithRawResponseTask</code></summary>
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
<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">CreateAsync</a>(CreateThreeDsSessionRequest { ... }) -> WithRawResponseTask&lt;CreateThreeDsSessionResponse&gt;</code></summary>
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

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">AuthenticateAsync</a>(sessionId, AuthenticateThreeDsSessionRequest { ... }) -> WithRawResponseTask&lt;ThreeDsAuthentication&gt;</code></summary>
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

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">GetChallengeResultAsync</a>(sessionId) -> WithRawResponseTask&lt;ThreeDsAuthentication&gt;</code></summary>
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

<details><summary><code>client.Threeds.Sessions.<a href="/src/BasisTheory.Client/Threeds/Sessions/SessionsClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;ThreeDsSession&gt;</code></summary>
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
<details><summary><code>client.Webhooks.Events.<a href="/src/BasisTheory.Client/Webhooks/Events/EventsClient.cs">ListAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;string&gt;&gt;</code></summary>
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

