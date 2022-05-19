using OpenClosedLibrary.Accounts;

namespace OpenClosedLibrary.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new BaseAccounts();
    }
}
