namespace SysPaciente.Entities
{
    internal class CpfValidator
    {
        public static bool Validate(string cpf)
        {
            // se não tiver 11 caracteres não é um cpf valido
            if (cpf.Length != 11)
                return false;

            int[] vCPF = new int[11];//vetor para os números do cpf

            // convertendo para int e se não for possivel retorna falso
            for (int i = 0; i < 11; i++)
            {
                if (int.TryParse(cpf.Substring(i, 1), out int digit))
                    vCPF[i] = digit;
                else
                    return false;
            }

            //----------- primeiro digito verificador -----------
            int module = Calculate(vCPF, 10) % 11;
            int firstCheckDigit = 0;//primeiro digito
            if (module > 1)
                firstCheckDigit = 11 - module;

            //----------- segundo digito verificador -----------

            module = (Calculate(vCPF, 11) + firstCheckDigit * 2) % 11;
            int secondCheckDigit = 0;//segundo digito
            if (module > 1)
                secondCheckDigit = 11 - module;

            // verificando se os digitos validadores estão corretos
            if (firstCheckDigit == vCPF[9] && secondCheckDigit == vCPF[10])
                return true;
            else
                return false;

        }

        private static int Calculate(int[] cpf, int value)
        {
            int sumResult = 0;

            for (int i = 0; i < 9; i++)
            {
                sumResult += (value - i) * cpf[i];
            }

            return sumResult;
        }
    }
}
