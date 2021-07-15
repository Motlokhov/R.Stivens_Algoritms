namespace R.Stivens_Algoritms
{
    public static class RaiseToPower
    {
        public static int Do(int A, int P)
        {
            int result = 1;
            int binaryPower = A;
            string binary = ToBinary(P).ToString();
            for(int index = binary.Length-1; index >=0; index--)
            {
                if(binary[index] == '1')
                    result *= binaryPower;;

                binaryPower *= binaryPower;
            }

            return result;
        }

        private static int ToBinary(int A)
        {
            if(A <= 1)
                return A;

            const int binaryModifier = 2;
            const int decimalModifier = 10;
            int length = 0;
            int N = 1;

            do
            {
                N *= 2;
                length++;
            } while(N <= A);

            int innerA = A;
            int result = 0;
            for(int i = 0; i < length; i++)
            {
                result += innerA % binaryModifier * Do(decimalModifier, i);
                innerA /= binaryModifier;
            }

            result += innerA * Do(decimalModifier, length - 1);
            return result;
        }
    }
}
