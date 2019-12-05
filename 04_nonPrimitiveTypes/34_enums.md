### Enum

A set of name/value pairs(constants)

i.e.Building an app for a post company, want to support a few different shipping methods: 
(using normal constants): 

const int RegularAirMail = 1;
const int RegisteredAirMail = 2;
const int Express = 3;

Use enums where you have a number of related constants. Instead of declaring multiple constants, declare an enum.

public enum ShippingMethod
{
  RegularAirMail = 1,
  RegisteredAirMail = 2,
  Express = 3
}

var method = ShippingMethod.Express;

an enum is interally an integer. but you can specify byte during delecration of enum if you want.