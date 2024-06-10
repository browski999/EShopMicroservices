namespace Ordering.Domain.ValueObjects;

public record Address
{
    public string Firstname { get; } = default!;
    public string Lastname { get; } = default!;
    public string? EmailAddress { get; } = default!;
    public string AddressLine { get; } = default!;
    public string Country { get; } = default!;
    public string State { get; } = default!;
    public string ZipCode { get; } = default!;

    protected Address()
    {
    }

    private Address(string firstname, string lastname, string emailAddress, string addressLine, string country, string state, string zipcode)
    {
        Firstname = firstname; 
        Lastname = lastname;
        EmailAddress = emailAddress;
        AddressLine = addressLine;
        Country = country;
        State = state;
        ZipCode = zipcode;
    }

    public static Address Of(string firstname, string lastname, string emailAddress, string addressLine, string country, string state, string zipcode)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(emailAddress);
        ArgumentException.ThrowIfNullOrWhiteSpace(addressLine);

        return new Address(firstname, lastname, emailAddress, addressLine, country, state, zipcode);
    }
}