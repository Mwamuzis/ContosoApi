namespace ConsoleApp1.Models.AuthUser;
using System.Collections.Generic;
// using System.IO.File;
using System.Text.Json;
// using System.Text.Json.JsonSerializer;


public class AuthUser {
    public  int _UserId { get; set; }
    /*publicb */ string? _UserName { get; set; }
    /*publicb */ string? _Email { get; set; }
    /*publicb */ string? _Password { get; set; }
    /*publicb */ string? _FirstName { get; set; }
    /*publicb */ string? _LastName { get; set; }
    /*publicb */ string? _PhoneNumber { get; set; }
    /*publicb */ bool? _IsActive { get; set; }
    /*publicb */ bool? _IsSuperuser { get; set; }
    /*publicb */ bool? _IsStaff { get; set; }
    /*publicb */ bool? _IsDeleted { get; set; }
    /*public*/ DateTime? _CreatedAt { get; set; }
    /*public*/ DateTime? _UpdatedAt { get; set; }

    // relations fields
    // public AuthGroup AuthGroup  { get; set; } = null!;


    // Create a class constructor for the AuthUser class
    public AuthUser(int UserId, string UserName, string Email, string Password, string FirstName, string LastName, string PhoneNumber, bool IsActive, bool IsSuperuser, bool IsStaff, bool IsDeleted, DateTime CreatedAt, DateTime UpdatedAt) {
        _UserId = UserId;
        _UserName = UserName;
        _Email = Email;
        _Password = Password;
        _FirstName = FirstName;
        _LastName = LastName;
        _PhoneNumber = PhoneNumber;
        _IsActive = IsActive;
        _IsSuperuser = IsSuperuser;
        _IsStaff = IsStaff;
        _IsDeleted = IsDeleted;
        _CreatedAt = CreatedAt;
        _UpdatedAt = UpdatedAt;
    }


    // get all description
    public string GetDescription() {
        return $"UserId: {_UserId}, UserName: {_UserName}, Email: {_Email}, Password: {_Password}, FirstName: {_FirstName}, LastName: {_LastName}, PhoneNumber: {_PhoneNumber}, IsActive: {_IsActive}, IsSuperuser: {_IsSuperuser}, IsStaff: {_IsStaff}, IsDeleted: {_IsDeleted}, CreatedAt: {_CreatedAt}, UpdatedAt: {_UpdatedAt}";
    }

    // get user id
    public int GetUserId() {
        return _UserId;
    }

    // save user in users.json file by index
    public void SaveUser() {
        // save user in users.json file by index
        string jsonString = JsonSerializer.Serialize(this);
        List<AuthUser> UsersList = new() { this};
        jsonString = JsonSerializer.Serialize(UsersList);
        File.WriteAllText("users.json", jsonString);

}

}

