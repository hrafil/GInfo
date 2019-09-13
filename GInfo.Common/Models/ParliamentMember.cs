namespace GInfo.Common.Models
{
    /// <summary>
    /// Represents the Poslanec db table.
    /// </summary>
    public class ParliamentMember
    {
        public long Id { get; set; }

        public long PersonId { get; set; }

        public long RegionId { get; set; }

        public long CandidatureId { get; set; }

        public long ElectoralPeriodId { get; set; }

        public string WebsiteUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string OfficeStreet { get; set; }

        public string OfficeMunicipality { get; set; }

        public string OfficePostalCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        //TODO: Correctly -* Telefon do poslanecké sněmovny
        public string HouseOfCommonsPhone { get; set; }
    }
}
