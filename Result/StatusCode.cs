namespace Result;

public enum StatusCode : ushort
{
	Ok = 200,
	Created = 201,
	RedirectPermanent = 301,
	Redirect = 302,
	Invalid = 400,
	Unauthorized = 401,
	PaymentRequired = 402,
	Forbidden = 403,
	NotFound = 404,
	AlreadyExists = 409,
	InternalError = 500,
	NotImplemented = 501
}