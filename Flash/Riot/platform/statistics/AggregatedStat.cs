﻿using RtmpSharp.IO;
using System;

namespace Flash.Riot.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.AggregatedStat")]
    public class AggregatedStat
    {
        [SerializedName("statType")]
        public String StatType { get; set; }

        [SerializedName("count")]
        public Double Count { get; set; }

        [SerializedName("value")]
        public Double Value { get; set; }

        [SerializedName("championId")]
        public Double ChampionId { get; set; }
    }
}
