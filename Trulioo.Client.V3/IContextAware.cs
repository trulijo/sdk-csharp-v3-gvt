namespace Trulioo.Client.V3
{
    public interface IContextAware
    {
        /// <summary>
        /// Gets the <see cref="Context"/> instance for this <see cref="ITruliooApiClient"/>.
        /// </summary>
        Context Context { get; }
    }
}
