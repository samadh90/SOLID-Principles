namespace SingleResponsibilityUI
{
    internal class Program
    {
        /// <summary>
        /// The main program has only one job, is just the control of flow.
        /// We've broken out all the different parts into different classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonDataCapture.Capture();

            bool isValid = PersonValidator.Validate(user);

            if (!isValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}