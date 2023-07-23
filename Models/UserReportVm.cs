using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCore.Models;

public class UserReportVm
{
    [DisplayName("Name")] // Used to give name to input. Used in view file
    public string? Name { get; set; } // ? after the type name (string?), signifies nullable type. This type can take null values
    
    [DisplayName("Date created")]
    public DateTime? CreatedDate { get; set; } = DateTime.Today.AddDays(-7);
    
    [DisplayName("User Role")]
    public long? UserRoleId { get; set; }
    public List<UserRole> UserRoles;

    /// <summary>
    /// Builds and returns a select list that can be used in a select html element
    /// nameof(UserRole.Name) => Show the the Name of the user role in the html option element
    /// nameof(UserRole.Id) => Use the Id of user role as the value of the html option element
    /// UserRoleId => The default selected value.
    ///
    /// This works kind of like below
    /// <option value="@userRole.Id" @(userRole.Id == UserRoleId ? "selected" : "")> @userRole.Name </option>
    /// </summary>
    /// <returns></returns>
    public SelectList UserRoleSelectList() =>
        new SelectList(UserRoles, nameof(UserRole.Id), nameof(UserRole.Name), UserRoleId);
}