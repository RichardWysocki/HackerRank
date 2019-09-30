namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    public  class CustomerSurvey
    {
        public string Country { get; set; }

        public MaritalStatus Maritalstatus { get; set; }

        public bool Kids { get; set; }

        public decimal Salary { get; set; }
    }

    public enum MaritalStatus
    {
        Single, Married, Divorce
    }
}