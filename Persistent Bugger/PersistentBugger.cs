using System;

namespace Persistent_Bugger
{
    public class PersistentBugger
    {
        public int Persistence(long n)
        {
            var persistenceCtr = 0;
            var inputMod = n.ToString();

            while (inputMod.Length != 1)
            {
                var wkInput = 1;
                for (int strIdx = 0; strIdx < inputMod.Length; strIdx++)
                {
                    wkInput *= Convert.ToInt32(inputMod.Substring(strIdx, 1));

                    if ((strIdx + 1) == inputMod.Length)
                    {
                        inputMod = wkInput.ToString();
                        persistenceCtr += 1;
                        break;
                    }
                }
            }

            return persistenceCtr;
        }
    }
}
