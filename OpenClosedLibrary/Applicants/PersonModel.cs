using OpenClosedLibrary.Accounts;

namespace OpenClosedLibrary.Applicants
{
    public class PersonModel : IApplicantModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new BaseAccounts();
    }
}
