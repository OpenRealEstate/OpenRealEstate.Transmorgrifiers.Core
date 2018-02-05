﻿using OpenRealEstate.Core;

namespace OpenRealEstate.Transmorgrifiers.Core
{
    public class ListingResult
    {
        public Listing Listing { get; set; }
        public string SourceData { get; set; }

        public override string ToString()
        {
            return $"Type: {Listing?.GetType().ToString() ?? "-null -"}";
        }
    }
}