using NetTemplate.DAL.Data.Entities;

namespace NetTemplate.DAL.Data.Responses.Claim
{
    public class RejectClaimResponse
    {
        public Guid Id { get; set; }
        public ClaimStatus Status { get; set; }
        public string Remark { get; set; }
        public Guid ApproverId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
