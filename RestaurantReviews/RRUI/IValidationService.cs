namespace RRUI
{
    /// <summary>
    /// // Standardized validation service for user input
    /// </summary>
    public interface IValidationService
    {
         //Takes in a prompt and keeps askling that prompt until the end user returns a valid string
        string ValidateString(string prompt);
    }
}