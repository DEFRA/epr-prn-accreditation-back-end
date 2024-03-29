﻿using System.ComponentModel.DataAnnotations;

namespace EPR.Accreditation.API.Common.Dtos
{
    public class AccreditationMaterial
    {
        public Guid ExternalId { get; set; }

        public int MaterialId { get; set; }

        public decimal AnnualCapacity { get; set; }

        public decimal WeeklyCapacity { get; set; }

        [MaxLength(200)]
        public string WasteSource { get; set; }

        public MaterialReprocessorDetails MaterialReprocessorDetails { get; set; }

        public IEnumerable<WasteCode> WasteCodes { get; set; }

        public Material Material { get; set; }
    }
}
