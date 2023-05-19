namespace Trulioo.Client.V3
{
    public interface ITruliooApiClient
    {
        #region Properties

        /// <summary>
        /// Gets the <see cref="TruliooBusiness"/> instance for this <see cref="ITruliooApiClient"/>.
        /// </summary>
        TruliooBusiness TruliooBusiness { get; }

        /// <summary>
        /// Gets the <see cref="Connection"/> instance for this <see cref="ITruliooApiClient"/>.
        /// </summary>
        Connection Connection { get; }
        /// <summary>
        /// Gets the <see cref="Verification"/> instance for this <see cref="ITruliooApiClient"/>.
        /// </summary>
        Verification Verification { get; }

        #endregion
    }
}
