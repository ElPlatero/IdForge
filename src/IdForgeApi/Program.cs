using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi().AddIdentity<ApplicationUser, ApplicationRole>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

public class ApplicationUser : IdentityUser<long>
{
    public string Organisation { get; set; } = string.Empty;

    public DateTime? PasswordChanged { get; set; } 
    public long? LoginFailures { get; set; } 
    public DateTime? LastLoginFailure { get; set; }
    public long? Status { get; set; }
    public DateTime? LastLogin { get; set; }
    public long? CurrentLogins { get; set; }
    public DateTime? ChangeDat { get; set; }
    public long? ChangeUser { get; set; }
    public long? InsertUser { get; set; }
    public long? LegacyRoleId { get; set; }
    public string? FullName { get; set; }
    public string? Institute { get; set; }
    public string? MailExtension { get; set; }
    public string? Salutation { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public long? OutputOption { get; set; }
    public int? TraceLevel { get; set; }
    public string? Language { get; set; }
    public int? InputWidth { get; set; }
    public int? PageLength { get; set; }
    public int HashVersion { get; set; }
    public long TrackingId { get; set; }
}

public class ApplicationRole : IdentityRole { }
