using System;

#nullable enable

namespace BasisTheory.Client;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class BasisTheoryException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
