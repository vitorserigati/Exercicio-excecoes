using Exercicio_excecoes.Entitites.Exceptions;

namespace Exercicio_excecoes.Entitites
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder,double balance,double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public void Deposit(double valor)
        {
            Balance += valor;
        }
        public void Withdraw(double valor)
        {
            if(Balance == 0)
            {

                throw new DomainException("Not enough balance.");
            }
            if(valor > WithdrawLimit)
            {
                throw new DomainException("The ammount exceeds withdraw limit.");
            }
            Balance -= valor;
        }
    }
}
