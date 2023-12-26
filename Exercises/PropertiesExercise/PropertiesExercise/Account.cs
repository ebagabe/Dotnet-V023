class Account
{
    public string Holder { get; set; }
    public int AccountId { get; set; }
    public float Balance { get; set; }
    public int Password { get; set; }

    public void ViewInformation()
    {
        Console.WriteLine("Account Information:");
        Console.WriteLine($"Holder: {Holder}");
        Console.WriteLine($"Current balance: {Balance}");
    }
}

