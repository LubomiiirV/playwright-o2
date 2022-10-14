using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

public class Form
{
  private readonly IPage _page;
  private readonly ILocator _btnPersonCompany;
  // private readonly ILocator _txtName;
  // private readonly ILocator _txtSureName;
  // private readonly ILocator _txtPhoneNumber;
  // private readonly ILocator _txtEmail;
  // private readonly ILocator _txtStreet;
  // private readonly ILocator _txtBuildingNumber;
  // private readonly ILocator _txtCity;
  // private readonly ILocator _txtZipCode;
  // private readonly ILocator _btnCountry;
  // private readonly ILocator _chckboxAgreeAll;
  // private readonly ILocator _chckboxAgreeFirst;
  // private readonly ILocator _chckboxAgreeSecond;
  // private readonly ILocator _chckboxAgreeThird;
  // private readonly ILocator _btnAccept;


  public Form(IPage page)
  {
    _page = page;
    _btnPersonCompany = page.Locator("text=súkromná osoba");
  }

  public async Task ClickPerson() => await _btnPersonCompany.ClickAsync();


}