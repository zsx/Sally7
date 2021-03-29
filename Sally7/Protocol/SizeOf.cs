namespace Sally7.Protocol
{
    /// <summary>
    /// Provides size declarations for parts of the protocol messages.
    /// </summary>
    public static class SizeOf
    {
        /// <inheritdoc cref="S7.DataItem.Size"/>
        public const int DataItem = S7.DataItem.Size;

        /// <inheritdoc cref="S7.Messages.ReadRequest.Size"/>
        public const int ReadRequest = S7.Messages.ReadRequest.Size;

        /// <inheritdoc cref="IsoOverTcp.Tpkt.Size"/>
        public const int Tpkt = IsoOverTcp.Tpkt.Size;
    }
}
