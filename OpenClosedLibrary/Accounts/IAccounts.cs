using OpenClosedLibrary.Applicants;

namespace OpenClosedLibrary.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}