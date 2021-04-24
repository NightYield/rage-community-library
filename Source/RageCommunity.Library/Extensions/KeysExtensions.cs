using System.Windows.Forms;

namespace RageCommunity.Library.Extensions
{
    public static  class KeysExtensions
    {
        /// <summary>
        /// Converts a <see cref="Keys"/> value into the corresponding integer value.
        /// </summary>
        /// <returns>
        /// The integer value for the given key (eg. 1 for Keys.D1) or -1 in case there is no matching int. 
        /// </returns>
        /// <remarks>
        /// Source: https://stackoverflow.com/questions/769529/how-do-i-convert-a-keys-enum-value-to-an-int-character-in-c
        /// </remarks>
        public static int ToInt32(this Keys key)
        {
            var currentKeyEnumIndex = (int) key;
            
            if (currentKeyEnumIndex >= ((int)Keys.NumPad0) && currentKeyEnumIndex <= ((int)Keys.NumPad9))
            { 
                return currentKeyEnumIndex - (int)Keys.NumPad0;
            }
            
            if (currentKeyEnumIndex >= ((int)Keys.D0) && currentKeyEnumIndex <= ((int)Keys.D9))
            {
                return currentKeyEnumIndex - (int)Keys.D0;
            }

            return -1;
        }
    }
}
