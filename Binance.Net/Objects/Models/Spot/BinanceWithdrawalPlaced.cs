﻿namespace Binance.Net.Objects.Models.Spot
{
    /// <summary>
    /// Result of placing a withdrawal
    /// </summary>
    [SerializationModel]
    public record BinanceWithdrawalPlaced
    {
        /// <summary>
        /// The id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
