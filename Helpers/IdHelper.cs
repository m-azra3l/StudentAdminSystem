using System.Security.Cryptography;
using System.Text;

namespace StudentAdministrator.Helpers
{
    public class IdHelper
    {
        // Generates a unique key of specified length
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = "123456789".ToCharArray();
            byte[] data = new byte[maxSize];

            // Generates cryptographically strong random numbers
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(data);

            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }

            return result.ToString();
        }

        // Generates a unique student ID based on cohort year
        public string GenerateStudentId(string cohortYear)
        {
            string uniqueId = cohortYear + GetUniqueKey(6);
            return uniqueId;
        }

        // Generates a unique degree program ID
        public string GenerateDegreeProgramId()
        {
            string uniqueId = GetUniqueKey(6);
            return uniqueId;
        }

        // Generates a unique module code
        public string GenerateModuleCode()
        {
            string uniqueCode = GetUniqueKey(5);
            return uniqueCode;
        }

        // Generates a unique assessment ID
        public string GenerateAssessmentId()
        {
            string uniqueCode = GetUniqueKey(5);
            return uniqueCode;
        }

        // Generates a unique cohort ID
        public string GenerateCohortId()
        {
            string uniqueCode = GetUniqueKey(5);
            return uniqueCode;
        }
    }
}
