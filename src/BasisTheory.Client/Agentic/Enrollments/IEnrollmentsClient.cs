using global::BasisTheory.Client;
using global::BasisTheory.Client.Core;

namespace BasisTheory.Client.Agentic;

public partial interface IEnrollmentsClient
{
    public global::BasisTheory.Client.Agentic.Enrollments.IVerifyClient Verify { get; }

    /// <summary>
    /// List all enrollments for the current tenant with cursor-based pagination.
    /// </summary>
    Task<Pager<Enrollment>> ListAsync(
        EnrollmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Enroll a card token with a card network (Visa or Mastercard).
    /// </summary>
    WithRawResponseTask<Enrollment> CreateAsync(
        CreateEnrollmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Enrollment> GetAsync(
        string enrollmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Soft-deletes the enrollment by marking its status as deleted.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        string enrollmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retry enrolling a card that previously failed. Only failed enrollments can be retried.
    /// </summary>
    WithRawResponseTask<Enrollment> RetryAsync(
        string enrollmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
