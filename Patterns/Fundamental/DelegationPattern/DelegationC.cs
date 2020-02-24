namespace DesiginPatterns.Patterns.Fundamental.DelegationPattern
{
    class DelegationC: IDelegation
    {
        // Создаём объект, методы которого будем делегировать
        IDelegation implementation = new DelegationA();

        public void OperationA()
        {
            implementation.OperationA();
        }
        public void OperationB()
        {
            implementation.OperationB();
        }

        // Этими методами меняем поле-объект, чьи методы будем делегировать
        public void ToA()
        {
            implementation = new DelegationA();
        }

        public void ToB()
        {
            implementation = new DelegationB();
        }
    }
}
